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
            int[] clouds = new int[] { 0, 0, 1, 0, 0, 1, 0, };
            int n = clouds.Length - 1;
            int safe = 0;
            int danger = 1;
            int jumps = 0;

            for (int i = 0; i <= n; i++)
            {
                if (clouds[0] == safe && clouds[1] == safe)
                {
                    jumps++;
                }
                if (clouds[i + 1] == danger)
                {
                    jumps++;
                }
            }
            Console.WriteLine(jumps);
        }
    }
}
