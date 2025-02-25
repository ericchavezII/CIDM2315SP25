
namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 3;
            int Num2 = 5;
            

            
            int Num3 = 7;
            int Num4 = 9;

            int Max1 = largestNum(Num1, Num2);
            int Max2 = largestNum(Num3, Num4);

            int GetLargestTwo = largestNum(Num1 , Num2);
            Console.WriteLine("the largest out of these two are " + GetLargestTwo);

            int GetLargestFour = largestNum(Max1 , Max2);

            Console.WriteLine("The largest number out of these four is " + GetLargestFour );

            createAccount();


           
        }

        static int largestNum(int a, int b)
        {
            return (a > b) ? a : b;
            
        }
        
        static void createAccount(){
            Console.Write("enter username : ");
            string udername = Console.ReadLine();

             Console.Write("enter Password : ");
            string passWord1 = Console.ReadLine();

             Console.Write("re-enter Password : ");
            string passWord2 = Console.ReadLine();

             Console.Write("enter birthyear  : ");
            string birthyear = Console.ReadLine();

            if  (passWord1 == passWord2)
            {
                
                Console.WriteLine("account is created successfully ");
            }
            else if (passWord1 != passWord2)
            {
                Console.WriteLine("Wrong password");
            }
            else
            {
                Console.WriteLine("Account could not be created ");
            }
        }

    }
}