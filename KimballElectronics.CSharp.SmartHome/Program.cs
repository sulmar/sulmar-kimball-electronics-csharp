using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.CSharp.SmartHome
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Fun fun2 = new Fun()                  // Utworzenie obiektu za pomocą inicjalizatora
                {
                    PowerPerUnit = 10,
                    UnitPrice = 2,                                        
                };


                Fun fun1 = new Fun("ABC1234");               // Utworzenie obiektu i przypisanie wartości poprzez pola
                fun1.PowerPerUnit = 10;

                fun1.Switch();
                fun1.Switch();


                while (true)
                {
                    Console.Write("Podaj Speed: ");

                    byte speed;

                    if (byte.TryParse(Console.ReadLine(), out speed))
                    {
                        try
                        {
                            fun1.Speed = speed;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            System.IO.File.AppendAllText("log.txt", e.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Błędna wartość");
                    }

                    int rpm = fun1.GetRPM();

                    Console.WriteLine(fun1.Speed);
                    Console.WriteLine($"{rpm} obr/min");
                }


                // utworzenie obiektu / utworzenie instancji klasy
                Lamp lamp1;

                lamp1 = new Lamp();
                lamp1.serialNumber = "ABC123";
                lamp1.voltage = 230;
                lamp1.power = 2;

                lamp1.IsPowerOn = true;

                bool isOn = lamp1.IsPowerOn;

                Console.WriteLine(isOn);

                
// bool isPowerOn = lamp1.GetPowerOn();


                lamp1.Switch();
                lamp1.Switch();
                lamp1.Switch();

                //lamp1.PowerOn();            
                //lamp1.PowerOff();

                Lamp lamp2 = new Lamp();
                lamp2.serialNumber = "BCA321";
                lamp2.voltage = 230;
                lamp2.power = 5;

                lamp2.Switch();

                // CTRL K+C zakomentowanie / CTRL K+U odkomentowanie
                //lamp2.PowerOn();
                //lamp2.PowerOff();


            }
            catch
            {
            }

        }
    }

}
