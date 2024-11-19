using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndIndexCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "software application is used to access information";
            string substring = "tion";
            int count = 0;
            for (int i = 0; i <= input.Length - substring.Length; i++)
            {
                if (input.Substring(i,substring.Length)== substring)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
