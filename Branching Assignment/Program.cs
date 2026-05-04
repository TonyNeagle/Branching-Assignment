using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome the user to the Package Express application
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //Prompt the user for the package weight
            Console.WriteLine("What is the weight of your package in kg?");
            // Convert the user input to an integer and store it in a variable
            int weight = Convert.ToInt32(Console.ReadLine());
            //If the weight is greater than 50, display a message that the package cannot be shipped and end the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            // If the weight is less than or equal to 50, prompt the user for the package width, height, and length
            else
            {
                Console.WriteLine("What is the width of your package in cm?");
                int width = Convert.ToInt32(Console.ReadLine()); // Convert the user input to an integer and store it in a variable
                Console.WriteLine("What is the height of your package in cm?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the length of your package in cm?");
                int length = Convert.ToInt32(Console.ReadLine()); // Convert the user input to an integer and store it in a variable

                //If the sum of the width, height, and length is greater than 50, display a message that the package cannot be shipped and end the program
                if (width + height + length > 50)
                {
                    Console.WriteLine("Package too large to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                 
                }
                // Next, multiply the three dimensions (height, width, & length) together, and multiply the product by the weight. Finally, divide the outcome by 100.
                else
                { 
                int total = (width * height * length * weight) / 100; // Display the total cost to ship the package to the user, and end the program
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total);
                Console.ReadLine();
                }
            }
        }
    }

}
