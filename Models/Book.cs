using System;
using System.Text.Json;

namespace Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public string Language { get; set; }

        public Book(string title, string author, int pages, string language)
        {
            Title = title;
            Author = author;
            Pages = pages;
            Language = language;
        }

        public Book()
        {
        }

        public void PrintBook()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"Title:{Title} Author:{Author} Pages:{Pages} Language:{Language}";
        }

        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
