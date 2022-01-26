﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        //method Main below
        //name of parameter: args
        //type of parameter: string[] -> string array
        //dotnet run -- Roxy
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();
            Console.WriteLine($"The lowerst grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average:N1}");
        }
    }
}
