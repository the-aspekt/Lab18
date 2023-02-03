using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            Console.WriteLine(Check(str));
            Console.ReadLine();

        }

        static bool Check(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                { '(',')' },
                { '[',']' },
                {'{','}' },
                { '<','>' },

            };
        foreach (char c in str)
            {
               if (c == '(' || c == '{' || c == '[' || c == '<')
                    stack.Push(sk[c]);
               else if (c == '}' || c == ']' || c == ')' || c == '>')
                {
                    if (stack.Count == 0 || stack.Pop()!=c)
                    {
                        return false;
                    }
                }
            }
            if (stack.Count == 0)
                return true;
            else
                return false;

        }

    }
}
