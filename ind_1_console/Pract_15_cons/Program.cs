using System;
using System.Collections.Generic;

namespace Pract_15_cons
{
    class Program
    {

        static bool IsReverse(string s1, string s2)
        {
            if (s1.Length != s2.Length) return false;


            var stack = new Stack<char>();
            foreach(char c in s1)
            {
                stack.Push(c);
            }

            foreach(char c in s2)
            {
                if(stack.Count==0|| c!=stack.Pop())
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Заполните s1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Заполните s2");
            string s2 = Console.ReadLine();
            bool result = IsReverse(s1, s2);
            Console.WriteLine(result);
        }
    }
}
