using System;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter locker number : ");
            int lockerNumber = Convert.ToInt32(Console.ReadLine());
            int val = returnFloor(lockerNumber);
           Console.WriteLine("Floor number is : " + val);
            
        }
        public static int returnFloor(int lockerNumber)
        {
            int floor = 0;
            int[] numberPerfloor = { 5, 6, 7 };
            int lockerIndex = 0;
            int sumLocker = 0;

            do
            {
                sumLocker += numberPerfloor[lockerIndex];
                floor++;
                if (lockerIndex == 2)
                {
                    lockerIndex = 0;
                }
                else
                {
                    lockerIndex++;
                }

            } while (sumLocker < lockerNumber);
            return floor;
        }
    }
}