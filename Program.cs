
//Compute employee wage for multiple company in procedural way using class method.
using System;

namespace UC8
{
     class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public static int computeEmpeage(String company,int emprateperhour,int numOfWorkingDays,int maxHourPerMonth)
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int totalWorkingdays = 0;
            while (totalemphrs <= maxHourPerMonth && totalWorkingdays <= numOfWorkingDays)
            {
                totalWorkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case IS_PART_TIME:
                        emphrs = 4;
                        break;

                    case IS_FULL_TIME:
                        emphrs = 8;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                totalemphrs += emphrs;
                Console.WriteLine("Day#   " + totalWorkingdays + "emp hrs : " + emphrs);
            }
            int totalempwage = totalemphrs * emprateperhour;
            Console.WriteLine("Total employee wage for company :- "+company+" is:- " + totalempwage);
            return totalempwage;
        }
        static void Main(string[] args)
        {
            computeEmpeage("Dmart", 20, 2, 10);
            computeEmpeage("Reliance", 10, 4, 20);
        }
    }
}
