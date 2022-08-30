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
        }

        // Property for Battery
        public int Battery
        {
            get { return battery; }
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

        public void Choice()
        {
            int choice;

            if (battery < 100)
            {
                Console.WriteLine("Do you want to recharge 1 for yes, 2 for no");
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Recharge();
                }
                else
                {
                    Drive();
                }
            }
            else 
            {
                Drive();
            }
        }

    }
}
