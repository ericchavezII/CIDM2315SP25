using System;


class Program
{
    static void Main(string[] args)
    { 
        
        Customer cus1 = new Customer(customerName: "Alice", customerAge: 33, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus2 = new Customer(customerName: "Bob", customerAge: 23, customerCity: "Amarillo", customerCredit: 226);
        Customer cus3 = new Customer(customerName: "Cathy", customerAge: 45, customerCity: "Amarillo", customerCredit: 89.0);
        Customer cus4 = new Customer(customerName: "David", customerAge: 58, customerCity: "Amarillo", customerCredit: 198.5);
        Customer cus5 = new Customer(customerName: "Jack", customerAge: 28, customerCity: "Canyon", customerCredit: 561.6);
        Customer cus6 = new Customer(customerName: "Tom", customerAge: 36, customerCity: "Canyon", customerCredit: 98.4);
        Customer cus7 = new Customer(customerName: "Tony", customerAge: 24, customerCity: "Canyon", customerCredit: 18.5);
        Customer cus8 = new Customer(customerName: "Sam", customerAge: 35, customerCity: "Canyon", customerCredit: 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

      
        TotalCredits(customer_list);

        
        AmarilloAverageAge(customer_list);

        
        CanyonAge(customer_list);
    }

        public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = customer_list.Sum(c => c.CustomerCredit);
        Console.WriteLine($"Total credit of all customers: {totalCredit}");
    }

    
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        var amarilloCustomers = customer_list.Where(c => c.CustomerCity == "Amarillo").ToList();
        if (amarilloCustomers.Count > 0)
        {
            double averageAge = amarilloCustomers.Average(c => c.CustomerAge);
            Console.WriteLine($"Average age of customers in Amarillo: {averageAge:F2}");
        }
        else
        {
            Console.WriteLine("No customers found in Amarillo.");
        }
    }

        public static void CanyonAge(Customer[] customer_list)
    {
        var canyonCustomers = customer_list.Where(c => c.CustomerCity == "Canyon" && c.CustomerAge > 30).ToList();
        if (canyonCustomers.Count > 0)
        {
            Console.WriteLine("Customers in Canyon older than 30:");
            foreach (var customer in canyonCustomers)
            {
                Console.WriteLine(customer.CustomerName);
            }
        }
        else
        {
            Console.WriteLine("No customers in Canyon older than 30.");
        }
    }
}//( chatgpt , march 30, " show me my mistakes and how to fix them?");
//( chatgpt , march 30 , " what mistakes do i still have?)
//(chatgpt , march 31 , " explain why i use get in the customer class")
//( I have relied on chatgpt much on this homework as well , and im sorry for that.)


class Customer
{
    public string CustomerName { get; }
    public int CustomerAge { get; }
    public string CustomerCity { get; }
    public double CustomerCredit { get; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        CustomerName = customerName;
        CustomerAge = customerAge;
        CustomerCity = customerCity;
        CustomerCredit = customerCredit;
    }
}
