using System;
using System.Linq.Expressions;

namespace Throw
{
    class Program
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큽니다.");
        }
        static void Main(string[] args)
        {
            try
            {
                for (int i = 1; i < 10; i += 2)
                {
                    DoSomething(i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
