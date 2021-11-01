using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Human
    {
        // variables
        private int id;
        private string name;

        // setter && getter
        public void setId(int serial)
        {
            this.id = serial;
        }
        public int getId()
        {
            return this.id;
        }

        public void setName(string full)
        {
            this.name = full;
        }
        public string getName()
        {
            return this.name;
        }
        public void show_data()
        {
            Console.WriteLine("the ID is : " + this.getId() + " && the name is : " + this.getName());
        }
    }
}
