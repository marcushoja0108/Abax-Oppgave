using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgave
{
    internal class Car : ITransport
    {
        public string Registration { get; set; }
        public int Effect { get; set; }
        public int MaxSpeed { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }

        public Car(string registration, int effect, int maxSpeed, string color, string type)
        {
            Registration = registration;
            Effect = effect;
            MaxSpeed = maxSpeed;
            Color = color;
            Type = type;

        }

        public void Go()
        {
            Console.WriteLine($"Car with registration: {Registration} i starting");
            Thread.Sleep(1500);
            Console.WriteLine($"Car i driving away at {MaxSpeed}km/h");
            Thread.Sleep(800);
            Console.WriteLine($"The car drove away");
        }

        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write($"Registration:  {Registration}    ");
            Console.Write($"Effect:  {Effect} kw    ");
            Console.Write($"Max Speed:  {MaxSpeed} km/h    ");
            Console.Write($"Color:  {Color}    ");
            Console.Write($"Type:  {Type}    ");
            Console.WriteLine();
        }
    }
}
