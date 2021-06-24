using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.CSharp.ProcessFile
{
    class Fixture
    {
        public string BarCode { get; set; }

        public DateTime Timestamp { get; set; }

        public Fixture(string barcode)
        {
            this.BarCode = barcode;
        }
    }
}
