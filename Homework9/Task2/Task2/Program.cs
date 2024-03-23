using System.Collections.Generic;

namespace Task2
{
        public class Program
        {
            static void Main(string[] args)
            {
                List<Person> fansList = new List<Person>();

            
                Person Frosina = new Person("Frosina", "Frosinovska", 78, Genre.Rock);
                Person Stefan = new Person("Stefan", "Stefanoski", 28, Genre.Techno);
                Person Sofija = new Person("Sofija", "Tomik", 43, Genre.Classical);
            

            
                Song song1 = new Song("Bohemian Rhapsody", 367, Genre.Rock);
                Song song2 = new Song("Bounce Back", 226, Genre.Techno);
                Song song3 = new Song("The Four Seasons", 2520, Genre.Classical);
                Song song4 = new Song("Canon in D major", 376, Genre.Classical);
                Song song5 = new Song("Vision", 693, Genre.Techno);
           

                List<Song> songs = new List<Song>() { song1, song2, song3, song4, song5};

                fansList.Add(Frosina);
                fansList.Add(Stefan);
                fansList.Add(Sofija);

                Frosina.FavoriteSongs.Add(song1);
                Stefan.FavoriteSongs.Add(song2);
                Sofija.FavoriteSongs.Add(song3);
                Sofija.FavoriteSongs.Add(song4);
                Stefan.FavoriteSongs.Add(song5);

            foreach (Person fan in fansList)
                {
                    PrintFavoriteSongs(fan);
                }
            }

            public static void PrintFavoriteSongs(Person person)
        {
            if (person.GetFavSongs().Count > 0)
            {
                Console.WriteLine($"{person.FullName} likes these songs:");

                foreach (var song in person.GetFavSongs())
                {
                    Console.WriteLine($"{song.Title} {song.Genre} {song.Length}");
                }
            }
            else
            {
                Console.WriteLine($"Person {person.FullName} don't have any favorite songs");
            }
        }
        
    }
}

