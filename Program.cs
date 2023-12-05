using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();//create a new book object, at this point

            //Creation of first book, you can now create thousands of different books eg for a library app!
            book1.title = "harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord of rings";
            book2.author = "Tolkein";
            book2.pages = 900;

            Console.WriteLine(book1.pages);
            Console.WriteLine(book2.title);

            Console.ReadLine();

        }
    }
}
