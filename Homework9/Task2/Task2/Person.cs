
namespace Task2
{
    public class Person
    {
     
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Genre FavoriteMusicType { get; set; }
        public List<Song> FavoriteSongs { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public Person(string firstName, string lastName, int age, Genre favoritMusic)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteMusicType = favoritMusic;
            FavoriteSongs = new List<Song>();
        }

        public List<Song> GetFavSongs()
        {
            return FavoriteSongs;
        }
    }
}
