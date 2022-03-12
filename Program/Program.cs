using System;

namespace Program
{
    class Program
    {

        public static int[] CreatArr()
        {

            // int[] arr;
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Number 1 ~ 10");


                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            return arr;

        }

        public static int MaxArr(int[] numArr, int sNum)
        {
            int x = 0;

            foreach (int s in numArr)
            {
                if (s == sNum)
                {
                    x += s;
                }

            }

            return x;

        }

        public static void LeapYearCalculator(int x) {



            if (x % 4 == 0)
            {

                if (x % 400 == 0)
                {
                    Console.WriteLine(x + " is a leap year, because this year is divisible by 400 and by 4");
                }
                else if (x % 100 == 0)
                {
                    Console.WriteLine(x + " is NOT a leap year, because this year is divisible by 100");
                }
                else
                {

                    Console.WriteLine(x + " is a leap year, because this year is divisible by 4");
                }


            }
            else {
                Console.WriteLine(x + " is NOT a leap year, because this year is NOT divisible by 4");
            }
        

        }

        static void Main(string[] args)
        {

           Console.WriteLine("Problem 1: Array Max Result");

            int[] a = CreatArr();
            Console.Write("Enter Number that you wont to search for :- ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MaxArr(a, x));

            /////////////////////////////////////////////////////////
            
            Console.WriteLine(" ");
            Console.WriteLine("==========================");
            Console.WriteLine("Problem 2: Leap Year Calculator");

            
           
            Console.Write("\n Enter the year you wont :- ");
            LeapYearCalculator(Convert.ToInt32(Console.ReadLine()));



        }
    }
}
