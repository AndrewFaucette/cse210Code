using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0){
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            numbers.Add(number);
        }
        int sum = 0;
        foreach (int num in numbers){
            sum += num;
        }
        int big = 0;
        foreach (int num in numbers){
            if (num > big){
                big = num;
            }
        }
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {sum/(numbers.Count-1)}");
        Console.WriteLine($"The largest number is {big}");
    }
}