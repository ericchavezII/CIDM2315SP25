using System;

namespace HWweek9
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer alice = new Customer(input_id: 110, input_age: 28, input_name: "Alice");

            //  alice.changeID(220);
            alice.PrintCusInfo();
            alice.changeID(220);
            alice.PrintCusInfo();
            
           

            Customer bob = new Customer(111, 30, "Bob");

            
            bob.PrintCusInfo();
            bob.changeID(221);
            bob.PrintCusInfo();
            
            alice.CompareAge(bob);
        }
    }

    class Customer
    {
        private int cus_id = 0;
        public string cus_name = string.Empty;
        public int cus_age = 0;

        public Customer(int input_id, int input_age, string input_name)
        {
            cus_id = input_id;
            cus_age = input_age;
            cus_name = input_name;
        }

        public void changeID(int new_id)
        {
            cus_id = new_id;
        }

        public void PrintCusInfo()
        {
            Console.WriteLine($"Customer ID: {cus_id}");
            Console.WriteLine($"Customer Age: {cus_age}");
            Console.WriteLine($"Customer Name: {cus_name}");
        }

        public void CompareAge(Customer objCustomer)
        {
            if (this.cus_age > objCustomer.cus_age)
            {
                Console.WriteLine($"{cus_name} is older than {objCustomer.cus_name}");
            }
            else if (this.cus_age < objCustomer.cus_age)
            {
                Console.WriteLine($"{cus_name} is younger than {objCustomer.cus_name}");
            }
            
            }
        }
    }

