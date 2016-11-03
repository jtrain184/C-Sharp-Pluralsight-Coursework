using System;
using System.Speech.Synthesis;

namespace Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			SpeechSynthesizer synth = new SpeechSynthesizer();
			synth.Speak("Hello! This is the grade book program");

			Console.Write("******Program now running.******\n");
			GradeBook book = new GradeBook();
			book.AddGrade(91);
			book.AddGrade(89.5f);
			book.AddGrade(75);

			GradeStatistics stats = book.ComputeStatistics();
			Console.WriteLine("Average Grade: " + stats.AverageGrade);
			Console.WriteLine("Highest Grade: " + stats.HighestGrade);
			Console.WriteLine("Lowest Grade: " + stats.LowestGrade);
			Console.Write("******Program ended******");
		}
	}
}