double[] week = [14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4];

double avg = Average(week);
Console.WriteLine($"Average: {avg:F1}");

int hottest = 0;
for (int i = 1; i < week.Length; i++)
{
    if (week[i] > week[hottest])
        hottest = i;
}
Console.WriteLine($"Hottest day: {hottest + 1}. day, {week[hottest]} degrees");

Console.WriteLine("Days hotter than average:");
for (int i = 0; i < week.Length; i++)
{
    if (week[i] > avg)
        Console.WriteLine($"  Day {i + 1}: {week[i]}");
}

double[] lastThree = week[^3..];
Console.WriteLine("Last three days: " + string.Join(", ", lastThree));

static double Average(double[] t)
{
    double sum = 0;
    foreach (double x in t)
        sum += x;
    return sum / t.Length;
}