using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("David's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(75);
            book.AddGrade(100);

            var stats = book.GetStatistics();

            Console.WriteLine($"Your highest score is: {stats.High:N1}");
            Console.WriteLine($"Your lowest score is: {stats.Low:N1}");
            Console.WriteLine($"Your average score is: {stats.Average:N1}");
            Console.WriteLine($"Your letter grade is: {stats.Letter}");
        }
    }
}
