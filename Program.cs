using System;

namespace GradingSystem
{
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("---Grading System---\n");
            var math_CU = 5;
            var gs_CU = 3;
            var net_CU = 5;
            var csharp_CU = 5;
            var hci_CU = 3;

            Console.Write("Enter MATH 101 Score: ");
            int MATH_101_SCORE = Convert.ToInt32(Console.ReadLine());
            var mathGradeUnit = Student.DetermineGradeUnit(MATH_101_SCORE);

            Console.Write("Enter GS 101 Grade: ");
            int GS_101_SCORE = Convert.ToInt32(Console.ReadLine());
            var gsGradeUnit = Student.DetermineGradeUnit(GS_101_SCORE);

            Console.Write("Enter .NET 101 Grade: ");
            int NET_101_SCORE = Convert.ToInt32(Console.ReadLine());
            var netGradeUnit = Student.DetermineGradeUnit(NET_101_SCORE);

            Console.Write("Enter C# 101 Grade: ");
            int CSHARP_101_SCORE = Convert.ToInt32(Console.ReadLine());
            var csharpGradeUnit = Student.DetermineGradeUnit(CSHARP_101_SCORE);

            Console.Write("Enter HCI 101 Grade: ");
            int HCI_101_SCORE = Convert.ToInt32(Console.ReadLine());
            var hciGradeUnit = Student.DetermineGradeUnit(HCI_101_SCORE);

           
            Console.Write($"|----------------|----------------|-------------------|----------------|\n");
            Console.Write($"| COURSE & CODE  |   COURSE UNIT  |       GRADE       |   GRADE-UNIT   |\n");
            Console.Write($"|----------------|----------------|-------------------|----------------|\n");
            Console.Write($"|   MATH 101     |    {math_CU}           |         {Student.DetermineGrade(MATH_101_SCORE)}         |      {mathGradeUnit}         |\n");
            Console.Write($"|     GS 101     |    {gs_CU}           |         {Student.DetermineGrade(GS_101_SCORE)}         |      {gsGradeUnit}         |\n");
            Console.Write($"|   .NET 101     |    {net_CU}           |         {Student.DetermineGrade(NET_101_SCORE)}         |      {netGradeUnit}         |\n");
            Console.Write($"|     C# 101     |    {csharp_CU}           |         {Student.DetermineGrade(CSHARP_101_SCORE)}         |     {csharpGradeUnit}          |\n");
            Console.Write($"|    HCI 101     |    {hci_CU}           |         {Student.DetermineGrade(HCI_101_SCORE)}         |      {hciGradeUnit}         |\n");
            Console.Write($"|----------------|----------------|-------------------|----------------|\n");

            double totalQualityPoint = 
                (math_CU * mathGradeUnit) +(gs_CU * gsGradeUnit) + 
                (net_CU * netGradeUnit) + (csharp_CU * csharpGradeUnit) +
                (hci_CU * hciGradeUnit);

            double totalGradeUnit = mathGradeUnit + gsGradeUnit + netGradeUnit + csharpGradeUnit + hciGradeUnit;
            //double qualityPoint = courseUnit * gradeUnit;
            //double GPA = totalqualityPoint / totalgradeUnit;

            double GPA = totalQualityPoint / totalGradeUnit;

            Console.Write($"Your GPA is {Math.Round(GPA, 2)} to 2 decimal places.");
            Console.ReadLine();
        }
    }
}
