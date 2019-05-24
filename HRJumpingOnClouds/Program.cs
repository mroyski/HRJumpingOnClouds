//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] c = new int[] { 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0,
                1, 0, 1, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 1, 0,
                0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1,
                0, 0, 0, 1, 0, 0, 1, 0, 1, 0, };
            int n = c.Length - 1;
            int safe = 0;
            int danger = 1;
            int jumps = 1;

            for (int i = 1; i <= n; i++)
            {
                if (c[i] == safe)
                {
                    if (i < n - 1)
                    {
                        if (c[i + 1] == safe && c[i + 2] == safe)
                        {
                            i++;
                            jumps++;
                        }
                        else if (c[i + 1] == safe)
                        {
                            jumps++;
                        }
                        else if (c[i - 1] == danger && c[i + 1] == danger)
                        {
                            jumps++;
                        }
                        else if (c[i + 1] == danger)
                        {
                            jumps++;
                        }
                    }
                    else if (i < n)
                    {
                        if (c[i + 1] == safe)
                        {
                            jumps++;
                        }
                        else if (c[i - 1] == danger && c[i + 1] == danger)
                        {
                            jumps++;
                        }
                        else if (c[i + 1] == danger)
                        {
                            jumps++;
                        }
                    }
                }
            }
            Console.WriteLine(c.Length);
            Console.WriteLine(jumps);
        }
    }
}