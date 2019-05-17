using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cp = double.Parse(Console.ReadLine());
            var ci = int.Parse(Console.ReadLine());
            var sum = 0;
            var sum1 = 0;
            var bonus = 10;
            var vs = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += bonus;
                    sum -= 1;
                    bonus += 10;
                }
                else
                { sum1 +=ci; }
            }

                vs = sum + sum1 ;
                {
                    if (cp <= vs)
                    { Console.WriteLine("Yes!{0:f2}",Math.Abs(vs - cp)); }
                    else { Console.WriteLine("No!{0:f2}", Math.Abs(cp - vs)); }
                }
            }
        }
    }


       
