using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] intStrs = { "0123456789", "9876543210", "9999999999999" };
            int k = 50000;
            int s = 5;
            int l = 5;
            List<int> list = new List<int>();
            for(int i = 0; i < intStrs.Length; i++)
            {
                string part = intStrs[i].Substring(s, l);

                int num = int.Parse(part);

                if (num > k)
                {
                    list.Add(num);
                }
            }
            int[] answer = list.ToArray();
            foreach (int value in answer)
            {
                Console.WriteLine(value);
            }
        }
    }
}
