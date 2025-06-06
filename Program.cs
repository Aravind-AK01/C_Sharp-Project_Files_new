using System;
int[,] a = { { 1, 2, 3 }, { 4, 5, 6 } };
Console.WriteLine(a[0, 2]);









/*
string[] cars = new string[4];
string[] cars = new string[4] { "AK", "BK" };
string[] cars = new string[4] { "Volvo", "BMW" };
string[] cars = { "Volvo", "BMW" };*/

/*using System;
int[] a = { 3, 3, 4, 4, 3 };
int total_credits = a[0] + a[1] + a[2] + a[3] + a[4];
double gpa = 0;
for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine($"Subject {i + 1}");
    double grades = Convert.ToDouble(Console.ReadLine());
    gpa += grades * a[i];
}
gpa /= total_credits;
Console.WriteLine($"Final GPA: {gpa}");
*/

/*Console.WriteLine("Enter the Name of the Student: ");
string student_name = Console.ReadLine();
Console.WriteLine("English 101: ");
double Eng_grade = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Algebra 101: ");
double Algebra_grade = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Biology 101: ");
double Biology_grade = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Computer Science 101: ");
double Computer_grade = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Pyschology 101: ");
double Pyschology_grade = Convert.ToDouble(Console.ReadLine());
double total_credits = eng_credit + Algebra_credit + Biology_credit + Computer_credit + Pyschology_credit;
double Gpa = ((eng_credit * Eng_grade) + (Algebra_credit * Algebra_grade) + (Biology_credit * Biology_grade) + (Computer_credit * Computer_grade) + (Pyschology_credit * Pyschology_grade)) / total_credits;
Console.WriteLine($"Final GPA: {Gpa}");*/