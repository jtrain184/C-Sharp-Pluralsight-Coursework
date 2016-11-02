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

		public void AddGrade(float grade)
		{
			grades.Add(grade);
		}

		List<float> grades;  //Field naming convention is lower class
	}
}