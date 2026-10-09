Console.WriteLine("Enter a 3-digit number: ");
int n = int.Parse(Console.ReadLine());
int hundreds= n/100;
int tens= (n/10)%10;
int ones= n%10;

Console.WriteLine($"Hundreds: {hundreds}");
Console.WriteLine($"Tens: {tens}");
Console.WriteLine($"Ones: {ones}");
