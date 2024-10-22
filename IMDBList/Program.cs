namespace IMDBList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Film> films = new List<Film>();

            // Adding films to the list
            while (true)
            {
                Console.Write("Film ismini giriniz: ");
                string name = Console.ReadLine();

                Console.Write("IMDb puanını giriniz: ");
                double imdbScore;

                // IMDb puanını başarılı şekilde alana kadar soralım
                while (!double.TryParse(Console.ReadLine(), out imdbScore))
                {
                    Console.Write("Geçerli bir IMDb puanı giriniz: ");
                }

                // Adding the film and its IMDb rating to the list
                films.Add(new Film { Name = name, Score = imdbScore });

                string answer;

                while (true)
                {
                    Console.WriteLine("Yeni bir film eklemek istiyor musunuz?");
                    answer = Console.ReadLine().ToLower();

                    if (answer == "evet")
                    {
                        break;
                    }
                    else if (answer == "hayir")
                    {
                        ListFilm(films);
                        ShowByScoreRange(films, 4.0, 9.0);
                        ShowByFirstLetter(films, "A");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Lutfen 'evet' veya 'hayir' giriniz!");
                    }
                }

            }

        }

        static void ListFilm(List<Film> films)
        {
            Console.WriteLine("Film Listesi:");
            foreach (var film in films)
            {
                Console.WriteLine($"Film: {film.Name}, IMDB Puani: {film.Score}");
            }
        }

        static void ShowByScoreRange(List<Film> films, double firstScore, double secondScore)
        {
            Console.WriteLine($"IMDB Puan araligi {firstScore}-{secondScore} olan filmler:");
            foreach (var film in films)
            {
                if (firstScore <= film.Score && film.Score <= secondScore)
                {
                    Console.WriteLine($"Film: {film.Name}, IMDB Puani: {film.Score}");
                }
            }
        }

        static void ShowByFirstLetter(List<Film> films, string letter)
        {
            Console.WriteLine($"Film ismi {letter} ile başlayanlar:");
            foreach (var film in films)
            {
                if (film.Name.ToLower().StartsWith(letter, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Film: {film.Name}, IMDB Puani: {film.Score}");
                }
            }
        }

    }
}
