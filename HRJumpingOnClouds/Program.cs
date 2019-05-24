using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRJumpingOnClouds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[] { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0,
                1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0,
                0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1,
                0, 0, 0, 1, 0, 0, 1, 0, 1, 0, };
            int n = c.Length - 1;
            int safe = 0;
            int danger = 1;
            int jumps = 1;

            for (int i = 1; i < n; i++)
            {
                if (c[i] == safe)
                {
                    if (c[i - 1] == danger)
                    {
                        jumps++;
                        if (i < n - 1)
                        {
                            if (c[i + 1] == safe && c[i + 2] == safe)
                            {
                                jumps++;
                            }
                        }
                    }
                    if (c[i + 1] == danger)
                    {
                        jumps++;
                    }
                }
            }
            Console.WriteLine(jumps);
        }
    }
}
