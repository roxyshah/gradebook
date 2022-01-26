using System;
using System.Collections.Generic;

namespace GradeBook 
{
    public class Book 
    {
        //constructor has to have the same name as the class
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            //loop through 
            foreach(var grade in grades) 
            {
                //option 1 to give me back the max value
                // if(number > highGrade) {
                //     highGrade = number;
                // }

                //option 2 to give me back the max value
                result.Low = Math.Min(grade, result.Low);
                result.High = Math.Max(grade, result.High);
                result.Average += grade;
            }
            //getting the average of the numbers in the graders array
            result.Average /= grades.Count;

            return result;
        }
        private List<double> grades;
        public string name;

    } 
}
