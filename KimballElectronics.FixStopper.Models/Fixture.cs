using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.FixStopper.Models
{
    public class Fixture
    {
        public string BarCode { get; set; }
        public FixtureStatus Status { get; set; }
    }

    public enum FixtureStatus
    {
        Ok,
        nOK,
        Warning
    }
}
