namespace IMDBList
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movies = new List<Movie>();  // create a new list for movies

            // adding films to the list
            while (true)
            {
                Console.Write("Film ismini giriniz: "); // get movie name
                string name = Console.ReadLine();

                Console.Write("IMDb puanını giriniz: "); // get movie imdb score
                double imdbScore;

                // ask until get the IMDb score successfully
                while (!double.TryParse(Console.ReadLine(), out imdbScore))
                {
                    Console.Write("Geçerli bir IMDb puanı giriniz: ");
                }

                // adding the movie and its IMDb rating to the list
                movies.Add(new Movie { Name = name, Score = imdbScore });

                string answer;

                while (true)
                {
                    Console.WriteLine("Yeni bir film eklemek istiyor musunuz?"); 
                    answer = Console.ReadLine().ToLower();

                    if (answer == "evet") // if user wants to add new movies
                    {
                        break;
                    }
                    else if (answer == "hayir") // if user does not want to add new movies
                    {
                        ListFilm(movies); // list movies
                        ShowByScoreRange(movies, 4.0, 9.0); // list movies with imdb score between 4 and 9
                        ShowByFirstLetter(movies, "A"); // list the movie names starting with "A"
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Lutfen 'evet' veya 'hayir' giriniz!"); // if user do not enter 'evet' or 'hayir'
                    }
                }

            }

        }

        static void ListFilm(List<Movie> movies)  // movie list method
        {
            Console.WriteLine("Film Listesi:");
            foreach (var movie in movies)
            {
                Console.WriteLine($"Film: {movie.Name}, IMDB Puani: {movie.Score}");
            }
        }

        // method that lists movies by score within a specified range
        static void ShowByScoreRange(List<Movie> movies, double firstScore, double secondScore)
        {
            Console.WriteLine($"IMDB Puan araligi {firstScore}-{secondScore} olan filmler:");
            foreach (var movie in movies)
            {
                if (firstScore <= movie.Score && movie.Score <= secondScore)
                {
                    Console.WriteLine($"Film: {movie.Name}, IMDB Puani: {movie.Score}");
                }
            }
        }

        // method that lists movies starting with the specified letter
        static void ShowByFirstLetter(List<Movie> movies, string letter)
        {
            Console.WriteLine($"Film ismi {letter} ile başlayanlar:");
            foreach (var movie in movies)
            {
                if (movie.Name.ToLower().StartsWith(letter, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Film: {movie.Name}, IMDB Puani: {movie.Score}");
                }
            }
        }

    }
}
