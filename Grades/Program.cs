﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
		{
			GradeBook book = new GradeBook();
			book.NameChanged += OnNameChanged;
			GetBookName(book);

			book.Name = "Phil's Grade book";
			book.Name = "Grade book";
			AddGrades(book);
			SaveGrades(book);

			GradeStatistics stats = book.ComputeStatistics();
			Console.WriteLine(book.Name);
			WriteResult("Average", stats.AverageGrade);
			WriteResult("Highest", (int)stats.HighestGrade);
			WriteResult("Lowest", (int)stats.LowestGrade);
			WriteResult(stats.Description, stats.LetterGrade);
		}

		static void SaveGrades(GradeBook book)
		{
			using (StreamWriter outputFile = File.CreateText("grades.txt"))
			{
				book.WriteGrades(outputFile);
			}
		}

		static void AddGrades(GradeBook book)
		{
			book.AddGrade(91);
			book.AddGrade(89.5f);
			book.AddGrade(75);
		}

		static void GetBookName(GradeBook book)
		{
			try
			{
				Console.WriteLine("Enter a name");
				book.Name = Console.ReadLine();
			}
			catch (ArgumentException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		static void OnNameChanged(object sender, NamedChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

		static void WriteResult(string description, string result)
		{
			Console.WriteLine(description + ": " + result);
		}

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine("{0}: {1:F2}", description, result);
        }
    }
}