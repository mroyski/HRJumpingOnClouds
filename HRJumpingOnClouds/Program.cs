﻿using System;
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
            int n = clouds.Length;
            int safe = 0;
            int danger = 1;
            int jumps = 1;

            for (int i = 1; i < n; i++)
            {
                if (clouds[i] == danger)
                {
                    if (clouds[i - 1] == safe)
                    {
                        jumps++;
                    }
                }
            }
            Console.WriteLine(jumps);
        }
    }
}
