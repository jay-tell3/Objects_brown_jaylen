using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_brown_jaylen
{
    // Makes an internal class named Computer and implements the IBootUp interface
    internal class Computer : IBootUp
    {
        // Property checking whether the computer is powered on or off
        public bool IsOn { get; set; }

        // Property for the brand of the computer
        public string Brand { get; set; }

        // Property for the type of computer 
        public string Type { get; set; }

        // Constructor make a new Computer object with brand, type, and power state
        public Computer(string brand, string type, bool isOn)
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        // Method to toggle the power of the computer
        public void PowerOnOff()
        {
            // Flips true and false
            IsOn = !IsOn;

            // Print a message based on power 
            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up");
            }
            else
            {
                Console.WriteLine("The computer is shutting down");
            }
        }

        // Overrides ToString() method 
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a(n) {Type} computer, it is on: {IsOn}";
        }
    }

}
