using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgave
{
    internal class Plane : ITransport
    {
        public string Registration { get ; set ;}
        public int Effect { get; set ; }

        public int WingSpan { get; set ; }
        public int Load { get; set ; }
        public int Weight { get; set ; }
        public string Type { get; set ; }

        public Plane(string registration, int effect, int wingSpan, int load, int weight, string type)
        {
            Registration = registration;
            Effect = effect;
            WingSpan = wingSpan;
            Load = load;
            Weight = weight;
            Type = type;
        }

        public void Go()
        {
            Console.WriteLine();
            Console.WriteLine($"The plane with callsing: {Registration} is spooling up.");
            Thread.Sleep(1000);
            Console.WriteLine($"It is fully loaded with {Load} tons of paint.");
            Thread.Sleep(800);
            Console.WriteLine($"The {Type} flies away.");
        }

        public void Show()
        {
            Console.WriteLine();
            Console.Write($"Registration:  {Registration}    ");
            Console.Write($"Effect:  {Effect} kw    ");
            Console.Write($"Wing span:  {WingSpan}m    ");
            Console.Write($"Max load:  {Load}    ");
            Console.Write($"Weight:  {Weight}    ");
            Console.Write($"Type:  {Type}    ");
            Console.WriteLine();
        }
    }
}