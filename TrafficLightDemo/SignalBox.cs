using System.Drawing;
using System.Xml.Schema;

namespace TrafficLightDemo
{


    internal class SignalBox
    {
        /// <summary>
        /// Represents the state of a Signal Box
        /// </summary>
        private enum State
        {
            Red = 1,
            Green = 2
        }

        private Lamp _redLamp;      // Signal Box's red Lamp
        private Lamp _greenLamp;    // Signal Box's green Lamp
        private State _state;         // Signal Box's current state

        /// <summary>
        /// Represents a Signal Box
        /// </summary>
        /// <param name="x">Top left X coordinate of Lamp</param>
        /// <param name="y">Top left y coordinate of Lamp</param>
        public SignalBox(int x, int y)
        {
            _redLamp = new Lamp(Color.Red, x, y);
            _greenLamp = new Lamp(Color.Green, x, y + 50);

            _state = State.Red;
        }

        /// <summary>
        /// Change the State of the Signal Box
        /// </summary>
        public void ChangeState()
        {
            switch(_state)
            {
                case State.Red: 
                    // Change Lamp states
                    _redLamp.ChangeState(true);
                    _greenLamp.ChangeState(false);
                    // Set next state
                    _state = State.Green;
                    break;

                case State.Green:
                    _redLamp.ChangeState(false);
                    _greenLamp.ChangeState(true);
                    _state = State.Red;
                    break;
            }
        }

        /// <summary>
        /// Display the Signal Box
        /// </summary>
        /// <param name="g">Graphics object to draw the Signal Box to</param>
        public void Display(Graphics g)
        {
            _redLamp.Display(g);
            _greenLamp.Display(g);
        }
    }
}
