using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
	public class GradeBook : GradeTracker
	{

		public GradeBook()
		{
			_name = "Empty";
			grades = new List<float>();
		}

		 public bool ThrowAwayLowest
		{
			get;
			set;
		}

		public override GradeStatistics ComputeStatistics()
		{
			Console.WriteLine("GradeBook::ComputeStatistics");

			GradeStatistics stats = new GradeStatistics();

			float sum = 0;
			foreach (float grade in grades)
			{
				stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
				stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
				sum += grade;
			}
			stats.AverageGrade = sum / grades.Count;  //Zero count causes DIV/0 error
			return stats;
		}

		public override void WriteGrades(TextWriter destination)
		{
			foreach (float grade in grades)
			{
				destination.WriteLine(grade);
			}

		}

		public override void AddGrade(float grade)
		{
			grades.Add(grade);
		}

		public override IEnumerator GetEnumerator()
		{
			return grades.GetEnumerator();
		}

		protected List<float> grades;  //Field naming convention is lower class
	}
}