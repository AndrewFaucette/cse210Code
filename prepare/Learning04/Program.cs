using System;

class Program
{
    static void Main(string[] args)
    {
        //MathAssignment mathAssignment = new MathAssignment("Samuel Bennet", "Multiplication", "Section 7.3", "Problems 8-19");
        //Console.WriteLine(mathAssignment.getHomework());
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European history", "The causes of World War II");
        Console.WriteLine(writingAssignment.getWritingInformation());
    }
}