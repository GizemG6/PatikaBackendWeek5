namespace Lists1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>(); // create a list
            int i = 1;
            while (true) // add name until break
            {
                Console.Write("Bir davetli ismi giriniz (bitirmek icin 'exit' yaziniz):");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit") // exit
                {
                    break;
                }

                if (!string.IsNullOrEmpty(name))
                {
                    guests.Add(name); // add guests
                }

            }
            Console.WriteLine("\n** Davetliler **");
            foreach (string guest in guests)  // print guests using foreach
            {
                Console.WriteLine(i + "-" + guest); 
                i++;
            }
        }
    }
}
