using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string : ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string : ");
            string str2 = Console.ReadLine();
            CompareStrings(str1, str2);
        }

        private static void CompareStrings(string str1, string str2)
        {
            bool flag = Equals(str1, str2);
            if (flag)
            {
                Console.WriteLine("Both strings are equal");
            }
            else
            {
                Console.WriteLine("Both strings are not equal");
            }
        }
    }
}
