using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
                if(Students.Count < 5)
            {
                throw new InvalidOperationException();
            }

                double max = 0.0;
            double normalized = 0.0;
                foreach (var student in Students)
                   {
                max += student.AverageGrade;
                   }
            normalized = 100 / max * averageGrade;
            if (normalized >= 90)
                return 'A';
            else if (normalized >= 80)
                return 'B';
            else if (normalized >= 70)
                return 'C';
            else if (normalized >= 60)
                return 'D';
            else
                return 'F';
        }

    }
}
