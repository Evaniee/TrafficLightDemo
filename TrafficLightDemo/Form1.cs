using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLightDemo
{
    public partial class Form1 : Form
    {
        private Lamp _lamp;                     // Single Lamp
        private SignalBox _signalBox;           // Signal Box
        private TrafficLight _trafficLight;     // Traffic Light

        public Form1()
        {
            _lamp = new Lamp(Color.Red, 10, 10);
            _signalBox = new SignalBox(110, 10);
            _trafficLight = new TrafficLight(210, 10);
            
            InitializeComponent();
        }

        // Occurs every timer interval
        private void tmr_state_Tick(object sender, EventArgs e)
        {
            // Change object states
            _lamp.ChangeState();
            _signalBox.ChangeState();
            _trafficLight.ChangeState();

            // Force redraw of picturebox (Calls pb_ara_Paint)
            pb_area.Invalidate();
        }

        // Occurs every time pb_area is painted
        private void pb_area_Paint(object sender, PaintEventArgs e)
        {
            // Get the relevant graphics to draw to
            Graphics g = e.Graphics;

            // Display all 3 objects
            _lamp.Display(g);
            _signalBox.Display(g);
            _trafficLight.Display(g);
        }
    }
}
