using System.Globalization;
Console.WriteLine("Grade1: ");
double g1= double.Parse(Console.ReadLine());
Console.WriteLine("Grade2: ");
double g2= double.Parse(Console.ReadLine());
Console.WriteLine("Grade3: ");
double g3= double.Parse(Console.ReadLine());

double sum=g1+g2+g3;
double avg= sum/3;
bool passed=avg>=60;

Console.WriteLine($"Sum: {sum:F2}");
Console.WriteLine($"Average: {avg:F2}");
Console.WriteLine($"Average >=60: {passed}");
