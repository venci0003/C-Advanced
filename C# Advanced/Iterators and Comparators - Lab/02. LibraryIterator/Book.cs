using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02._LibraryIterator
{
    public  class Book
    {
        public Book(string title, int year,params string[]authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
    }
}
