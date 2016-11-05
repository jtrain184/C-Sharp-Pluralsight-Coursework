using System;
using System.Collections.Generic;

namespace Grades
{
	public class GradeBook
	{

		public GradeBook()
		{
            _name = "Empty";
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
		}

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    if(_name != value)
                    {
                        NamedChangedEventArgs args = new NamedChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                    
                    _name = value;
                }
            }
        }
        public event NameChangedDelegate NameChanged;

        private string _name;
		private List<float> grades;  //Field naming convention is lower class
	}
}