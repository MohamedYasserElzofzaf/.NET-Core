using System;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter","JK rolling" , 1);
            Book book2 = new Book("GOT","R.R.Martin",7);
            Console.Write(book1.Pages);
            Console.ReadLine();
        }
    }
}
