using System.Globalization;
Console.Write("Enter the value: ");
double C=double.Parse(Console.ReadLine());
double K=C+273.15;
double F=C*9/5+32;
Console.WriteLine($"Kelvin: {K:F2}");
Console.WriteLine($"Fahrenheit: {F:F2}");
