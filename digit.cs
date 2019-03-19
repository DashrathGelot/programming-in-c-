using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("number = "+num);
            int[] n = new int[100];
            string[] word = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            
            int i = 0;
            do
            {
                n[i] = num % 10;
                num = num / 10;
                i++;
            } while (num>0);
            Console.WriteLine("your number in word is  ");
            for(int j=i-1;j>=0;j--)
            {
                Console.Write(" "+word[n[j]]);
            }
            Console.ReadLine();
        }
    }
}
