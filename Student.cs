using System;
using System.Collections.Generic;
using System.Text;

namespace GradingSystem
{
   public class Student
    {
        
        public static string DetermineGrade(int score)
        {
            string grade = "Error";

            if (score >= 70 && score <= 100)
            {
                grade = "A";
            }
            else if (score >= 60 && score <= 69)
            {
                grade = "B";
            }
            else if (score >= 50 && score <= 59)
            {
                grade = "C";
            }
            else if (score >= 45 && score <= 49)
            {
                grade = "D";
            }
            else if (score >= 40 && score <= 44)
            {
                grade = "E";
            }
            else if (score >= 0 && score <= 39)
            {
                grade = "F";
            }
            else
            {
                grade = "Error";
            }
            return grade;
        }

        public static int DetermineGradeUnit(int score)
        {
            int gradeUnit;
            
            if (score >= 70 && score <= 100)
            {
                gradeUnit = 5;
            }
            else if (score >= 60 && score <= 69)
            {
                gradeUnit = 4;
            }
            else if (score >= 50 && score <= 59)
            {
                gradeUnit = 3;
            }
            else if (score >= 45 && score <= 49)
            {
                gradeUnit = 2;
            }
            else if (score >= 40 && score <= 44)
            {
                gradeUnit = 1;
            }
            else if (score >= 0 && score <= 39)
            {
                gradeUnit = 0;
            }
            else
            {
                gradeUnit = 0;
            }
            return gradeUnit;
        }
    }
}
