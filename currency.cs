using System;

namespace Currency
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            String C="";
            Console.WriteLine("hello friends enter your choice");
            do
            {
                Console.WriteLine("1-Convert Rupees To Dollar");
                Console.WriteLine("2-Convert Rupees To frank");
                Console.WriteLine("3-Convert Rupees To euro");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Your Rupees Value");
                            double rupees = double.Parse(Console.ReadLine());
                            double dollar = rupees / 70;
                            Console.WriteLine("Dollar = " + dollar);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter Your Rupees Value");
                            double rupees = double.Parse(Console.ReadLine());
                            double frank = rupees / 68.5;
                            Console.WriteLine("franc = " + frank);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter Your Rupees Value");
                            double rupees = double.Parse(Console.ReadLine());
                            double euro = rupees / 77.47;
                            Console.WriteLine("euro = " + euro);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("please Enter Right choice");
                            break;
                        }
                        
                }
                Console.Write("Do You Want To Continue? (Y/N) : ");
                C = Console.ReadLine();
            }
            while (C != "N" && C != "n");
            Console.ReadLine();
        }
       
    }
}
