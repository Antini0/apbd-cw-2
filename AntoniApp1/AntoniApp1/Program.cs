// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("MOD 1");
Console.WriteLine("MOD 2");
Console.WriteLine("MOD 3");

static double GetAverage(int[] numbers)
{
    int sum = 0;
    foreach (var num2 in numbers)
    {
        sum += num2;
    }

    sum = sum / numbers.Length;
    return (double)sum;

}

int[] nums = {1, 2,3 ,4};
double avg = GetAverage(nums);
Console.WriteLine(avg);
int a = 5;
bool b = false;