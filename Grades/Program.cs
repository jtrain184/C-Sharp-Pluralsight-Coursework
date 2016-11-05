using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("******Program now running.******\n");
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", (int)stats.LowestGrade);
            Console.Write("******Program ended******");
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }
    }
}