using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            int max = 0;
            int min = 0;
            int avg;
            int[] a = new int[5];
            for (i = 0; i < 5; i++)
            {
                a[i] = i;
                Console.WriteLine("a[{0}]={1}", i, a[i]);
            }
            sum = a[0] + a[1] + a[2] + a[3] + a[4];
            avg = sum / 5;
            Console.WriteLine("avg={0}", avg);
            max = a[0] > a[1] ? a[0] : a[1];
            max = max > a[2] ? max : a[2];
            max = max > a[3] ? max : a[3];
            max = max > a[4] ? max : a[4];
            Console.WriteLine("max={0}", max);
            min = a[0] < a[1] ? a[0] : a[1];
            min = min < a[2] ? min : a[2];
            min = min < a[3] ? min : a[3];
            min = min < a[4] ? min : a[4];
            Console.WriteLine("min={0}", min);
            Console.WriteLine("sum={0}", sum);
            Console.ReadLine();
        }
    }
}
