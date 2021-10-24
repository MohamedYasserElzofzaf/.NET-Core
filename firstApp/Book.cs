using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp
{
    class Book
    {
        public string title;
        public string author;
        private int pages;

        public Book(string aTitle , string aAuthor , int aPages)
        {
            title = aTitle;
            author = aAuthor;
            Pages = aPages;
        }
        public int Pages
        {
            get { return pages; }
            set {
                    if(value > 5)
                {
                    pages = value;
                }
                else
                {
                    pages = 10;
                }
                }
        }
    }
}
