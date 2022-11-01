using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace _04._BookComparer
{
    public class Book : IComparable<Book>
    {
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public int CompareTo(Book other)
        {
           int result = this.Year.CompareTo(other.Year);
            if (result == 0)
            {
                result = this.Title.CompareTo(other.Title);
            }
            return result;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
    public class BookComparator : IComparer<Book>
    {
        public int Compare([AllowNull] Book firstBook, [AllowNull] Book secondBook)
        {
            int result = firstBook.Title.CompareTo(secondBook.Title);
            if (result==0)
            {
                result = secondBook.Year.CompareTo(firstBook.Year);
            }
            return result;
        }
    }
}
