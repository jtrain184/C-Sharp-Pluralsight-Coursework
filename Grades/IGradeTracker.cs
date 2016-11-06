using System.Collections;
using System.IO;

namespace Grades
{
	interface IGradeTracker : IEnumerable
	{
		void AddGrade(float Grade);
		GradeStatistics ComputeStatistics();
		void WriteGrades(TextWriter destination);
		string Name { get; set; }

	}
}