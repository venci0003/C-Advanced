using System;

namespace AuthorProblem
{
    [Author("Victor")]
    class StartUp
    {
        [Author("George")]
        static void Main(string[] args)
        {
            var tracker = new Tracker();
            tracker.PrintMethodsByAuthor();
        }
        [Author("Victor")]
        [Author("George")]
        public void Drive()
        {
            Console.WriteLine("Drive...");
        }
    }
}
