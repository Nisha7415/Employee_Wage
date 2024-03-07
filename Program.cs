
//Add part time employee and wage.


using System;
using System.ComponentModel.Design;

namespace UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            Console.WriteLine("Employeecheck is :- " + empcheck);
            if(empcheck==IS_PART_TIME)
            {
                emphrs = 4;
            }
            else if(empcheck==IS_FULL_TIME)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is :- " + empwage);
        }
    }
}
