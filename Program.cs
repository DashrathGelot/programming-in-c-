using System;

namespace Celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            string c;
            Console.WriteLine("Hello friend enter your choice");
            do
            {
                Console.WriteLine("1-Celsius To Farenheat  2-farenheat to celsius");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("enter celsius");
                            double cel = double.Parse(Console.ReadLine());
                            double f = (cel * 1.8) + 35;
                            Console.WriteLine(cel+" celsius= "+f+" ferenhest");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("enter feranheat");
                            double fe = double.Parse(Console.ReadLine());
                            double ce = (fe-32)*0.56;
                            Console.WriteLine(fe + " ferenheat= " + ce + " celsius");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("enter right choice");
                            break;
                        }
                }
                Console.WriteLine("you want continue (y/n)");
                c = Console.ReadLine();
            } while (c != "n" && c!="N");
            //Console.ReadLine();
        }
    }
}
