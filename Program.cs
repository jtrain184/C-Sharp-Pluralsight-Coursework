using System;

namespace Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			GradeBook book = new GradeBook();
			book.AddGrade(91);
			book.AddGrade(89.5f);
		}
	}
}