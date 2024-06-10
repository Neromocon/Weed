using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06._10
{
    internal class Program
    {
        //public int solution(int num1, int num2)
        //{
        //    int answer = 0;
        //    if (num1 == num2)
        //    {
        //        answer = 1;
        //        return answer;
        //    }

        //    if (num1 != num2)
        //    {
        //        answer = -1;
        //        return  answer;
        //    }


        //    return answer;
        //}

        //public double solution(int[] numbers)
        //{
        //    int[] num = {1,2,3,4,5,6,7,8,9,10};
        //    double answer = 0;
        //    int sum = 0;
        //    foreach (int i in numbers) 
        //    {
        //        sum += num[i];
        //    }
        //    answer = sum / num.Length;
        //    return answer;
        //}

        //public int[] solution(int n)
        //{
        //    int i = 10;
        //    int[] array = new int[i];
        //    foreach (int x in array) 
        //    {
        //        if(x % 2 == 1)
        //        {
        //            array[i] += x;
        //        }
        //    }

        //    int[] answer = new int[] { };
        //    Console.WriteLine(array);
        //    return answer;
        //}



        static void Main(string[] args)
        {
            //int[] numbers = { 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //double answer = 0;
            //double sum = 0;
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    sum += numbers[i];
            //}
            //answer = sum / numbers.Length;
            //Console.WriteLine(answer);

            //int angle = 70;
            //int angle2 = 91;
            //int angle3 = 180;
            //int answer = 0;

            //if(angle <90)
            //{
            //    answer = 1;
            //}
            //else if(angle == 90)
            //{
            //    answer = 2;
            //}
            //else if(angle > 90 || angle <180)
            //{
            //    answer = 3;
            //}
            //else if(angle == 180)
            //{
            //    answer = 4;
            //}
            //Console.WriteLine(answer);

            //int n = 10;
            //int answer = 0;
            //int sum = 0;
            //for (int i = 0; i <= n; i++) 
            //{                
            //    if (i % 2 == 0) 
            //    {
            //        sum += i;
            //    }
            //}
            //answer = sum;
            //Console.WriteLine(answer);

            //int num1 = 3;
            //int num2 = 2;
            //double number = (double)num1 / num2;
            //int answer = (int)(number * 1000);

            //Console.WriteLine(answer);

            //int[] array = { 1, 1, 2, 3, 4, 5 };
            ////int[] array = { 0, 2, 3, 4 };
            //int n = 1;
            //int answer = 0;

            //foreach (int num in array) 
            //{

            //    if (num == n)
            //    {
            //        answer++;

            //    }
            //}

            //Console.WriteLine(answer);

            //int[] array = { 149, 180, 192, 170 };
            //int[] array = { 180, 120, 140 };
            //int height = 190;
            //int max = 0;
            //int answer = 0;
            //foreach (int ki in array)
            //{
            //    if (height < ki)
            //    {                 
            //        answer++;
            //    }
            //}

            //Console.WriteLine(answer);

            //int[] array = { 1, 2, 7, 10, 11 };
            //int[] array = { 9, -1, 0 };
            //int length = array.Length;
            //int answer = 0;
            //Array.Sort(array);
            //if (length % 2 == 1) 
            //{
            //    answer = array[length / 2];
            //}
            //Console.WriteLine(answer);


            //int i = 10;
            //int[] array = new int[i];

            //for (int j = 0; j < array.Length; j++) 
            //{
            //    if (j % 2 == 1)
            //    {
            //        array[j] = j;
            //        Console.Write(j + "");
            //    }
            //}


            //for (int j = 0; j < array.Length; j++)
            //{
            //    if (j % 2 == 1)
            //    {
            //        array[j] = j;
            //        Console.Write(j + "");
            //    }
            //}
            //foreach (int x in array)
            //{
            //    if (x % 2 == 1)
            //    {
            //        int[] answer = new int[array.Length];
            //    }
            //    //Console.Write(x + " ");
            //}

            //int n = 15;
            //double num = 0;
            //int answer = 0;

            //num = (double)n / 7;
            //answer = (int)Math.Ceiling(num);
            //Console.WriteLine(answer);


            //int price = 150000;
            //int price = 580000;
            //double discount = 0;
            //int answer = 0;

            //if (price >= 0 && price < 100000)
            //{
            //    answer = price;
            //}
            //if (price >= 100000 && price < 300000)
            //{
            //    discount = (double)(price / 10) / 2;
            //    answer = price - (int)Math.Ceiling(discount);
            //}
            //else if (price >= 300000 && price < 500000)
            //{
            //    discount = (double)(price / 10);
            //    answer = price - (int)Math.Ceiling(discount);
            //}
            //else if (price >= 500000)
            //{
            //    discount = (double)(price / 10) * 2;
            //    answer = price - (int)Math.Ceiling(discount);
            //}
            //Console.WriteLine(answer);

            //string my_string = "abcdef";
            //string my_string = "BCBdbe";
            //string letter = "f";
            //string letter = "B";

            //string answer = my_string.Replace(letter,"");

            //Console.WriteLine(answer);

            //int money = 15000;
            //int var = money / 5500; // 구매 수
            //int change = money % 5500; // 잔돈

            //int[] answer = new int[2];
            //answer[0] = var;
            //answer[1] = change;

            //foreach (int i in answer) 
            //{
            //    Console.WriteLine(i);
            //}

            //장군 개미 공격력 : 5
            //병정 개미 공격력 : 3
            //일개미 공격력 : 1
            //int hp = 999;

            //int att1 = hp / 5; 
            //int att2 = (hp % 5) / 3;
            //int att3 = (hp - (att1 * 5) - (att2*3)) / 1;
            //int answer = att1 + att2 + att3;
            //Console.WriteLine(answer);


        }
        
      
    }
}
