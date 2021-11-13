using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human();
            h.setId(123);
            h.setName("Mohamed Yasser");
            h.show_data();
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
