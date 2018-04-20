using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
       
   
       static void Main(string[] args)
        {
           long sum = 0;
           string S = Console.ReadLine(); //１行目
           long s = long.Parse(S);
           string N = Console.ReadLine(); //２行目
            string[] t = N.Split(' ');
           for (int i = 0; i < s; i++)
            {
               sum += long.Parse(t[i]);
            }
           Console.WriteLine(sum);
        }
    }
   
}
