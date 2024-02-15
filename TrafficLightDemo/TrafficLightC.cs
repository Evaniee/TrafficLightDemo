using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightDemo
{
    internal class TrafficLightC
    {
        /// <summary>
        /// Represents the state of a Signal Box
        /// </summary>
        private enum State
        {
            Red = 1,
            RedYellow = 2,
            Green = 3,
            Yellow = 4
        }

        // Variables
        private Lamp _redLamp;      // Signal Box's red Lamp
        private Lamp _yellowLamp;   // Signal Box's yellow Lamp
        private Lamp _greenLamp;    // Signal Box's green Lamp
        private State _state;       // Signal Box's current state

        /// <summary>
        /// Represents a Signal Box
        /// </summary>
        /// <param name="x">Top left X coordinate of Lamp</param>
        /// <param name="y">Top left y coordinate of Lamp</param>
        public TrafficLightC(int x, int y)
        {
            _redLamp = new Lamp(Color.Red, x, y);
            _yellowLamp = new Lamp(Color.Yellow, x, y + 50);
            _greenLamp = new Lamp(Color.Green, x, y + 100);

            _state = State.Red;
        }

        /// <summary>
        /// Change the State of the Signal Box
        /// </summary>
        public void ChangeState()
        {
            switch (_state)
            {
                case State.Red:
                    _redLamp.ChangeState(true);
                    _yellowLamp.ChangeState(false);
                    _greenLamp.ChangeState(false);
                    _state = State.RedYellow;
                    break;
                case State.RedYellow:
                    _redLamp.ChangeState(true);
                    _yellowLamp.ChangeState(true);
                    _greenLamp.ChangeState(false);
                    _state = State.Green;
                    break;
                case State.Green:
                    _redLamp.ChangeState(false);
                    _yellowLamp.ChangeState(false);
                    _greenLamp.ChangeState(true);
                    _state = State.Yellow;
                    break;
                case State.Yellow:
                    _redLamp.ChangeState(false);
                    _yellowLamp.ChangeState(true);
                    _greenLamp.ChangeState(false);
                    _state = State.Red;
                    break;
            }
        }

        /// <summary>
        /// Display the Traffic Light
        /// </summary>
        /// <param name="g">Graphics object to draw the Traffic Light to</param>
        public void Display(Graphics g)
        {
            _redLamp.Display(g);
            _yellowLamp.Display(g);
            _greenLamp.Display(g);
        }
    }
}
