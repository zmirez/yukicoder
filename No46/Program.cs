using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    
    class Program3
    {
       static void Main(string[] args)
        {
            
           string N = Console.ReadLine();
            string[] t = N.Split(' ');
            long b = long.Parse(t[1]);
            long a = long.Parse(t[0]);
           long sum = 0;
           if (b >= a)
            {
               if (b % a != 0)
                {
                   sum = b / a + 1;
                }
                else
                {
                   sum = b / a;
                }
            }else
            {
               sum = b;
            }
           Console.WriteLine(sum);
        }
    }
}
