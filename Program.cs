
//Check Employee is present or absent.


using System;


namespace employeeWage
{
    public class Program
    {
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empcheck=random.Next(0,2);
            if (empcheck == IS_FULL_TIME) 
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
