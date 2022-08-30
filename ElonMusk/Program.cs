using System;

namespace ElonMusk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array with the possible colors of the car, and puts them into a random
            string[] colour = { "Red", "Yellow", "Green" };

            Random random = new Random();

            string color = colour[random.Next(colour.Length)];

            // Making a new instance of the object
            Tesla t = new Tesla(color);

            // Recieving a valuable for t.distance
            Console.WriteLine("How many meters to drive");
            t.Distance = Int32.Parse(Console.ReadLine());

            // Runs the drive method

            t.Drive();

            // Writes out the color of the car, meters driven and % battery left
            Console.WriteLine("The car is {0}", t.Colour);

            Console.WriteLine("You have driven {0} meters", t.Distance);
            Console.WriteLine("You have {0}% battery left",t.Battery);

            // Asks the user if he wants to recharge
            t.Choice();

            Console.WriteLine("You have {0}% battery left", t.Battery);

            // Runs drive though again to show, we have used the recharged battery power
            Console.WriteLine("How many meters to drive");
            t.Distance = Int32.Parse(Console.ReadLine());

            t.Drive();

            

            Console.WriteLine("You have driven {0} meters", t.Distance);
            Console.WriteLine("You have {0}% battery left", t.Battery);

            

            Console.ReadKey();

           

        }
    }
}
