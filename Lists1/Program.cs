namespace Lists1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int i = 1;
            while (true)
            {
                Console.Write("Bir davetli ismi giriniz (bitirmek icin 'exit' yaziniz):");
                string name = Console.ReadLine();

                if (name.ToLower() == "exit")
                {
                    break;
                }

                if (!string.IsNullOrEmpty(name))
                {
                    guests.Add(name);
                }

            }
            Console.WriteLine("\n** Davetliler **");
            foreach (string guest in guests)
            {
                Console.WriteLine(i + "-" + guest);
                i++;
            }
        }
    }
}
