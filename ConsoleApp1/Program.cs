using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program c1 = new Program();
            c1.sce();
        }

        public void sce()
        {
            Console.WriteLine("Enter your Department");
            string Department = (Console.ReadLine());

            if (Department.ToUpper() == "IT" || Department.ToUpper() == "CSC")
            {
                Console.WriteLine("Enter your Percentage");
                int Percentage = Convert.ToInt32(Console.ReadLine());

                if (Percentage >= 60)
                {
                    Console.WriteLine("Enter your age");
                    int Age = Convert.ToInt32(Console.ReadLine());
                    if (Age < 50)
                    {
                        Console.WriteLine("You are eligible for this post");
                    }
                    else
                        Console.WriteLine("Your age is not suitable for the requirement");
                }
                else
                    Console.WriteLine("Your Percentage is not suitable for the requirement");
            }
            else
                Console.WriteLine("Your qualification is not suitable for the requirement");
        }

    }
}
