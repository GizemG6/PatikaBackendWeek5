namespace Final
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            while (true)
            {
                Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
                string answer = Console.ReadLine().ToLower(); // using ToLower() to avoid uppercase/lowercase differences

                if (answer == "h")
                {
                    // if the answer is no, the program ends and list of cars is printed
                    Console.WriteLine("\nÜretilen Arabalar:");
                    foreach (var car in cars)
                    {
                        Console.WriteLine($"Seri Numarası: {car.SerialNumber}, Marka: {car.Brand}");
                    }
                    break;
                }
                else if (answer == "e")
                {
                    // car production
                    Car car = new Car();

                    Console.Write("Seri Numarası giriniz: ");
                    car.SerialNumber = int.Parse(Console.ReadLine());

                    Console.Write("Marka giriniz: ");
                    car.Brand = Console.ReadLine();

                    Console.Write("Model giriniz: ");
                    car.Model = Console.ReadLine();

                    Console.Write("Renk giriniz: ");
                    car.Color = Console.ReadLine();

                // warning and re-entry when non-numeric value is entered for door number
                doorCount:
                    Console.Write("Kapı sayısını giriniz: ");
                    try
                    {
                        car.DoorCount = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Geçersiz giriş! Lütfen kapı sayısı için sayısal bir değer giriniz.");
                        goto doorCount; // use goto to ask for the door number again in case of an error
                    }

                    // adding the created car object to the cars list
                    cars.Add(car);

                    if (answer == "h")
                    {
                        // if the answer is no, the program ends and list of cars is printed
                        Console.WriteLine("\nÜretilen Arabalar:");
                        foreach (var item in cars)
                        {
                            Console.WriteLine($"Seri Numarası: {item.SerialNumber}, Marka: {item.Brand}");
                        }
                        break;
                    }
                }
                else
                {
                    // if an invalid answer is given, warn the user and ask them to log in again
                    Console.WriteLine("Geçersiz cevap! Lütfen 'e' veya 'h' giriniz.");
                }
            }
        }
    }
}
