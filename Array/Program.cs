namespace Array
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];  // define array to hold 10 integers

            for (int i = 0; i < 10; i++) // fill array elements
            {
                Console.Write($"Lütfen {i + 1}. sayiyi giriniz:");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nDizideki elemanlar:");
            foreach (int number in numbers)  // print array elements
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("Lütfen dizinin sonuna eklenecek sayiyi giriniz:");
            int newNumber = int.Parse(Console.ReadLine());
             
            var numbersList = numbers.ToList(); // convert array to list
            numbersList.Add(newNumber); // add a new number

            Console.WriteLine($"Dizinin büyükten küçüğe siralanmis hali:");
            numbersList.Sort(); // sort elements
            numbersList.Reverse(); // reverse elements

            foreach (int number in numbersList)
            {
                Console.WriteLine(number); // print new version of array
            }
        }
    }
}
