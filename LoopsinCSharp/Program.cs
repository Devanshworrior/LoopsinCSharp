using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsinCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. While Loop
            int i = 0;
            while (i < 300)
            {
                Console.WriteLine(i+1);
                i++;
            }

            //2. Do While Loop
            int k = 0;
            do
            {
                Console.WriteLine(k+1);
                k++;
            } while (k > 500);

            //3. For Loop
            ;
            for(int q=0; q<500; q++)
            {
                Console.WriteLine(q+1);
            }

            //Break And Continue
            for (int v = 0; v < 500; v++)
            {
                if (v == 0)
                {
                    continue;
                }
                Console.WriteLine(v + 1);
                //break;
            }

            Console.ReadLine();
        }
    }
}
