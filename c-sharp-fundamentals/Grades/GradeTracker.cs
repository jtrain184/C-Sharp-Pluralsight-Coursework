using System;
using System.Collections;
using System.IO;

namespace Grades
{
	public abstract class GradeTracker : IGradeTracker
	{
		public abstract void AddGrade(float Grade);
		public abstract GradeStatistics ComputeStatistics();
		public abstract void WriteGrades(TextWriter destination);
		public abstract IEnumerator GetEnumerator();

		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (String.IsNullOrEmpty(value))
				{
					throw new ArgumentException("Name cannot be null or empty");
				}

				if (_name != value && NameChanged != null)
				{
					NamedChangedEventArgs args = new NamedChangedEventArgs();
					args.ExistingName = _name;
					args.NewName = value;

					NameChanged(this, args);
				}

				_name = value;

			}
		}

		public event NameChangedDelegate NameChanged;

		protected string _name;

	}
}
