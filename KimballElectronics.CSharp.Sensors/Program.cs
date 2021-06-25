using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace KimballElectronics.CSharp.Sensors
{
    class Program
    {
        static void Main(string[] args)
        {
            PressureSensor pressureSensor = new PressureSensor();
            pressureSensor.SerialNumber = "P001";
            pressureSensor.Init();

            Thermometer thermometer = new Thermometer();
            thermometer.Init();

            UltrasoundsProximitySensor ultrasoundsProximitySensor = new UltrasoundsProximitySensor();
            ultrasoundsProximitySensor.Init();

            LaserProximitySensor laserProximitySensor = new LaserProximitySensor();
            laserProximitySensor.Init();

            LaserProximitySensor laserProximitySensor2 = new LaserProximitySensor();
            laserProximitySensor2.Init();

            LaserProximitySensor proximitySensor = new LaserProximitySensor();
            int distance3 = proximitySensor.GetDistance();

            int distance1 = ultrasoundsProximitySensor.GetDistance();
            Console.WriteLine(distance1);
            int distance2 = laserProximitySensor.GetDistance();
            Console.WriteLine(distance2);

            Console.Clear();

            List<ProximitySensor> proximitySensors = new List<ProximitySensor>();
            proximitySensors.Add(laserProximitySensor);
            proximitySensors.Add(laserProximitySensor2);
            proximitySensors.Add(new LaserProximitySensor());
            proximitySensors.Add(ultrasoundsProximitySensor);
            proximitySensors.Add(new AnalogProximitySensor());


            // UI
            foreach (ProximitySensor sensor in proximitySensors)
            {
                int distance = sensor.GetDistance();

                Console.WriteLine(distance);
            }
        }
    }


    // Klasa bazowa dla wszystkich czujników
    abstract class BaseSensor
    {
        private bool isPowerOn;

        public string Name { get; set; }    // snippet: prop + 2 x TAB - tworzenie właściwości
        public string SerialNumber { get; set; }

        public float Accurancy { get; set; }

        public DateTime ProductionYear { get; set; }

        public void Init()
        {
            isPowerOn = true;
        }
    }

    // Konkretna klasa, która dziedziczy po klasie bazowej BaseSensor

    // Klasa abstrakcyjna - nie można utworzyć instancji obiektu tej klasy
    abstract class ProximitySensor : BaseSensor
    {
        // Pola

        // Właściwości
       

        // Konstruktor
        public ProximitySensor()
        {
            Accurancy = 1;
        }

        // Metody
        public abstract int GetDistance();  // Metoda abstrakcyjna - implementacja znajduje się w klasie potomnej
        
    }

    // Klasa Debug - umożliwia zapisywanie informacji na konsoli diagnostycznej
    // Następnie wyniki można oglądać bezpośrednio w Visual Studio na zakładce Output -> Debug
    // lub na produkcji za pomocą narzędzia DebugView
    // https://docs.microsoft.com/en-us/sysinternals/downloads/debugview

    // Klasa potomna 
    class UltrasoundsProximitySensor : ProximitySensor
    {
        public float Frequency { get; set; }
        
        public override int GetDistance()   // override - nadpisanie metody
        {
            Debug.WriteLine("Calculating distance with Ultrasound...");

            return 99;
        }

    }

    // Klasa potomna
    class LaserProximitySensor : ProximitySensor
    {
        public string Color { get; set; }

        public float Power { get; set; }

        public override int GetDistance()   // override - nadpisanie metody
        {
            Debug.WriteLine("Calculating distance with Laser...");

            return 101;
        }
    }

    class AnalogProximitySensor : ProximitySensor
    {
        public override int GetDistance()
        {
            Debug.WriteLine("Calculating distance with Analog...");

            return 100;
        }
    }


    class Thermometer : BaseSensor
    {
        public int MinTemperature { get; set; }
        public int MaxTemperature { get; set; }

        public int CurrrentTemperature { get; set; }

    }

    class ReflectiveSensor : BaseSensor
    {
        public bool State { get; }
    }


    class PressureSensor : BaseSensor   // Dziedziczenie - dziedziczy wszystkie cechy i metody (oprócz prywatnych)
    {
        public int MinPressure { get; set; }
        public int MaxPressure { get; set; }
    }


    class Voltometer
    {
        public Phase L1 { get; set; }
        public Phase L2 { get; set; }
        public Phase L3 { get; set; }
    }

    class Phase
    {
        public float Voltage { get; set; }
        public float Power { get; set; }

        public float Calculate()
        {
            return Voltage * Power;
        }
    }

}
