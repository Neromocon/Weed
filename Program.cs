using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //머쓱이네 피자가게는 피자를 여섯 조각으로 잘라 줍니다.
            //피자를 나눠먹을 사람의 수 n이 매개변수로 주어질 때, n명이 주문한
            //피자를 남기지 않고 모두 같은 수의 피자 조각을 먹어야 한다면 최소
            //몇 판을 시켜야 하는지를 return 하도록 solution 함수를 완성해보세요.
            int n = 10;
            int pizza = 6;
            int answer = 0;
            //10명이 주문을 해. 피자 조각은 6개고.최소 공배수?

            int x = n;
            int y = pizza;
            // 먼저 최대 공약수를 구하기 위한 변수임

            while(y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }
            // 최대 공약수 계산

            int gdc = x;
            // 최대공약수가 x임
            int num = (n * pizza) / gdc;
            answer = num / pizza;
            Console.WriteLine(answer);

            ////문자열 myString이 주어집니다. "x"를 기준으로 해당 문자열을 잘라내
            ////배열을 만든 후 사전순으로 정렬한 배열을 return 하는 solution 함수를
            ////완성해 주세요.
            ////단, 빈 문자열은 반환할 배열에 넣지 않습니다.
            //string myString = "axbxcxdx";
            //string[] Str = myString.Split('x');
            //List<string> list = new List<string>();
            //foreach (string s in Str) 
            //{
            //    if(s != "")
            //    {
            //        list.Add(s);
            //    }
            //}
            //string[] answer = new string[list.Count];
            //answer = list.ToArray();
            //Array.Sort(answer);
            //foreach (string answerItem in answer) 
            //{
            //    Console.WriteLine(answerItem);
            //}


            //문자열 my_string과 두 정수 m, c가 주어집니다. my_string을 한 줄에
            //m 글자씩 가로로 적었을 때 왼쪽부터 세로로 c번째 열에 적힌 글자들을
            //문자열로 return 하는 solution 함수를 작성해 주세요.
            //string my_string = "ihrhbakrfpndopljhygc";
            //int m = 4;
            //int c = 2;
            //string answer = "";
            //for (int i = 0; i < my_string.Length; i++) 
            //{
            //    if((i % m ) == (c - 1))
            //    {
            //        answer += my_string[i];
            //    }
            //}
            //Console.WriteLine(answer);

            ////2차원 정수 배열 board와 정수 k가 주어집니다.
            ////i + j <= k를 만족하는 모든(i, j)에 대한 board[i][j]의
            ////합을 return 하는 solution 함수를 완성해 주세요.
            //int[,] board = {{0, 1, 2}, {1, 2, 3}, {2, 3, 4}, {3, 4, 5}};
            //int k = 2;
            //int answer = 0;
            //for (int i = 0; i < board.GetLength(0); i++)
            //{
            //    for (int j = 0; j < board.GetLength(1); j++)
            //    {
            //        if((i + j) <= k)
            //        {
            //            answer += board[i,j];
            //        }
            //    }
            //}
            //Console.WriteLine(answer);

            ////약수의 개수가 세 개 이상인 수를 합성수라고 합니다.
            ////자연수 n이 매개변수로 주어질 때 n이하의 합성수의 개수를
            ////return하도록 solution 함수를 완성해주세요.
            //int n = 10;
            //int answer = 0;            

            //for (int i = 1; i <= n; i++) 
            //{
            //    int count = 0;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        if(i % j == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if( count >= 3)
            //    {
            //        answer++;
            //    }
            //}            

            //Console.WriteLine(answer);

            ////우주여행을 하던 머쓱이는 엔진 고장으로 PROGRAMMERS-962 행성에
            ////불시착하게 됐습니다. 입국심사에서 나이를 말해야 하는데,
            ////PROGRAMMERS-962 행성에서는 나이를 알파벳으로 말하고 있습니다.
            ////a는 0, b는 1, c는 2, ..., j는 9입니다. 예를 들어 23살은 cd,
            ////51살은 fb로 표현합니다. 나이 age가 매개변수로 주어질 때
            ////PROGRAMMER-962식 나이를 return하도록 solution 함수를 완성해주세요.
            //int age = 21;
            //string answer = "";
            //string ageStr = age.ToString();
            //// 정수를 문자열로
            //int[] ageArr = new int[ageStr.Length];

            //for (int i = 0; i < ageStr.Length; i++) 
            //{
            //    ageArr[i] = int.Parse(ageStr[i].ToString());
            //}
            //// 정수를 정수 배열로 => ageArr[] = {2,1}

            //char[] ageChar = new char[ageArr.Length];
            //for (int i = 0; i < ageArr.Length;i++)
            //{
            //    ageChar[i] = (char)('a' + ageArr[i]);
            //}
            //// 정수 배열을 문자 배열로 => ageChar = {'2','1'}

            //for (int i = 0; i < ageChar.Length; i++) 
            //{                
            //    answer += ageChar[i];
            //}
            //Console.WriteLine(answer);

            ////정수 배열 arr가 주어집니다. 이때 arr의 원소는 1 또는 0입니다.
            ////정수 idx가 주어졌을 때, idx보다 크면서 배열의 값이 1인 가장 작은
            ////인덱스를 찾아서 반환하는 solution 함수를 완성해 주세요.
            ////단, 만약 그러한 인덱스가 없다면 -1을 반환합니다.
            //int[] arr = { 1, 1, 1, 1, 0 };
            //int idx = 3;
            //int answer = -1;

            //for (int i = idx; i < arr.Length; i++) 
            //{
            //    if(arr[i] == 1)
            //    {
            //        answer = i;
            //        break;
            //    }                
            //}
            //Console.WriteLine(answer);


            ////문자열 my_string이 매개변수로 주어질 때,
            ////my_string 안에 있는 숫자만 골라 오름차순 정렬한 리스트를
            ////return 하도록 solution 함수를 작성해보세요.
            //string my_string = "hi12392";

            //List<int> answer_list = new List<int>();
            //int count = 0;
            //foreach (char ch in my_string) 
            //{
            //    if(ch >= '0' && ch <= '9')
            //    {
            //        int num = ch - '0';
            //        answer_list.Add(num);
            //        count++;
            //    }
            //}
            //int[] answer = new int[count];
            //answer = answer_list.ToArray();
            //Array.Sort(answer);
            //foreach (int i in answer) 
            //{
            //    Console.WriteLine(i);
            //}

            ////정수 n이 매개변수로 주어질 때, 다음과 같은 n × n 크기의 이차원
            ////배열 arr를 return 하는 solution 함수를 작성해 주세요.
            ////arr[i][j](0 ≤ i, j < n)의 값은 i = j라면 1, 아니라면 0입니다.
            //int n = 3;
            //int[,] answer = new int[n,n] ;

            //for (int i = 0; i < n; i++) 
            //{
            //    for (int j = 0; j < n; j++) 
            //    {
            //        if (i == j)
            //        {
            //            answer[i, j] = 1;
            //        }
            //        else
            //        {
            //            answer[i, j] = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++) 
            //    {
            //        Console.WriteLine(answer[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////정수 배열 arr와 2개의 구간이 담긴 배열 intervals가 주어집니다.
            ////intervals는 항상[[a1, b1], [a2, b2]]의 꼴로 주어지며
            ////각 구간은 닫힌 구간입니다.닫힌 구간은 양 끝값과 그 사이의 값을
            ////모두 포함하는 구간을 의미합니다.
            ////이때 배열 arr의 첫 번째 구간에 해당하는 배열과 두 번째 구간에
            ////해당하는 배열을 앞뒤로 붙여 새로운 배열을 만들어 return 하는
            ////solution 함수를 완성해 주세요.
            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[,] intervals = { { 1, 3 }, { 0, 4 } };            

            //int numIntervals = intervals.GetLength(0);
            //// intervals의 구간 수
            //int totalLength = 0;
            //// 결과 배얄의 크기를 결정하기 위해 각 구간의 길이를 더함
            //for (int i = 0; i < numIntervals; i++) 
            //{
            //    int start = intervals[i,0];
            //    int end = intervals[i,1];
            //    totalLength += (end - start + 1);
            //}
            //int[] answer = new int[totalLength];
            //// 결과를 저장할 배열
            //int index = 0;
            //for(int i = 0;i < numIntervals;i++)
            //{
            //    int start = intervals[i, 0];
            //    int end = intervals[i,1];
            //    int length = end - start + 1;

            //    int[] part = new int[length];
            //    // 부분 배열 추출
            //    Array.Copy(arr, start, part, 0, length);

            //    Array.Copy(part, 0, answer, index, length);
            //    index += length;
            //}

            ////문자열 binomial이 매개변수로 주어집니다.
            ////binomial은 "a op b" 형태의 이항식이고 a와 b는 음이
            ////아닌 정수, op는 '+', '-', '*' 중 하나입니다. 주어진 식을 계산한
            ////정수를 return 하는 solution 함수를 작성해 주세요.
            //string binomial = "43 + 12";
            //int answer = 0;           

            //if (binomial.Contains('+'))
            //{
            //    string[] textSplit1 = binomial.Split('+');
            //    answer = int.Parse(textSplit1[0]) + int.Parse(textSplit1[1]);
            //}
            //if (binomial.Contains('-'))
            //{
            //    string[] textSplit2 = binomial.Split('-');
            //    answer = int.Parse(textSplit2[0]) - int.Parse(textSplit2[1]);
            //}
            //if (binomial.Contains('*'))
            //{
            //    string[] textSplit3 = binomial.Split('*');
            //    answer = int.Parse(textSplit3[0]) * int.Parse(textSplit3[1]);
            //}
        }
    }
}
