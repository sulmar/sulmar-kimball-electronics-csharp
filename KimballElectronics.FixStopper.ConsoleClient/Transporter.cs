using KimballElectronics.FixStopper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.FixStopper.ConsoleClient
{
    public class Transporter
    {
        private FakeBarCodeReader barCodeReader;
        private OpticalSensor opticalSensor;
        private FakeDbTraceService traceService;
        private Actuator actuator;
        private Andon andon;

        private Fixture currentFixture;

        private System.Timers.Timer timer;

        public Transporter(FakeDbTraceService traceService, FakeBarCodeReader barCodeReader, OpticalSensor opticalSensor, Actuator actuator, Andon andon)
        {
            this.traceService = traceService;
            this.barCodeReader = barCodeReader;
            this.opticalSensor = opticalSensor;
            this.actuator = actuator;
            this.andon = andon;

            timer = new System.Timers.Timer(3000);

            timer.Elapsed += Timer_Elapsed;

            // podpięcie się pod zdarzenie
            opticalSensor.Detected += OpticalSensor_Detected;

            andon.SetStatus(AndonStatus.Ok);
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            actuator.Close();
            timer.Stop();
        }

        // Obsługa zdarzenia
        private void OpticalSensor_Detected(object sender, EventArgs e)
        {
            currentFixture = new Fixture();
            currentFixture.BarCode = barCodeReader.GetBarCode();

            Console.WriteLine($"Detected {currentFixture.BarCode}");

            try
            {
                FixtureStatus fixtureStatus = traceService.GetStatus(currentFixture.BarCode);

                if (fixtureStatus == FixtureStatus.Ok)
                {
                    andon.SetStatus(AndonStatus.Ok);

                    actuator.Open();
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                andon.SetStatus(AndonStatus.nOk);
            }
        }
    }
}
