using System;

namespace scenariostatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int marks = 65;
            if (marks >= 80)
            {
                Console.WriteLine("Student has passed with higher first class");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Student has passed with first class");
            }
            else if (marks >= 40)
            {
                Console.WriteLine("Student has passed with second class");
            }
            else
            {
                Console.WriteLine("Student has failed");
            }
            Console.ReadLine();
        }
    }
    
}
