using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO.Ports;

namespace KimballElectronics.FixStopper.Models
{
    // https://docs.microsoft.com/pl-pl/dotnet/api/system.io.ports.serialport.datareceived?view=dotnet-plat-ext-5.0#przyk-ady

    public class COMOpticalSensor : IDisposable
    {
        public string Name { get; set; }
        public bool State { get; }

        // deklaracja zdarzenia (event)
        public event EventHandler Detected;      

        private SerialPort serialPort;

        public COMOpticalSensor(string portName)
        {
            serialPort = new SerialPort(portName);
            serialPort.BaudRate = 9600;
            serialPort.StopBits = StopBits.One;
            serialPort.DataBits = 8;
            serialPort.Handshake = Handshake.None;
            serialPort.RtsEnable = true;

            serialPort.DataReceived += SerialPort_DataReceived;

            serialPort.Open();          
        }

        public void Dispose()  // Zwalnianie zasobów (niezarządzalnych)
        {
            serialPort.Close();
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();

            Console.WriteLine($"Data received {data}");

            if (data == "DETECT")  // Przetwarzanie danych
            {
                if (Detected!=null)
                {
                    // Wyzwolenie zdarzenia
                    Detected.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }

    public class OpticalSensor
    {
        public string Name { get; set; }
        public bool State { get; }  // właściwość tylko do odczytu

        // deklaracja zdarzenia (event)
        public event EventHandler Detected;

        private Timer timer;

        // Konstruktor
        public OpticalSensor()
        {
            timer = new Timer(5000);
            timer.Elapsed += Timer_Elapsed;

            timer.Start();            
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Detected != null)   // Sprawdzenie czy ktoś jest podpięty pod zdarzenie
            {
                // Wyzwolenie zdarzenia
                Detected.Invoke(this, EventArgs.Empty); 
            }
        }
    }
}
