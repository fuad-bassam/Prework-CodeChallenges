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

        public static void PerfectArray(int[] arr  ) {

            int sum = 0, mul = 1;

         
            foreach (int num in arr)
            {
           
                sum += num;
                mul *= num;  
              
                Console.WriteLine("sum = " +sum);
                Console.WriteLine("mul = " +mul);
                Console.WriteLine("number = "  +num);
                Console.WriteLine("//////////////////////");


            }
            Console.WriteLine("is perfect ??");
            if (sum == mul)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }

        static void Main(string[] args)
        {
            /*
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

            //////////////////////////////////////////////////////

            */

            Console.WriteLine(" ");
            Console.WriteLine("==========================");
            Console.WriteLine("Problem 3: Perfect Sequence");

            Console.WriteLine("Enter the size of array");

            int[] arr = new int[Convert.ToInt32(Console.ReadLine())] ;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Enter the number");

                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
           /* 
              int count=0;
             string flag = "y";
            while (flag == "y" || flag == "Y")
            {
                Console.WriteLine("Enter the number");
          
                arr[count]= Convert.ToInt32(Console.ReadLine());

                count++;

                Console.WriteLine("if you wont to add more press y else press any key");
                flag = Console.ReadLine();
            }

            */
            PerfectArray(arr);




        }
    }
}
