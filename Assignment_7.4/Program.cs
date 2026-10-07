namespace Assignment_7._4
{
    internal class Program
    {
        static void Parking()
        {
            ParkingSystem parking1 = new ParkingSystem(1,1,0);

            List<bool> answer = new List<bool>();
            Console.WriteLine(parking1);
            answer.Add(parking1.AddCar(1));

            Console.WriteLine(parking1);
            answer.Add(parking1.AddCar(2));

            Console.WriteLine(parking1);
            answer.Add(parking1.AddCar(3));

            Console.WriteLine(parking1);
            answer.Add(parking1.AddCar(1));

            Console.Write("Results: ");
            foreach (bool result in answer) { Console.Write($"{result} "); }
        }
        static void Main(string[] args)
        {
            Parking();
        }
    }
}
