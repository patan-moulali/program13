using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 7, 220, 11, 15, 100, 121 };
            Console.WriteLine("number greater then 100: ");
            foreach (int i in arr)
            {
                if (i > 100)
                {

                    Console.WriteLine(i);
                    Console.Read();
                }
            }
        }
    }
}
