using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.FixStopper.Models
{
    public class Andon
    {
        public AndonStatus Status { get; set; }

        public Andon()
        {
            Status = AndonStatus.Ok;
        }

        public void SetStatus(AndonStatus status)
        {
            if (status == AndonStatus.Error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            if (status == AndonStatus.nOk)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine(status);
            Console.ResetColor();

            this.Status = status;
        }
    }

    public enum AndonStatus
    {
        Ok,
        nOk,
        Error
    }
}
