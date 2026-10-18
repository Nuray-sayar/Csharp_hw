Console.Write("Enter a number(1-10): ");
int num=int.Parse(Console.ReadLine());

if(num<=1 || num >= 10)
{
    for (int i=1; i<10; i++)
    {
       Console.WriteLine($"{num}*{i}={num*i}"); 
    } 
}
else
{
    Console.WriteLine("number must be between 1 and 10");
}

