Console.Write("Enter grade, -1 to quit: ");
int grade=int.Parse(Console.ReadLine());

double total=0;
int counter=0;
int highest=int.MinValue;
int lowest=int.MaxValue;

while(grade!=-1)
{
    total = total+grade;
    counter=counter+1;
    if (grade > highest)
    {
        highest=grade;
    }
    if(grade<lowest)
    {
        lowest=grade;
    }

    Console.Write("Enter grade, -1 to quit: ");
    grade=int.Parse(Console.ReadLine());
}

if(counter!=0)
{
    double average=total/counter;
    Console.WriteLine($"Count is {counter}");
    Console.WriteLine($"Sum is {total}");
    Console.WriteLine($"average is {average}");
    Console.WriteLine($"Highest grade is {highest}");
    Console.WriteLine($"Lowest grade is {lowest}");
}

else
{
    Console.WriteLine("No grades were entered");
}
