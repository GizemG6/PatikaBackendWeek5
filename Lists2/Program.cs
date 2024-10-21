using System.Xml.Linq;

namespace Lists2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> coffees = new List<string>(); // create coffees list
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Kahve {i}:"); // print Kahve 1:  Kahve 2:
                string coffee = Console.ReadLine();

                if (!string.IsNullOrEmpty(coffee)) // string control
                {
                    coffees.Add(coffee); // add items to coffees
                }
            }

            Console.WriteLine("Girilen Kahve Isimleri:");

            foreach (string c in coffees)
            {
                Console.WriteLine(c); // print coffees
            }
        }
    }
}
