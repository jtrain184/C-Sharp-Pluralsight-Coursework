using System;
using System.Collections.Generic;

namespace Grades
{

	class GradeStatistics
	{
		public GradeStatistics()
		{
			HighestGrade = 0;
			LowestGrade = float.MaxValue;
		}

			public float AverageGrade;
			public float HighestGrade;
			public float LowestGrade;
	}
}