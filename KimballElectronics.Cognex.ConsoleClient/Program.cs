using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Keyence.AutoID.SDK;

namespace KimballElectronics.Cognex.ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string addressIp = "127.0.0.1";
            ReaderAccessor readerAccessor = new ReaderAccessor(addressIp);
            readerAccessor.Connect();
            readerAccessor.ExecCommand("LON");

            readerAccessor.Disconnect();
            readerAccessor.Dispose();
        }
    }

    class KeyenceBarCodeReader : IDisposable
    {
        private ReaderAccessor readerAccessor;

        public KeyenceBarCodeReader(string addressIp)
        {
            readerAccessor = new ReaderAccessor(addressIp);
        }

        public string Scan()
        {
            readerAccessor.Connect();
            readerAccessor.ExecCommand("LON");

            readerAccessor.Disconnect();

            throw new NotImplementedException();
        }

        public void Dispose()
        {
            readerAccessor.Dispose();
        }
    }
}
