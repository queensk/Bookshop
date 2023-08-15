using System.Text.Json;

namespace Models
{
    internal class Book
    {
        public string Id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int pages { get; set; }
        public string language { get; set; }

        Book(string id, string title, string author, int pages, string language)
        {
            this.Id=id;
            this.title=title;
            this.author=author;
            this.pages=pages;
            this.language=language;
        }

        // getters and setters
        public void printBook()
        {
            Console.WriteLine(this);
        }
        public override string ToString()
        {
            return $"Book:{Id} Tittle{title} Author:{author} Page:{pages} language:{language}";
        }
        // helper method that covers object to serialized json
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        
    }
}