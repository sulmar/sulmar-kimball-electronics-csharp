using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KimballElectronics.FixStopper.Models
{
    class ClassName
    {
        // Pola

        // Właściwości

        // Konstruktory

        // Metody
    }


    // Klasa
    public class Actuator
    {
        // Pole
        private bool isOn;

        // Właściwość
        public ActuatorState State { get; set; }

        // Konstruktor
        public Actuator()
        {
            State = ActuatorState.Closed;
        }

        // Metoda
        public void Open()
        {
            State = ActuatorState.Opened;

            Console.WriteLine(State);
        }
        
        // Metoda
        public void Close()
        {
            State = ActuatorState.Closed;

            Console.WriteLine(State);
        }
    }

    // Typ wyliczeniowy

    public enum ActuatorState
    {
        Opened = 0,
        Closed = 1,
        Undetermined = 2
    }
}
