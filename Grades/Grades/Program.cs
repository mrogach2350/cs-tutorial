using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args) 
        {
            
            SpeechSynthesizer speaker = new SpeechSynthesizer();

            GradeBook book = new GradeBook();

            book.AddGrade(91);
            book.AddGrade(80.5f);
            book.AddGrade(60);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine($"Highest grade = {stats.HighestGrade}");
            Console.WriteLine($"Lowest grade = {stats.LowestGrade}");
            Console.WriteLine($"Average grade = {stats.AverageGrade}");
        }
    }
}
