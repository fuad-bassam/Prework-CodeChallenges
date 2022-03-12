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

        public static int MaxArr(int[] numArr ,int sNum)
        {
            int x = 0;

            foreach (int s in numArr)
            {
                if (s== sNum)
                {
                    x +=s;
                }

            }

            return x;

        }



        static void Main(string[] args)
        {

            int[] a = CreatArr();
            Console.Write("Enter Number that you wont to search for :- ");
           int x= Convert.ToInt32(Console.ReadLine());
           
           

            Console.WriteLine( MaxArr(a,x));
        }
    }
}
