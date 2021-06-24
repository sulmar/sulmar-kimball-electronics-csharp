using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.FixStopper.Models
{
    public class Camera
    {
        public string Przyslona { get; set; }

        public string Take()
        {
            return "1234";
        }
    }

    internal class Laser
    {
        public string Take()
        {
            return "4321";
        }
    }

    public class BarCodeReader
    {
        private bool isPowerOn;

        private Camera camera;

        public string Port { get; set; }
        public int BitRate { get; set; }

        public BarCodeReader(Camera camera)
        {
            this.camera = camera;
        }
        
        public string GetBarCode()
        {
            string barcode = camera.Take();

            // TODO: ...

            throw new NotImplementedException();
        }
    }

    // Fake - udawany
    public class FakeBarCodeReader
    {
        public string GetBarCode()
        {
            string barcode = "ABC123456789";

            return barcode;
        }
    }

    public class AbcBarCodeReader
    {
        // Dodaj using System.Runtime.InteropServices;
        [DllImport("barcodereader.dll")]        // sposób na zaimportowanie biblioteki DLL
        public static extern string Scan(int codeType);     // deklarujemy tylko nagłówek metody
    }
}
