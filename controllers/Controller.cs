

namespace Bookshop.controllers
{
    using System.Diagnostics;
    using BookShop.helper;
    public class BookshopController
    {
        // public static void init application
        public static void initApplication()
        {
            Console.WriteLine("Welcome to the Bookshop");
            Console.WriteLine("=======================");
            Console.WriteLine("1. Add a book");
            Console.WriteLine("2. List all books");
            Console.WriteLine("3 Update a book");
            Console.WriteLine("4 Delete a book");

            string? userChoice = Console.ReadLine();
            bool isValid = Constants.validateOptions(userChoice, 1, 4);
            if (!isValid){
                BookshopController.initApplication();
            }
            else{
                new BookshopController.menuRedirect(userChoice)
            }
        }

        public void menuRedirect(string useRoute)
        {
            switch(useRoute)
            {
                case "1":
                    // route to add a book
                    break;
                case "2":
                    // route to list all books
                    break;
                case "3":
                    // route to update a book
                    break;
                case "4":
                    // route to delete a book
                    break;
                default:
                    // route to init application
                    break;
            }
        }
        
    }
    // public static void init application
}