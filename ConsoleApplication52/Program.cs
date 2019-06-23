using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication28
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] num = Console.ReadLine().Split(' ');
            for (int i = 0; i < a; i++)
            {
                int j = int.Parse(num[i]);

            }
            int[] d = new int[a];
            for (int i = 0; i < a; i++)
            {
                d[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    int m = int.Parse(num[i]);
                    int p = int.Parse(num[j]);
                    if (p < m)
                    {
                        if (d[i] > 1 + d[j])
                        {
                            d[i] = d[i];
                        }
                        else
                        {
                            d[i] = 1 + d[j];
                        }
                    }
                }
            }
            int ans = d[0];
            for (int i = 0; i < a; i++)
            {
                if (ans > d[i])
                {
                    ans = ans;
                }
                else
                {
                    ans = d[i];
                }
            }
            Console.WriteLine(ans);
        }
    }
}

