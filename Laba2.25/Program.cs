using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2._25
{
    class Program
    {
        //Даны натуральное n, целые числа a1, …, an.
        //Все числа последовательности попарно различны.
        //Поменять в этой последовательности местами наименьший и наибольший члены, последний член и первый отрицательный.

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i=0; i<n; i++)          
                a[i] = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int otr = 0;
            int maxi = 0;
            int mini = 0;
            int otri = 0;
            int t = 0;

            for (int i=0; i<n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    maxi = i;
                }
                if (a[i] < min)
                {
                    min = a[i];
                    mini = i;
                }
                if (a[i] < 0 && t==0)
                {
                    t++;
                    otr = a[i];
                    otri = i;
                }
            }
            t = a[mini];
            a[mini] = a[maxi];
            a[maxi] = t;

            t = a[otri];
            a[otri] = a[n - 1];
            a[n - 1] = t;
            Console.WriteLine("----------------");
            for (int i = 0; i < n; i++)
                Console.WriteLine(a[i]);
            Console.ReadKey();
        }
    }
}
