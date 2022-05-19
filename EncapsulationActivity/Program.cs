// See https://aka.ms/new-console-template for more information

using System;
namespace EncapsulationActivity.Student
{
    class Program
    {
        public static void Main()
        {
            Student mystudent = new("Zara", "C", 3);
            mystudent.StudentGradeDowngrade();
            mystudent.StudentGradeUpgrade();
            mystudent.DisplayStudentGradeReport();
         }
    }

}

