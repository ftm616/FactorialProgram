using System;

namespace FactorialProgram
{
    
    class Program
    {
        static int fact (int n)
        {
        int s;
        if(n ==1)
            return 1;
            s=n* fact(n-1);
            return s;
    }

    static void Main(string[] args)
        {
        int a = int.Parse(Console.ReadLine());
        int factoril = fact (a);
            Console.WriteLine(factoril);
            Console.ReadKey();
        }
    }
}
