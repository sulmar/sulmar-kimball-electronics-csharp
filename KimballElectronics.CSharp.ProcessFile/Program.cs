using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KimballElectronics.CSharp.ProcessFile
{

    class CsvFileFixtureService
    {
        public List<Fixture> Get(string filename)
        {
            List<Fixture> fixtures = new List<Fixture>();

            // 1. Import fixtures
            string[] lines = File.ReadAllLines(filename);

            foreach (string line in lines.Skip(1))
            {
                Console.WriteLine(line);

                string[] columns = line.Split(',');

                string barCode = columns[0];
                DateTime timeStamp = DateTime.Parse(columns[1]);

                Fixture fixture = new Fixture(barCode);
                fixture.Timestamp = timeStamp;

                fixtures.Add(fixture);
            }

            return fixtures;

        }


        public void Add(string filename, List<Fixture> fixtures)
        {
            StreamWriter writer = File.CreateText(filename);

            writer.WriteLine("Timestamp,BarCode,ReadTime");

            foreach (Fixture fixture in fixtures)
            {
                writer.WriteLine($"{fixture.Timestamp},{fixture.BarCode},{DateTime.Now}");
            }

            writer.Close();
        }
    }

    class BinFileFixtureService
    {
        public List<Fixture> Get(string filename)
        {
            throw new NotImplementedException();
        }
    }

    class DbFixtureService
    {
        public List<Fixture> Get(string connectionString)
        {
            throw new NotImplementedException();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            // CsvFileFixtureService fixtureService = new CsvFileFixtureService();
            // List<Fixture> fixtures = fixtureService.Get("input.csv");
            // Display(fixtures);
            // fixtureService.Add("output.csv", fixtures);

            //List<Fixture> fixtures = new List<Fixture>();

            //// 1. Import fixtures
            //string[] lines = File.ReadAllLines("input.csv");

            //foreach (string line in lines.Skip(1))
            //{
            //    Console.WriteLine(line);

            //    string[] columns = line.Split(',');

            //    string barCode = columns[0];
            //    DateTime timeStamp = DateTime.Parse(columns[1]);

            //    Fixture fixture = new Fixture(barCode);
            //    fixture.Timestamp = timeStamp;

            //    fixtures.Add(fixture);
            //}

            CsvFileFixtureService fixtureService = new CsvFileFixtureService();
            List<Fixture> fixtures = fixtureService.Get("input.csv");


            // 2. Display fixtures
            Display(fixtures);


            // 3. Export fixtures

            //string[] outputs = new string[fixtures.Count];

            //for (int i = 0; i < fixtures.Count; i++)
            //{
            //    outputs[i] = $"{fixtures[i].Timestamp},{fixtures[i].BarCode},{DateTime.Now}";
            //}

            //File.AppendAllLines("output.csv", outputs);

            // File.AppendText  - dopisuje do istniejącego pliku lub go tworzy
            // File.CreateText - tworzy nowy plik lub nadpisuje zawartość

            //if (File.Exists("output.csv"))
            //{
            //    File.Delete("output.csv");
            //}


            // 3.

            //StreamWriter writer = File.CreateText("output.csv");

            //writer.WriteLine("Timestamp,BarCode,ReadTime");

            //foreach (Fixture fixture in fixtures)
            //{
            //    writer.WriteLine($"{fixture.Timestamp},{fixture.BarCode},{DateTime.Now}");
            //}

            //writer.Close();

            fixtureService.Add("output.csv", fixtures);



            // ReadAllTextTest();
        }

        private static void Display(List<Fixture> fixtures)
        {
            foreach (Fixture fixture in fixtures)
            {
                Console.WriteLine($"{fixture.BarCode} {fixture.Timestamp}");
            }
        }

        private static void ReadAllTextTest()
        {
            string content = File.ReadAllText("input.csv");

            Console.WriteLine(content);
        }
    }
}
