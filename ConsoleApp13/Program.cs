﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1부터 13까지의 수에서, 1은 1, 10, 11, 12, 13 이렇게 총 6번 등장합니다.
            //정수 i, j, k가 매개변수로 주어질 때, i부터 j까지 k가 몇 번 등장하는지
            //return 하도록 solution 함수를 완성해주세요.

            int i = 1;  
            int j = 13;
            int k = 1;
            int answer = 0;
            char k2 = (char)(k + '0');

            int size = j - i + 1;
            int[] array = new int[size];
            for (int index = 0; index < size; index++)
            {
                array[index] = i + index;
            }
            string strArr = String.Join(",", array);
            
            foreach (char c in strArr)
            {
                if(strArr.Contains(k2))
                {
                    answer++;
                }
            }
           
            Console.WriteLine(answer);
            
            //Console.WriteLine(String.Join(", ", StrArray));


            //---------------


            ////정수가 있을 때, 짝수라면 반으로 나누고, 홀수라면 1을 뺀 뒤 반으로 나누면,
            ////마지막엔 1이 됩니다. 예를 들어 10이 있다면 다음과 같은 과정으로 1이 됩니다.

            ////10 / 2 = 5
            ////(5 - 1) / 2 = 2
            ////2 / 2 = 1
            ////위와 같이 3번의 나누기 연산으로 1이 되었습니다.

            ////정수들이 담긴 리스트 num_list가 주어질 때, num_list의 모든 원소를 1로 만들기
            ////위해서 필요한 나누기 연산의 횟수를 return하도록 solution 함수를 완성해주세요.

            //int[] num_list = { 12, 4, 15, 1, 14 };
            //int answer = 0; // 총 연산 횟수

            //foreach(int num in num_list)            
            //{
            //    int count = 0;
            //    int current = num;

            //    while(current > 1)
            //    {
            //        if(current % 2 ==0)
            //        {
            //            //짝수인 경우 2로 나누기
            //            current /= 2;
            //        }
            //        else
            //        {
            //            //홀수인 경우 1을 빼고 2로 나누기
            //            current = (current - 1) / 2;
            //        }
            //        count++;

            //    }
            //    answer += count;
            //}





            //Console.WriteLine(answer);



            //-------------------------

            ////정수 배열 arr이 매개변수로 주어집니다. arr의 길이가 2의 정수 거듭제곱이
            ////되도록 arr 뒤에 정수 0을 추가하려고 합니다. arr에 최소한의 개수로 0을 추가한
            ////배열을 return 하는 solution 함수를 작성해 주세요.

            //int[] arr = { 1, 2, 3, 4, 5, 6 };

            //List<int> list = new List<int>();

            //int PowofTwo = 1;           


            //while(PowofTwo < arr.Length)
            //{
            //    PowofTwo *= 2;
            //}                       

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    list.Add(arr[i]);                
            //}
            //if (arr.Length < PowofTwo)
            //{
            //    for (int j = 0; j < PowofTwo - arr.Length; j++)
            //    {
            //        list.Add(0);
            //    }
            //}

            ////Console.WriteLine(PowofTwo);


            //int[] answer = list.ToArray();


            //foreach (int i in answer)
            //{
            //    Console.WriteLine(i);
            //}
        }
    }
}
