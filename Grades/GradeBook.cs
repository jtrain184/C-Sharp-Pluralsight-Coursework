using System;
using System.Collections.Generic;

namespace Grades
{
	class GradeBook
	{

		public GradeBook()
		{
			grades = new List<float>();
		}

		public GradeStatistics ComputeStatistics()
		{
			Console.Write("ComputeStatistics called.\n");
			GradeStatistics stats = new GradeStatistics();

			float sum = 0;
			foreach(float grade in grades)
			{
				stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
				stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
				sum += grade;
			}
			stats.AverageGrade = sum / grades.Count;  //Zero count causes DIV/0 error
			return stats;
		}

		public void AddGrade(float grade)
		{
			grades.Add(grade);
			Console.Write(grade + " added to gradebook\n");
		}

		List<float> grades;  //Field naming convention is lower class
	}
}