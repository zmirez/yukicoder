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
            int count = 0;
            for(int i = 1; i <= 11; i++)
            {
                for(int j = 0; j <= 3; j++)
                {
                    if (j > i) break;
                    for(int m = 0; m <= 9; m++)
                    {
                        if (j == 3 && m >= 2) break;
                        else if (i == 4 && j == 3 && m == 1) break;
                        else if (i == j + m)
                        {
                            count++;
                            Console.WriteLine(i + "/" + j + m);
                            break;
                        }
                       
                        
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
   // class Program2
    //{
      //  static void Main(string[] args)
        //{
          //  long sum = 0;
         //   string S = Console.ReadLine(); //１行目
           // long s = long.Parse(S);
           // string N = Console.ReadLine(); //２行目
            //string[] t = N.Split(' ');
           // for (int i = 0; i < s; i++)
            //{
              //  sum += long.Parse(t[i]);
            //}
           // Console.WriteLine(sum);
        //}
    //}
    //class Program3
    //{
      //  static void Main(string[] args)
        //{
            
          //  string N = Console.ReadLine();
            //string[] t = N.Split(' ');
            //long b = long.Parse(t[1]);
            //long a = long.Parse(t[0]);
         //   long sum = 0;
           // if (b >= a)
            //{
              //  if (b % a != 0)
                //{
                  //  sum = b / a + 1;
                //}
                //else
                //{
                  //  sum = b / a;
                //}
            //}else
            //{
              //  sum = b;
            //}
           // Console.WriteLine(sum);
        //}
    //}
//}
