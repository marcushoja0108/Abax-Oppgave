using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgave
{
    internal class Boat : ITransport
    {
        public string Registration { get; set; }
        public int Effect { get; set; }
        public int MaxSpeed { get; set; }
        public int Load { get; set; }

        public Boat(string registration, int effect, int maxSpeed, int load)
        {
            Registration = registration;
            Effect = effect;
            MaxSpeed = maxSpeed;
            Load = load;
        }

        public void Show()
        {
            Console.WriteLine();
            Console.Write($"Registration:  {Registration}    ");
            Console.Write($"Effect:  {Effect} kw    ");
            Console.Write($"Max speed:  {MaxSpeed}nots    ");
            Console.Write($"Max load:  {Load}    ");
            Console.WriteLine();
        }

        public void Go()
        {
            Console.WriteLine();
            Console.WriteLine($"The boat with callsign {Registration} is starting its engines.");
            Thread.Sleep(1000);
            Console.WriteLine($"Fully loaded with {Load} tons of paint it is driving away at {MaxSpeed} nots.");
        }
    }
}
