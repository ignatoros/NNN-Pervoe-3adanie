using System;

namespace NNN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1000;
            for (int i = 2; i <= N; i++)
            {
                int j;
                for (j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        break;
                    }



                }

                if (j > Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                }
            }

            {

            }
        }
    }
}
