using System;
using System.IO;

namespace KimballElectronics.CSharp.MACAddressGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // komentarz pojedynczej linii

            /* blokowy komentarz

            Console.WriteLine('A');

            Console.WriteLine(100);

            Console.WriteLine(true);

            */

            // F5 - uruchomienie aplikacji

            // F9 - pułapka/punkt przerwania (breakpoint)
            Console.WriteLine("MAC Address Generator 1.0");

            // Podaj ilość: 100
            Console.Write("Podaj ilość: ");

            // Konwencje
            // zmienne - notacja wielbłądzia (camel-case) numberOfDevices
            // metody  - notacja Pascalowa (pascal-case) WriteLine()
            //         - notacja węża (snake-case) number_of_devices

            string quantityString = Console.ReadLine();
            int quantity = int.Parse(quantityString);

            Console.Write("Podaj prefiks (XX-XX-XX): ");
            string prefix = Console.ReadLine();

            StreamWriter writer = File.CreateText("output.txt");

            // snippet: cw
            Console.WriteLine("SerialNumber,MACAddress,Timestamp");

            writer.WriteLine("SerialNumber,MACAddress,Timestamp");

            for(int index = 1; index <= quantity; index++)
            {
                // Konkatenacja +
                // string line = index + "," + prefix + "-C9-6D-74-B5-6B," + DateTime.Now;

                // Konkatenacja za pomocą string.Format()
                // string line = string.Format("{0},{1}-C9-6D-74-B5-6B,{2}", index, prefix, DateTime.Now);

                string macAddress = GetRandomMac(prefix);                

                // Interpolacja
                string line = $"{index},{macAddress},{DateTime.Now}";

                Console.WriteLine(line);

                // Zapis do pliku

                // File.WriteAllText("output.txt", line);
                writer.WriteLine(line);

            }

            writer.Close();     // zamyka strumień
            writer.Dispose();   // zwalnia zasoby
            
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

            // pętle
            /*
            while(true)
            {
                // ..


                while(true)
                {

                }
            }

            do
            {
                // ...
            } while (true);

    */


        }


        //static (float, float) GetLocation()
        //{

        //}


        // metoda
        static string GetRandomMac(string prefix, char separator = '-')     // parametr opcjonalny
        {
            Random random = new Random();

            // https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
            string segment4 = random.Next(0, 255).ToString("X");
            string segment5 = random.Next(0, 255).ToString("X");
            string segment6 = random.Next(0, 255).ToString("X");

            string macAddress = $"{prefix}{separator}{segment4}{separator}{segment5}{separator}{segment6}";

            return macAddress;
        }

        // static
    }
}
