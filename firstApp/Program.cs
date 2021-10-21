using System;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n2 + n1);
            Console.ReadLine();
        }
    }
}
