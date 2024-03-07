
//Calculating wage till number of working days or total working hour per month is reached.

using System;

namespace UC6
{
    internal class Program
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 2;
        public const int MAX_HOUR_IN_MONTH = 10;
        static void Main(string[] args)
        {
            int emphrs = 0;
            int totalemphrs = 0;
            int totalWorkingdays = 0;
            while(totalemphrs<= MAX_HOUR_IN_MONTH && totalWorkingdays <= NUM_OF_WORKING_DAYS)
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
            int totalempwage = totalemphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total employee wage :- " + totalempwage);
        }
    }
}
