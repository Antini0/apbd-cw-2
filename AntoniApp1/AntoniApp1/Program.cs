// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("MOD 1");
Console.WriteLine("MOD 2");
Console.WriteLine("MOD 3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var num in numbers)
    {
        sum += num;
    }

    sum = sum / numbers.Length;
    return (double)sum;

}