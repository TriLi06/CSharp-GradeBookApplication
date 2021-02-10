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
            // erste 20% der Studenten bekommen ein A
            int StudentsPerGrade = Students.Count / 5;


                 double[] noten = new double[Students.Count];
            int index = 0;
            foreach (var Student in Students)
                {
                noten[index] = Student.AverageGrade;
                index++;
                   }
            Array.Sort(noten);

            Console.WriteLine(StudentsPerGrade);
            if (averageGrade > noten[StudentsPerGrade])
                return 'A';
            else if (averageGrade == 75)
                return 'B';
            else if (averageGrade > noten[StudentsPerGrade*3])
                return 'C';
            else if (averageGrade > noten[StudentsPerGrade*4])
                return 'D';
            else
                return 'F';
        }

    }
}
