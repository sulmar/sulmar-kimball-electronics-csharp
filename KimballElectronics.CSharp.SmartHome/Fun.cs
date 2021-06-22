using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.CSharp.SmartHome
{
    class Fun
    {
        private const int ratioRPM = 100;

        private bool isOn;

        private int RPM;

        public float PowerPerUnit;

        public float TotalPower; // PowerPerUnit * RPM

        public decimal UnitPrice;

        public string serialNumber;

        public DateTime productionDate;

        // konstruktor - metoda uruchamiania przy tworzeniu obiektu
        public Fun(string serialNumber)   
            : this()    
        {
            this.serialNumber = serialNumber;
        }

        public Fun(string serialNumber, int rpm)
            : this(serialNumber)
        {            
            this.RPM = rpm;
        }

        public Fun()
        {
            // ustawianie wartości początkowych
            this.isOn = true;
            this.RPM = 50;
            this.productionDate = DateTime.Today;
        }

        // Konstruktor służy 
        // 1. do ustawiania wartości początkowych (domyślnych)
        // 2. do określenia wymaganych parametrów

        public void Switch()
        {
            //if (isOn)
            //    isOn = false;
            //else
            //    isOn = true;

            isOn = !isOn;
        }

        private byte speed;

        public byte Speed
        {
            set                     // <--- setter (metoda do ustawiania)
            {
                if (Validate(value))
                {
                    SetSpeed(value);

                    speed = value;
                }
            }

            get                     // <--- getter (metoda do pobierania)
            {
                return speed;
            }
        }


        private void SetSpeed(byte speed)
        {
            // walidacja

            if (isOn == false)
            {
                throw new Exception("urządzenie nie jest włączone");
            }

            if (Validate(speed))   // && - AND iloczyn logiczny     || - OR suma logiczna     ! - negacja
            {
                RPM = speed * ratioRPM;
            }
            else
            {
                Exception exception = new Exception("Nieobsługiwana prędkość");

                throw exception;

                //   Console.WriteLine("Nieobsługiwana prędkość");
            }

            // Wyświetlenie prędkości
            Display(speed);


        }

        public int SetSpeed2(byte speed)
        {
            if (Validate(speed))   // && - AND iloczyn logiczny     || - OR suma logiczna     ! - negacja
            {
                RPM = speed * 100;

                return 0;
            }
            else
            {
                return -100; // przekroczony zakres
                return -200; // urządzenie nie jest włączone

                //   Console.WriteLine("Nieobsługiwana prędkość");
            }

            Display(speed);

        }

        private bool Validate(byte speed)
        {
            return speed >= 1 && speed <= 3;

            //if (speed >= 1 && speed <= 3)
            //{
            //    return true;
            //}
            //else
            //    return false;
        }

        private void Display(byte speed)
        {
            // if (speed == 1)
            // {
            //     Console.WriteLine("Niskie obroty wentylatora");
            // }
            // else
            // if (speed == 2)
            // {
            //     Console.WriteLine("Średnie obroty");
            // }
            // else
            // if (speed == 3)
            // {
            //     Console.WriteLine("Wysokie obroty");
            // }
            // else
            // {
            //     Console.WriteLine("Poza zakresem");
            // }

            switch (speed)
            {
                case 1: Console.WriteLine("Niskie obroty wentylatora"); break;
                case 2: Console.WriteLine("Średnie obroty"); break;
                case 3: Console.WriteLine("Wysokie obroty"); break;

                default: Console.WriteLine("Poza zakresem"); break;
            }
        }

        public int GetRPM()
        {
            return RPM;
        }


    }
}
