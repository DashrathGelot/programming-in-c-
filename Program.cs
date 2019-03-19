using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;

namespace Convert
{
    class Program
    {
        static void Main(string[] args)
        {
        loop:
            {
                Console.WriteLine("Hello Friend Enter Your Choice");
                Console.WriteLine("1-Convert Binary TO Decimal ");
                Console.WriteLine("2-Convert Decimal TO Hexadecimal");
                Console.WriteLine("3-Convert Decimal TO Binary");
                Console.WriteLine("4-Convert Decimal TO Octal");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Your Binary Number");
                            int B = int.Parse(Console.ReadLine());
                            double count = 0, sum = 0;
                            while (B != 0)
                            {
                                int c = B % 10;
                                sum = c * Math.Pow(2, count) + sum;
                                B = B / 10;
                                count++;
                            }
                            Console.WriteLine("Decimal:" + sum);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Your Decimal Number ");
                            int d = int.Parse(Console.ReadLine());
                            char[] hex = new char[100];
                            int i = 0;
                            while (d != 0)
                            {
                                int temp = d % 16;
                                if (temp < 10)
                                {
                                    hex[i] = (char)(temp + 48);
                                    i++;
                                }
                                else
                                {
                                    hex[i] = (char)(temp + 55);
                                    i++;
                                }
                                d = d / 16;

                            }
                            Console.WriteLine("hexadecimal:");
                            for (int j = i - 1; j >= 0; j--)
                            {
                                Console.Write(hex[j]);
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("enter your decimal number");
                            int d1 = int.Parse(Console.ReadLine());
                            int[] bin = new int[100];
                            int i = 0;
                            while (d1 != 0)
                            {

                                bin[i] = d1 % 2;
                                i++;
                                d1 = d1 / 2;
                            }
                            Console.WriteLine("Binary number= ");
                            for (int j = i - 1; j >= 0; j--)
                            {
                                Console.Write(bin[j]);
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter Your Decimal Number");
                            int d2 = int.Parse(Console.ReadLine());
                            int[] oct = new int[100];
                            int i = 0;
                            while (d2 != 0)
                            {
                                oct[i] = d2 % 8;
                                i++;
                                d2 = d2 / 8;
                            }
                            Console.WriteLine("your octal number :-:");
                            for (int j = i - 1; j >= 0; j--)
                            {
                                Console.Write(oct[j]);
                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("enter right choice");
                            break;
                        }
                }
                goto loop;
                Console.ReadLine();
            }
        }
    }
}
