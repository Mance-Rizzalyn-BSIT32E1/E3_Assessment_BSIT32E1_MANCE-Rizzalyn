using System;
namespace IterationLoop
{
    class Loop
    {
        static void Main(string[] args)
        {
            int num = 1;
            double sqr;
            for (int j = 1; j <= 10; j++)
            {
                sqr = Math.Sqrt(num);
                Console.WriteLine(num + " " + sqr);
                num = num + 1;
            }
        }
    }
}
