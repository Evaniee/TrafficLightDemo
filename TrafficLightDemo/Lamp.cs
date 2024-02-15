using System.Drawing;

namespace TrafficLightDemo
{
    internal class Lamp
    {
        private Color _lampColour;      // Colour of Lamp
        private bool _state;            // Is the Lamp currently on?
        private Rectangle _position;    // Top left Y coordinate of Lamp

        /// <summary>
        /// Represents a single lamp
        /// </summary>
        /// <param name="lampColour">Colour of Lamp</param>
        /// <param name="x">Top left X coordinate of Lamp</param>
        /// <param name="y">Top left y coordinate of Lamp</param>
        public Lamp(Color lampColour, int x, int y)
        {
            this._lampColour = lampColour;
            this._state = false;
            this._position = new Rectangle(x, y, 50, 50);
        }

        /// <summary>
        /// Change the state of the Lamp
        /// </summary>
        public void ChangeState() { _state = !_state; }

        /// <summary>
        /// Change the state of the Lamp to a given state
        /// </summary>
        /// <param name="state">New State of the Lamp</param>
        public void ChangeState(bool state) { _state = state; }

        /// <summary>
        /// Display the Lamp
        /// </summary>
        /// <param name="g">Graphics object to draw the Lamp to</param>
        public void Display(Graphics g)
        {
            SolidBrush brush;

            if (_state) brush = new SolidBrush(_lampColour);
            else brush = new SolidBrush(Color.Gray);

            g.FillEllipse(brush, _position);
        }
    }
}
