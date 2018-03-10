using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        public static void Main(string[] args)
        {
            var a = new Author("John", 50, "Russia");
            var p = new Publisher("publisher 1", "Russia");
            var b = new Book(a, "Siri", 123, 123, p, "");

        }
    }

    class Author
    {
        public string Name
        {
            get;
            set;
        }
        public int Age
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public Author(string nameOfAuthor, int age, string country)
        {
            this.Name = nameOfAuthor;
            this.Age = age;
            this.Country = country;
        }

    }

    class Publisher
    {
        public string NameOfPublisher
        {
            get;
            set;
        }
        public string CountryOfPublisher
        {
            get;
            set;
        }
        public Publisher(string nameOfPublisher, string countryOfPublisher)
        {
            this.NameOfPublisher = nameOfPublisher;
            this.CountryOfPublisher = countryOfPublisher;
        }
    }

    class Book
    {
        
        public string Name
        {
            get; set;
        }
        public int Year
        {
            get;
            set;
        }
        public int PageCount
        {
            get;
            set;
        }
       
        public Publisher Publisher { get; set; }
        public Author Author { get; set; }


        public string Genre { get; set; }

        public Book(Author author, string name, int year, int pageCount, Publisher publisher, string genre)
        {
            this.Author = author;

            this.Name = name;
            this.Year = year;
            this.PageCount = pageCount;
            this.Publisher = publisher;
            this.Genre = genre;
        }


    }
}
