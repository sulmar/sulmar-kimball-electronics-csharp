using System;
using KimballElectronics.FixStopper.Models;

namespace KimballElectronics.FixStopper.ConsoleClient
{
    // F9 - ustawienie pułapki (breakpoint)
    // Ctrl+Shift-F9 - wyczyszczenie wszystkich pułapek (breakpoints)

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fix Stopper wersja 1.0");

            /*

            bool isLaser = true;

            if (isLaser)
            {

            }
            else
            {
                opticalSensor = new OpticalSensor();
            }
            */
            // tworzenie instacji obiektów

            try
            {
                FakeDbTraceService traceService = new FakeDbTraceService();
                FakeBarCodeReader barCodeReader = new FakeBarCodeReader();
                // COMOpticalSensor opticalSensor = new COMOpticalSensor("COM1");
                OpticalSensor opticalSensor = new OpticalSensor();

                Actuator actuator = new Actuator();
                Andon andon = new Andon();

                Transporter transporter = new Transporter(traceService, barCodeReader, opticalSensor, actuator, andon);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }

  

    public class FakeDbTraceService
    {
        private Fixture fixture;

        public FakeDbTraceService()
        {
            fixture = new Fixture { BarCode = "123456789", Status = FixtureStatus.Ok };
        }

        public FixtureStatus GetStatus(string barCode)
        {
            if (fixture.BarCode == barCode)
            {
                return fixture.Status;
            }
            else
            {
                // rzucamy wyjątek
                throw new Exception($"Fixture {barCode} not found");
            }
        }
    }
}
