using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElonMusk
{
    internal class Tesla
    {
        // private valuables
        private string colour;
        private int battery;
        private int distance;

        // Property for Color
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        // Property for Battery
        public int Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        // Property for Distance
        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        // Constructor recieveing 1 parameter
        public Tesla(string color)
        {
            colour = color;
            battery = 100;
            distance = 0;

        }

        // Drive method
        public void Drive()
        {
            for (int i = 0; i < Distance; i+=20)
            {
                --battery;
            }


        }

        // Recharge method
        public void Recharge()
        {
            battery = 100;
            Distance = 0;
        }

    }
}
