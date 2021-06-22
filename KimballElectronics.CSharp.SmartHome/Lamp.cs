using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.CSharp.SmartHome
{
    // Klasa - abstrakcyjny opis 
    class Lamp
    {
        // Cechy/atrybuty

        /*
        private float voltage;

        public float Voltage
        {
            get
            {
                return voltage;
            }

            set
            {
                voltage = value;
            }
        }

        */

        public float Voltage { get; set; }

        public float Power { get; set; }


        public string serialNumber;

        // pole
        // private (jest domyślnie)
        private bool isPowerOn;

        // Właściwość (property)
        public bool IsPowerOn
        {
            // setter
            set
            {
                if (value == true)
                {
                    Console.WriteLine("Załączona lampa");
                }
                else
                {
                    Console.WriteLine("Wyłączona lampa");
                }

                isPowerOn = value;                
            }

            // getter
            get
            {
                return isPowerOn;
            }
        }

        /*
        // getter
        public bool GetPowerOn()
        {
            return isPowerOn;
        }

        // setter
        public void SetPowerOn(bool value)
        {
            isPowerOn = value;
        }

        */

        // Metody

        public void PowerOn()
        {
            Console.WriteLine("Załączenie lampy");
            isPowerOn = true;
        }

        public void PowerOff()
        {
            Console.WriteLine("Wyłączenie lampy");
            isPowerOn = false;
        }

       

       
        public void Switch()
        {
            if (isPowerOn)      // == porównanie
            {
                Console.WriteLine("Wyłączenie lampy");
                isPowerOn = false;      // = przypisanie
            }
            else
            {
                Console.WriteLine("Załączenie lampy");
                isPowerOn = true;
            }
        }
    }
}
