using Abax_Oppgave;

TransportList transportList = new TransportList();

 transportList.Cars.Add(new Car("NF123456", 147, 200, "Green", "Light vehicle"));
 transportList.Cars.Add(new Car("NF654321", 150, 195, "Blue", "Light vehicle"));
 transportList.Planes.Add(new Plane("LN1234", 1000, 30, 2, 10, "Jet"));
 transportList.Boats.Add(new Boat("ABC123", 100, 30, 500)); 

while (true)
{
     transportList.MainMenu();
}