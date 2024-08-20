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
            string myString = "banana";
            string pat = "ana";
            int answer = 0;
            for (int i = 0; i <= myString.Length - pat.Length; i++)
            {
                bool match = true;
                for(int j = 0; j < pat.Length; j++)
                {
                    if (myString[i+j] != pat[j])
                    {
                        match = false;
                        break;
                    }
                }
                if(match)
                {
                    answer++;
                }
            }
            Console.WriteLine(answer);

            //int[] num_list = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //int n = 2;//행
            //int cols = num_list.Length / n;
            //int rows = n;
            //int[,] answer = new int[rows, cols];

            //for(int i = 0; i < num_list.Length; i++)
            //{
            //    int r = i / cols; //행
            //    int c = i % cols; //열
            //    answer[r, c] = num_list[i];
            //}

            //int rRows = answer.GetLength(0);
            //int cCols = answer.GetLength(1);

            //for(int r = 0; r < rRows; r++)
            //{
            //    for (int c = 0; c < cols; c++)
            //    {
            //        Console.WriteLine(answer[r, c] + " ");
            //    }
            //    Console.WriteLine();
            //}



            // int[] arr = { 0, 1, 2, 3, 4 };
            // int[,] queries = { { 0, 1 }, 
            //                    { 1, 2 }, 
            //                    { 2, 3 } };
            // List<int> list = new List<int>();
            ////for (int i = 0; i < arr.Length; i++)
            //// {
            ////     for (int j = 0; j < queries.GetLength(0); j++) 
            ////     {
            ////         list.Add(arr[i] + queries[j, j + 1]);
            ////     }
            //// }
            //for(int i = 0; i < arr.Length; i++)
            // {
            //     int value = arr[i];
            //     for (int j = 0; j < queries.GetLength(0); j++)
            //     {
            //         int start = queries[j, 0];
            //         int end = queries[j, 1];
            //         if (i >= start && i <= end)
            //         {
            //             value += 1;
            //         }


            //         //for(int j = 0; j < arr.Length; j++)
            //         //{
            //         //    list.Add(arr[j]);
            //         //}
            //     }
            //     list.Add(value);
            // }

            // int[] answer = list.ToArray();
            // foreach (int val in answer)
            // {
            //     Console.WriteLine(val);
            // }


            //string[] intStrs = { "0123456789", "9876543210", "9999999999999" };
            //int k = 50000;
            //int s = 5;
            //int l = 5;
            //List<int> list = new List<int>();
            //for(int i = 0; i < intStrs.Length; i++)
            //{
            //    string part = intStrs[i].Substring(s, l);

            //    int num = int.Parse(part);

            //    if (num > k)
            //    {
            //        list.Add(num);
            //    }
            //}
            //int[] answer = list.ToArray();
            //foreach (int value in answer)
            //{
            //    Console.WriteLine(value);
            //}
        }
    }
}
