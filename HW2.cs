using System; 
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a Letter  grade:A , B , C , D");
            string point = Console.ReadLine().ToUpper();
           

            if (point == "A")
            {
                Console.WriteLine("GPA : 4");
            }
            else if (point == "B")
            {
                Console.WriteLine("GPA : 3");
            }
            else if (point == "C")
            {
                Console.WriteLine("GPA : 2");
            }
            else if (point == "D")
            {
                Console.WriteLine("GPA : 1");
            }
            else if (point == "F")
            {Console.WriteLine("GPA : 0");
            }
            else
            {
                Console.WriteLine("Wrong letter grade");
            }
              Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the third number:");
            int num3 = Convert.ToInt16(Console.ReadLine());
            // Chat GPT , 2025/2/2 " Help me start my nested statement"
           
            int smallest;

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    smallest = num1;
                }
                else
                {
                    smallest = num3;
                }
            }
            else
            {
                if (num2 < num3)
                {
                    smallest = num2;
                }
                else
                {
                    smallest = num3;
                }
            }

           
            Console.WriteLine("The smallest number is: " + smallest);
        }
    }
}



