using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioohjelmointi
{
    public class Bookshelf  
    {
        public string Title { get; set; } 
        public string Genre { get; set; }
    }
    
    public class Book : Bookshelf
    {
        public string Author { get; set; }
        private static int bookinstances = 0;
        
        public Book() {}
        public Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
            bookinstances++;
        }
        public static int GetActiveInstances()
        {
            return bookinstances;
        }

        public override string ToString() { return $"Book title is: {Title}, Author is: {Author}, Genre is: {Genre}";}

    }
    public class Movie : Bookshelf
    {
        public string Director { get; set; }
        public int Year { get; set; }
        private static int movieinstances = 0;
        public Movie() {}

        public Movie(string title, string director, string genre, int year)
        {
            Title = title;
            Director = director;
            Genre = genre;
            Year = year;
            movieinstances++;
        }

        public static int GetActiveInstances()
        {
            return movieinstances;
        }

        public override string ToString() { return $"Movie title is: {Title}, Director is: {Director}, Genre is: {Genre} and year is {Year}";}

    }
    public class Artwork : Bookshelf
    {
        public string Artist { get; set; }
        public string Medium { get; set; }
        private static int artinstances = 0;
        
        public Artwork() {}

        public Artwork(string title, string artist, string medium)
        {
            Title = title;
            Artist = artist;
            Medium = medium;
            artinstances++;
        }

        public static int GetActiveInstances()
        {
            return artinstances;
        }

        public override string ToString() { return $"Artwork title is: {Title}, Artist is: {Artist}, Medium is: {Medium}";}

    }

    internal class T18
    {
        public static void Test()
        {
            List<Bookshelf> myBookshelf = new List<Bookshelf>();
            
            myBookshelf.Add(new Book("Harry Potter and the pholosophers stone", "J. K. Rowling", "Fantasy"));
            myBookshelf.Add(new Book("Carrie", "Stephen King", "Horror"));
            myBookshelf.Add(new Movie("Titanic", "James Cameron", "Romance/Drama", 1997));
            myBookshelf.Add(new Artwork("Starry Night", "Vincent Van Gogh", "Oil"));
            
            Console.WriteLine("Bookshelf contains:");
            Console.WriteLine($"{Book.GetActiveInstances()} Books");
            Console.WriteLine($"{Movie.GetActiveInstances()} Movies");
            Console.WriteLine($"{Artwork.GetActiveInstances()} Artworks");

            Console.WriteLine("All titles:");
            foreach (var item in myBookshelf)
            {
                Console.WriteLine($"{item.Title}");
            }        
        }
        static void Task18()
        {
            Test();
        }
    }
}