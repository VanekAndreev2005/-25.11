using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        
        static void SortAscending(int[] intArray)
        {
            int a;
            for (int b = 0; b < intArray.Length; b++)
            {
                a = b;
                for (int c = b; c < intArray.Length; c++)
                {
                    if (intArray[c] < intArray[a])
                    {
                        a = c;
                    }
                }
                if (intArray[a] == intArray[b])
                continue;
                int temp = intArray[b];
                intArray[b] = intArray[a];
                intArray[a] = temp;
            }
        }
        
        static void SortDescending(int[] intArray)
        {
            int a;
            for (int b = 0; b < intArray.Length; b++)
            {
                a = b;
                for (int c = b; c < intArray.Length; c++)
                {
                    if (intArray[c] > intArray[a])
                    {
                        a = c;
                    }
                }
                if (intArray[a] == intArray[b])
                continue;
                int temp = intArray[b];
                intArray[b] = intArray[a];
                intArray[a] = temp;
            }
        }
           
        static int[] ConcatArrays(int[] a, int[] b)
        {
            int[] c = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
            c[i] = a[i];
            for (int i = a.Length; i < a.Length + b.Length; i++)
            c[i] = b[i - a.Length];
            return c;
        }
        
        static void Main(string[] args)
        {
            int[] e = new int[5] { 2, 4, 6, 2, 4 };
            int[] f = new int[5] { 8, 2, 3, -2, 3 };
            SortAscending(e);
            SortDescending(f);
            int[] c = ConcatArrays(e, f);
            foreach (int i in c)
            Console.WriteLine($"{i} ");
            Console.ReadLine();
        } 
    }
}
