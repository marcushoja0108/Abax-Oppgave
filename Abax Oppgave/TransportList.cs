using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Abax_Oppgave
{
    internal class TransportList
    {
        public List<Car> Cars = new List<Car>();
        public List<Plane> Planes = new List<Plane>();
        public List<Boat> Boats = new List<Boat>();

        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Main menu");
            Console.WriteLine("1. Show transport");
            Console.WriteLine("2. Compare");
            Console.WriteLine("3. Go");
            Console.WriteLine("4. Add transport");
            switch (Console.ReadLine())
            {
                case "1":
                    ShowMenu();
                    break;
                case "2":
                    CompareMenu();
                    break;
                case "3":
                    GoMenu();
                    break;
                case "4":
                    AddMenu();
                    break;
                default:
                    Console.WriteLine("Not a valid command");
                    break;
            }
        }

        private void ShowMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1. Cars");
            Console.WriteLine("2. Planes");
            Console.WriteLine("3. Boats");
            Console.WriteLine("4. Back");

            switch (Console.ReadLine())
            {
                case "1":
                    ShowCars();
                    break;
                case "2":
                    ShowPlanes();
                    break;
                case "3":
                    ShowBoat();
                    break;
                case "4":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Not a valid command");
                    break;
            }
        }
        public void CompareMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Write the registration number of the transports you want to compare");
            Console.Write("Transport 1: ");
            string reg1 = Console.ReadLine();
            Console.Write("Transport 2: ");
            string reg2 = Console.ReadLine();

            Compare(FindTransportByReg(reg1), FindTransportByReg(reg2));
        }


        private void GoMenu()
        {
            Console.WriteLine();
            Console.WriteLine("What vehicle do you want to go?");
            Console.WriteLine();
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Plane");
            Console.WriteLine("3. Boat");
            Console.WriteLine("4. Back");

            switch (Console.ReadLine())
            {
                case "1":
                    GoCars();
                    break;
                case "2":
                    GoPlanes();
                    break;
                case "3":
                    GoBoats();
                    break;
                case "4":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Not a valid command");
                    GoMenu();
                    break;
            }
        }

        private void AddMenu()
        {
            Console.WriteLine();
            Console.WriteLine("What kind of vehicle do you want to add?");
            Console.WriteLine();
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Plane");
            Console.WriteLine("3. Boat");

            switch (Console.ReadLine())
            {
                case "1":
                    AddCar();
                    break;
            }
        }

        public void Compare(ITransport transport1, ITransport transport2)
        {
            if (transport1 == transport2)
            {
                Console.WriteLine("These transports are the same.");
                transport1.Show();
                transport2.Show();
            }
            else if (transport1 == null || transport2 == null)
            {
                Console.WriteLine("You have typed an invalid reg number.");
            }
            else
            {
                Console.WriteLine("These transports are not the same.");
                transport1.Show();
                transport2.Show();
            }
            Console.WriteLine();
            Console.WriteLine("Do you want to compare again? 1. Yes  2. No");
            switch (Console.ReadLine())
            {
                case "1":
                    CompareMenu();
                    break;
                case "2":
                    MainMenu();
                    break;
                default:
                    Console.WriteLine("Not a valid command");
                    break;
            }
        }

        private void GoCars()
        {
            Console.WriteLine("Type the registration number of the car you want to go");
            Car goCar = FindCarByReg(Console.ReadLine());
            if (goCar != null)
            {
                goCar.Go();
                GoMenu();
            }
            else
            {
                Console.WriteLine("We couldn't find any cars with that registration.");
            }
        }
        private void GoPlanes()
        {
            Console.WriteLine("Type the callsign of the plane you want to go");
            Plane goPlane = FindPlaneByReg(Console.ReadLine());
            if (goPlane != null)
            {
                goPlane.Go();
                GoMenu();
            }
            else
            {
                Console.WriteLine("We couldn't find any planes with that registration.");
            }
        }
        private void GoBoats()
        {
            Console.WriteLine("Type the callsign of the plane you want to go");
            Boat goPlane = FindBoatByReg(Console.ReadLine());
            if (goPlane != null)
            {
                goPlane.Go();
                GoMenu();
            }
            else
            {
                Console.WriteLine("We couldn't find any planes with that registration.");
            }
        }

        public void ShowCars()
        {
            foreach (var car in Cars)
            {
                car.Show();
            }
            ShowMenu();
        }

        public void ShowPlanes()
        {
            foreach (var plane in Planes)
            {
                plane.Show();
            }
            ShowMenu();
        }

        public void ShowBoat()
        {
            foreach (var boat in Boats)
            {
                boat.Show();
            }
            ShowMenu();
        }


        private void AddCar()
        {
            Console.WriteLine();
            Console.Write($"Registration:  ");
            string registration = Console.ReadLine();
            Console.Write($"Effect(kw):  ");
            int effect = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Max Speed(km/h):  ");
            int maxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Color:  ");
            string color = Console.ReadLine();
            Console.Write($"Type:  ");
            string type = Console.ReadLine();

            Cars.Add(new Car(registration, effect, maxSpeed, color, type));
            Thread.Sleep(1000);
            Console.WriteLine("A new car was added!");
            Thread.Sleep(1500);
        }

        private void AddPlane()
        {
            Console.WriteLine();
            Console.Write($"Registration:  ");
            string registration = Console.ReadLine();
            Console.Write($"Effect(kw):  ");
            int effect = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Wing span:  ");
            int wingSpan = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Max load(tons):  ");
            int maxLoad = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Weight(tons):  ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Type:  ");
            string type = Console.ReadLine();

            Planes.Add(new Plane(registration, effect, wingSpan, maxLoad, weight, type));
            Thread.Sleep(1000);
            Console.WriteLine("A new plane was added!");
            Thread.Sleep(1500);
        }

        private void AddBoat()
        {
            Console.WriteLine();
            Console.Write($"Registration:  ");
            string registration = Console.ReadLine();
            Console.Write($"Effect(kw):  ");
            int effect = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Max speed(nots):  ");
            int maxSpeed = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Max load(kg):  ");
            int maxLoad = Convert.ToInt32(Console.ReadLine());

            Boats.Add(new Boat(registration, effect, maxSpeed, maxLoad));
            Thread.Sleep(1000);
            Console.WriteLine("A new boat was added!");
            Thread.Sleep(1500);
        }


        public ITransport FindTransportByReg(string reg)
        {
            foreach (var car in Cars)
            {
                if (car.Registration == reg)
                {
                    return car;
                }
            }

            foreach (var plane in Planes)
            {
                if (plane.Registration == reg)
                {
                    return plane;
                }
            }

            foreach (var boat in Boats)
            {
                if (boat.Registration == reg)
                {
                    return boat;
                }
            }

            return null;
        }

        public Car FindCarByReg(string reg)
        {
            foreach (var car in Cars)
            {
                if (car.Registration == reg)
                {
                    return car;
                }
            }
            return null;
        }
        public Plane FindPlaneByReg(string reg)
        {
            foreach (var plane in Planes)
            {
                if (plane.Registration == reg)
                {
                    return plane;
                }
            }
            return null;
        }
        public Boat FindBoatByReg(string reg)
        {
            foreach (var boat in Boats)
            {
                if (boat.Registration == reg)
                {
                    return boat;
                }
            }
            return null;
        }

    }
}


