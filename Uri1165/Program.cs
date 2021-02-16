using System;

namespace Uri1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, n;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                p = 0;

                int x = int.Parse(Console.ReadLine());




                for (int c = 1; c <= x; c++)
                {
                    if (x % c == 0.0)
                    {
                        p = p + 1;
                       
                    }
                }

                if (p == 2)
                {
                    Console.WriteLine(x + " É primo");
                }
                else
                {
                    Console.WriteLine(x + " Não é primo");
                }

            }
        }
    }
}
