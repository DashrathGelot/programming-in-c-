using System;
using System.Collections.Generic;

namespace ItoP
{
    class Program
    {
        Stack<char> s = new Stack<char>();
        int Getpriority(char ch)
        {
            
            if(s.Peek()=='*'||s.Peek()=='/')
            {
                return 1;
            }
            else
            { 
              return 0;
            }
        }
        void con(string infix,string postfix)
        {
            int prio = 0;
            postfix = "";
            for(int i=0;i<infix.Length;i++)
            {
                char ch = infix[i];
                if(ch=='*'||ch=='/'||ch=='+'||ch=='-')
                {
                   
                    if(s.Count<=0)
                    {
                        s.Push(ch);
                    }
                    else
                    {
                        prio = Getpriority(ch);
                        if(prio==1)
                        {
                            if(ch=='+'||ch=='-')
                            {
                                postfix += s.Pop();
                                i--;
                            }
                            else
                            {
                                postfix += s.Pop();
                                i--;
                            }
                        }
                        else
                        {
                            if (ch == '+' || ch == '-')
                            {
                                postfix += s.Pop();
                                i--;
                            }
                            else
                            {
                               s.Push(ch);
                            }
                        }
                    }


                }
                else
                {
                    postfix += ch;
                }
            }
            int l = s.Count;
            for(int j=0;j<l;j++)
            {
                postfix += s.Pop();
            }
            Console.WriteLine("postfix = \t" + postfix);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            string infix = "";
            string postfix = "";
            Console.WriteLine("Enter Infix = ");
            infix = Console.ReadLine();
            Console.WriteLine("infix =\t" + infix);
            p.con(infix, postfix);
            
            
            Console.ReadLine();
        }
    }
}
