using System;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! this is pattern program");
            for(int i=0;i<=5;i++ )
            {
                Console.WriteLine("");
                for(int j=0;j<=5;j++)
                {
                    Console.Write("*");
                }
            }
            Console.ReadLine();
        }
        
    }
}
