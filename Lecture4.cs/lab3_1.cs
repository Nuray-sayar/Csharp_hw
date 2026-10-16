
while(true)
{
    Console.WriteLine("Enter a grade: ");
    int grade=int.Parse(Console.ReadLine());

    if(grade<0 || grade > 100)
    {
        Console.WriteLine($"Score is: {grade} -> Invalid score");
        break;
    }
    
   if (grade > 90)
    {
        Console.WriteLine($"Score is: {grade} -> A");
    }
else if(grade > 80)
    {
        Console.WriteLine($"Score is: {grade} -> B");
    }
else if(grade > 70)
    {
        Console.WriteLine($"Score is: {grade} -> C");
    }
else if(grade > 60)
    {
        Console.WriteLine($"Score is: {grade} -> D");
    }
    else
    {
        Console.WriteLine($"Score is: {grade} -> F");
    }

}

