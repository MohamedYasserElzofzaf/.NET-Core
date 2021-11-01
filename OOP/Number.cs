using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Number
    {
        private int x1;
        private int x2;
        public void setX1(int value)
        {
            this.x1 = value;
        }
        public int getX1()
        {
            return this.x1;
        }

        public Number(int n1 , int n2)
        {
            this.x1 = n1;
            this.x2 = n2;
        }
        public int sub()
        {
            return Math.Abs(this.x1 - this.x2);
        }
        public void show()
        {
            Console.WriteLine("Show"+this.x1 + " " + this.x2);
        }
    }
}
