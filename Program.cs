namespace HW4;

using System;

class Program
{
    static void Main(string[] args)
    {
        
        int num1 = 3;
        int num2 = 5;
        int largest = GetLargest(num1, num2);
        Console.WriteLine("The largest number is: " + largest);

       
        Console.Write("\nEnter the value of N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Enter the shape (left/right): ");
        string shape = Console.ReadLine().ToLower();

        Console.WriteLine($"\nN = {N}, Shape = {shape}\n");
        PrintTriangle(N, shape);
    }
//(chatgpt , 2/15/25 , help me start a code that determines the number of rows and the shape of the rows using if else statements)
//(chatgpt , 2/15/25 , show me my errors and help me correct them)
//(chatgpt , 2/15/25 , my code is still breaking)
// i will admit i relied heavily on chatgpt for Q2 , i could not understand this at all. 
    
    static int GetLargest(int num1, int num2)
    {
        return (num1 > num2) ? num1 : num2;
    }

       static void PrintTriangle(int N, string shape)
    {
        if (shape == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string('*', i)); 
            }
        }
        else if (shape == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string(' ', N - i) + new string('*', i)); 
            }
        }
        else
        {
            Console.WriteLine("Invalid shape! Please enter 'left' or 'right'.");
        }
    }
}
