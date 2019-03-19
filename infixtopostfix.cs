using System;

namespace InfixToPostfix
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] postfix = new char[100];
            char[] stack = new char[100];
            int j = 0, k = 0, l = 0, prio = 0;
            char [] infix = {'(','A','+','(','(','B','+','C',')','+','(','D','+','E',')','*','F',')','/','G',')',')'};
            Console.WriteLine("Your Infix Notation Is:");
            for(int i = 0; i < infix.Length; i++)
            {
                if (infix[i] == '*' || infix[i] == '/')
                {
                    prio = 1;
                }
                else
                {
                    prio = 0;
                }
                Console.Write(infix[i]);
            }
           
            for(j=0;j<infix.Length;j++)
            {
                if (infix[j] =='(')
                {
                    stack[l] = infix[j];
                   // j++;
                    l++;
                }
               else if ((infix[j] >= 'a' && infix[j] <= 'z') || (infix[j] >= 'A' && infix[j] <= 'Z'))
                {
                    postfix[k] = infix[j];
                    //j++;
                    k++;
                }
                else if(infix[j]=='*' || infix[j]=='/' || infix[j]=='+' || infix[j]=='-')
                {
                    
                     if (prio==1)
                     {
                        
                        if(stack[l] == '+' || stack[l] == '-')
                        {
                           // postfix[k] = stack[l];
                           // l--;
                            //k++;
                            stack[l] = infix[j];
                            l++;
                           // j++;
                        }
                        else
                        {
                            postfix[k] = stack[l];
                            l--;
                            k++;
                            stack[l] = infix[j];
                            l++;
                           // j++;
                        }
                     }
                    else
                    {
                        if (stack[l] == '+' || stack[l] == '-')
                        {
                            postfix[k] = stack[l];
                            l--;
                            k++;
                            stack[l] = infix[j];
                            l++; 

                        }
                        else
                        {
                            postfix[k] = stack[l];
                            l--;
                            k++;
                            stack[l] = infix[j];
                            l++;
                        }

                    }
                }
                else
                {
                    while(stack[l]!='(')
                    {

                    }
                    l--;
                }
               

            }
            Console.WriteLine("your posfix =: ");
            for(int m=0;m<=postfix.Length;m++)
            {
                Console.Write(postfix[m]);
            }
            Console.WriteLine("your posfix =: ");
            Console.ReadLine();
        }
        
    }
}
