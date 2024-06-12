using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = 3;
            //int[] numlist = new int[] { 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            //List<int> list = new List<int>();

            //for (int i = 0; i < numlist.Length; i++) 
            //{
            //    if (numlist[i] % n == 0)
            //        list.Add(i);
            //}
            //foreach (int num in numlist)
            //{
            //    if (num % n == 0)
            //        list.Add(num);
            //}

            //int[] answer = list.ToArray();
            //foreach (int i in answer) 
            //{
            //    Console.WriteLine(i);
            //}

            //int answer = 0;
            //int a = 2;
            //int b = 4;
            //if (a % 2 != 0 && b % 2 != 0) 
            //{
            //    answer = (a*a) + (b*b);
            //}
            //else if(a % 2 != 0 || b % 2 != 0)
            //{
            //    answer = 2 * (a + b);
            //}
            //else if(a % 2 == 0 && b % 2 == 0)
            //{
            //    answer = Math.Abs(a - b);
            //}

            //Console.WriteLine(answer);

            //string[] str_list = { "abc", "def", "ghi" };
            //string ex = "ef";
            ////string[] str_list = { "abc", "bbc", "cbc" };
            ////string ex = "c";
            //string answer = "";

            //List<string> list = new List<string>();
            //foreach (string str in str_list) 
            //{
            //    if(!str.Contains(ex))
            //    {
            //        list.Add(str);
            //    }

            //}

            //Console.WriteLine(list.ToArray());

            //int[] num_list = { 1, 2, 3, 4, 5 };
            //int n = 6;
            //int answer = 0;


            //foreach (int i in num_list) 
            //{
            //    if (i == n)
            //    {
            //        answer = 1;
            //        break;
            //    }

            //}
            //Console.WriteLine(answer);

            //string str1 = "abc";
            //string str2 = "aabcc";

            //bool isContained = str2.Contains(str1);

            //Console.WriteLine(isContained ? 1 : 2);

            //string n_str = "854020";
            //string answer = "";

            //bool findZero = false;

            //foreach (char c in n_str) 
            //{
            //    if(c != '0' || findZero)
            //    {
            //        answer += c;
            //        findZero = true;
            //    }

            //}
            //Console.WriteLine(answer);

            //string[] strArr = {"and","notad","abcd" };
            //string[] answer = new string[] { };
            //string str = "ad";

            //List<string> list = new List<string>();
            //foreach (string ex in strArr)
            //{
            //    if (!ex.Contains(str))
            //    {
            //        list.Add(ex);
            //    }

            //}
            //answer = list.ToArray();

            //int[] arr = { 1, 2, 3, 100, 99, 98 };
            //int k = 2;
            //int[] answer = new int[arr.Length];

            //for(int i = 0; i < arr.Length; i++) 
            //{
            //    if (k % 2 != 0)
            //    {
            //        answer[i] += arr[i] * k;
            //    }
            //    else 
            //    {
            //        answer[i] += arr[i] + k;
            //    }
            //}
            //Console.WriteLine("[" + string.Join(", ", answer) + "]");

            //int[] num_list = { 12, 4, 15, 46, 38, 1, 14, 56, 32, 10 };
            //Array.Sort(num_list);

            //int[] answer = num_list.Skip(5).ToArray();
            //Array.Sort(answer);

            int[] arr = { 49, 12, 100, 276, 33 };
            int n = 27;
            int[] answer = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr.Length % 2 != 0)
                {
                    for (int j = 0; j < arr.Length; i = +2, j++)
                    {
                        answer[i] = arr[j] + n;
                    }
                }
                else 
                {
                    for (int j = 1; j < arr.Length; i = +2, j++)
                    {
                        answer[i] = arr[j] + n;
                    }
                }
            }



        }
    }
}
