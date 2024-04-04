
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static int Max(int[] arr)
        {
            int m = arr[0];

            for (int i = 1; i < arr.Length ;i++ ) 
            {
                if (arr[i] > m)
                    m = arr[i];
            }

            return m;
        }


        static int Min(int[] nums) 
        {
            int m = nums[0];

            foreach (int n in nums)
            {
                if (n < m)
                {
                    m = n;
                }
                   
            }

            return m;
        }

        static string OddOrEven1(int n)
        {
            string s = "";
            if (n % 2 == 0)
                s = "짝수";
            else
                s = "홀수";

            return s;
        }

        static string OddOrEven2(int n)
        {
            if (n % 2 == 0)
                return  "짝수";
            else
                return  "홀수";
        }

        static string OddOrEven3(int n)
        {
            if (n % 2 == 0)
                return "짝수";
            
            return "홀수";
        }

        static string OddOrEven4(int n)
        {
            // 3항 연산자
            //  참/거짓  ?  참값   :  거짓값

            //string r = n % 2 == 0 ? "짝수" : "홀수";
            //string r = (n % 2 == 0) ? "짝수" : "홀수";
            //return r;
            return (n % 2 == 0) ? "짝수" : "홀수";
        }


        static void Main(string[] args)
        {
            int[] a = { 1, 12, 33, 24, 52, 67, 81, 5 };
            Console.WriteLine(Max(a));
            Console.WriteLine(Min(a));
            Console.WriteLine(OddOrEven4(11));
        }
    }
}
