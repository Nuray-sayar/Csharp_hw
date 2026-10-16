Console.Write("Number (0 to stop): ");
int grade=int.Parse(Console.ReadLine());

int total=0;
int count=0;

while(grade!=0)
{
    total = total + grade;
    count = count + 1;

    Console.Write("Number (0 to stop): ");
    grade=int.Parse(Console.ReadLine());
}

if(count!=0)
{
    double average= (double)total/count;
    Console.WriteLine($"Count: {count}");
    Console.WriteLine($"Sum: {total}");
    Console.WriteLine($"average: {average}");
}

else
{
    Console.WriteLine("No grades were entered");
}