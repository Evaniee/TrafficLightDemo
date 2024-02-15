using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightDemo
{
    internal class TrafficLight
    {
        /// <summary>
        /// Represents the state of a Signal Box
        /// </summary>
        private enum State                  //  TODO: Modify states to match a Traffic Light's States
        {
            Red = 1,
            Green = 2
        }

        // Variables                            TODO: Add in missing light
        private Lamp _redLamp;      // Signal Box's red Lamp
        private Lamp _greenLamp;    // Signal Box's green Lamp
        private State _state;       // Signal Box's current state

        /// <summary>
        /// Represents a Signal Box
        /// </summary>
        /// <param name="x">Top left X coordinate of Lamp</param>
        /// <param name="y">Top left y coordinate of Lamp</param>
        public TrafficLight(int x, int y)   //  TODO: Add in missing light and adjust positions
        {
            _redLamp = new Lamp(Color.Red, x, y);
            _greenLamp = new Lamp(Color.Green, x, y + 50);

            _state = State.Red;
        }

        /// <summary>
        /// Change the State of the Signal Box
        /// </summary>
        public void ChangeState()           //  TODO: Include all required states, modified to match a Traffic Light's behaviour
        {
            switch (_state)
            {
                case State.Red:
                    _redLamp.ChangeState(true);
                    _greenLamp.ChangeState(false);
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
        /// Display the Traffic Light
        /// </summary>
        /// <param name="g">Graphics object to draw the Traffic Light to</param>
        public void Display(Graphics g)     //  TODO: Draw the missing light
        {
            _redLamp.Display(g);
            _greenLamp.Display(g);
        }
    }
}
