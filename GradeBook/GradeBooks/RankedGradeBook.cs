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

                 double[] noten = new double[Students.Count];
            int index = 0;
            foreach (var Student in Students)
                {
                noten[index] = Student.AverageGrade;
                index++;
                   }
            noten.sort
            if (normalized >= 80)
                return 'A';
            else if (normalized >= 60)
                return 'B';
            else if (normalized >= 40)
                return 'C';
            else if (normalized >= 20)
                return 'D';
            else
                return 'F';
        }

    }
}
