using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            NewMethod();

            static void NewMethod()
            {
                Console.WriteLine("enter your first  number");
                String num1 = (Console.ReadLine());
                int NUMBERS = Convert.ToInt32(num1);

                Console.WriteLine("enter your secend number");
                String num2 = (Console.ReadLine());
                int NUMBERS2 = Convert.ToInt32(num2);

                Console.WriteLine("enter your youser name");
                String youser = Console.ReadLine();
                Console.WriteLine("Hi" + "youser");
            }
            Console.WriteLine("enter your password");
            String password = (Console.ReadLine());
            Console.WriteLine("that is your" + "password");
        }
    }
}
