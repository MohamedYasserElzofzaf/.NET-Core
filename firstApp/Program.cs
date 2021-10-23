using System;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, plurnoun, celebarty;
            Console.Write("Enter the color : ");
            color = Console.ReadLine();
            Console.Write("Enter the plurnoun : ");
            plurnoun = Console.ReadLine();
            Console.Write("Enter the celebarty : ");
            celebarty = Console.ReadLine();

            Console.Write("Roses are "+color);
            Console.Write(plurnoun + " are blue ");
            Console.Write("I Love " +celebarty);
            End();
            Console.ReadLine();
        }
        static void End()
        {
            Console.WriteLine("you understand!!");
        }
    }
}
