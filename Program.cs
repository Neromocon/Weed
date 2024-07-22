using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //정수 리스트 num_list와 정수 n이 주어질 때, n 번째 원소부터
            //마지막 원소까지의 모든 원소를 담은 리스트를 return하도록
            //solution 함수를 완성해주세요.
            int[] num_list = { 2, 1, 6 };
            int n = 3;
            int numSize = num_list.Length - (n-1);
            int[] answer = new int[numSize];

            Array.Copy(num_list, n-1, answer, 0, numSize);

            foreach (int i in answer) 
            {
                Console.WriteLine(i);
            }
 

            //정수 리스트 num_list와 정수 n이 주어질 때, num_list를 n 번째
            //원소 이후의 원소들과 n 번째까지의 원소들로 나눠 n 번째 원소 이후의
            //원소들을 n 번째까지의 원소들 앞에 붙인 리스트를 return하도록
            //solution 함수를 완성해주세요.
            //int[] num_list = { 2, 1, 6 };
            //int n = 1;
            //// n번째 이후의 원소로 된 배열
            //int[] arrAfterN = new int[num_list.Length - n];
            //Array.Copy(num_list, n, arrAfterN, 0, num_list.Length - n);

            //// 0번째 부터 n=1까지의 원소로 된 배열
            //int[] arrBeforN = new int[n];
            //Array.Copy(num_list, 0, arrBeforN, 0, n);

            //// 배열 합치기
            //int[] answer = new int[arrAfterN.Length + arrBeforN.Length];
            //Array.Copy(arrAfterN, 0, answer, 0, arrAfterN.Length);
            //Array.Copy(arrBeforN, 0, answer, arrAfterN.Length, arrBeforN.Length);

            //foreach (int i in answer) 
            //{
            //    Console.WriteLine(i);
            //}
            //정수 리스트 num_list와 정수 n이 주어질 때, num_list의 첫 번째
            //원소부터 n 번째 원소까지의 모든 원소를 담은 리스트를 return하도록
            //solution 함수를 완성해주세요.
            //int[] num_list = { 5, 2, 1, 7, 5 };
            //int n = 3;

            //int startIndex = 0;
            //int endIndex = n-1;

            //int[] answer = new int[endIndex - startIndex + 1];
            //Array.Copy(num_list, startIndex, answer, 0, endIndex - startIndex + 1);

            //foreach(int i in answer)
            //{
            //    Console.WriteLine(i);
            //}    

            //정수 리스트 num_list와 정수 n이 주어질 때,
            //num_list의 첫 번째 원소부터 마지막 원소까지 n개 간격으로
            //저장되어있는 원소들을 차례로 담은 리스트를 return하도록 solution
            //함수를 완성해주세요.
            //int[] num_list = { 4, 2, 6, 1, 7, 6 };
            //int n = 4;
            //int[] answer = new int[] { };
            //List<int> list = new List<int>();
            //for (int i = 0; i < num_list.Length; i += n)
            //{
            //    list.Add(num_list[i]);
            //}
            //answer = list.ToArray();
            //foreach (int i in answer) 
            //{
            //    Console.WriteLine(i);
            //}


            //최대 5명씩 탑승가능한 놀이기구를 타기 위해 줄을 서있는 사람들의
            //이름이 담긴 문자열 리스트 names가 주어질 때, 앞에서 부터 5명씩 묶은
            //그룹의 가장 앞에 서있는 사람들의 이름을 담은 리스트를 return하도록
            //solution 함수를 완성해주세요. 마지막 그룹이 5명이 되지 않더라도 가장
            //앞에 있는 사람의 이름을 포함합니다.
            //string[] names = { "nami", "ahri", "jayce", "garen", "ivern", "vex", "jinx" };
            //string[] answer = new string[] { };
            //List<string> list = new List<string>();
            //int groupSize = 5;
            //for (int i = 0; i < names.Length; i += groupSize)
            //// i += groupSize : groupSize가 5임으로 5씩 넘어가며 변경함.
            //{
            //    list.Add(names[i]);
            //}
            //answer = list.ToArray();
            //foreach (string s in answer) 
            //{
            //    Console.WriteLine(s);
            //}


            //오늘 해야 할 일이 담긴 문자열 배열 todo_list와 각각의 일을
            //지금 마쳤는지를 나타내는 boolean 배열 finished가 매개변수로
            //주어질 때, todo_list에서 아직 마치지 못한 일들을 순서대로 담은
            //문자열 배열을 return 하는 solution 함수를 작성해 주세요.
            //string[] todo_list = { "problemsolving", "practiceguitar", "swim", "studygraph" };
            //bool[] finished = { true, false, true, false };
            //List<string> list = new List<string>();

            //for (int i = 0; i < todo_list.Length; i++)
            //{
            //    if (finished[i] == false)
            //    {
            //        list.Add(todo_list[i]);
            //    }
            //}
            //string[] answer = list.ToArray();
            //foreach (string s in answer) 
            //{
            //    Console.WriteLine(s);
            //}
            //정수 배열 numbers와 정수 n이 매개변수로 주어집니다.
            //numbers의 원소를 앞에서부터 하나씩 더하다가 그 합이 n보다
            //커지는 순간 이때까지 더했던 원소들의 합을 return 하는 solution
            //함수를 작성해 주세요.
            //int[] numbers = { 58, 44, 27, 10, 100 };
            //int n = 139;
            //int answer = 0;

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    answer += numbers[i];
            //    if (answer > n)
            //    {
            //        return answer;
            //    }

            //}
            //Console.WriteLine(answer);

            //정수 배열 arr가 주어집니다. arr의 각 원소에 대해 값이 50보다
            //크거나 같은 짝수라면 2로 나누고, 50보다 작은 홀수라면 2를 곱합니다.
            //그 결과인 정수 배열을 return 하는 solution 함수를 완성해 주세요.
            //int[] arr = { 1, 2, 3, 100, 99, 98 };
            //int[] answer = new int[arr.Length] ;
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    if(arr[i] >= 50 && arr[i] % 2 == 0)
            //    {
            //        answer[i] = (int)arr[i] / 2;
            //    }
            //    else if (arr[i] < 50 && arr[i] % 2 == 1)
            //    {
            //        answer[i] = (int)arr[i] * 2;
            //    }
            //    else
            //    {
            //        answer[i] = (int)arr[i];
            //    }
            //}
            //for (int i = 0; i < answer.Length; i++) 
            //{
            //    Console.Write(answer[i] + ",");
            //}

            //정수가 담긴 리스트 num_list가 주어질 때, 리스트의 길이가 11
            //이상이면 리스트에 있는 모든 원소의 합을 10 이하이면 모든
            //원소의 곱을 return하도록 solution 함수를 완성해주세요.
            //int[] num_list = { 2, 3, 4, 5};
            //int answer;
            //if (num_list.Length >= 11)
            //{
            //    // 리스트 길이가 11 이상일 경우
            //    answer = 0;
            //    for (int i = 0; i < num_list.Length; i++)
            //    {
            //        answer += num_list[i];
            //    }
            //}
            //else
            //{
            //    // 리스트 길이가 10 이하일 경우
            //    answer = 1;
            //    for (int i = 0; i < num_list.Length; i++)
            //    {
            //        answer *= num_list[i];
            //    }
            //}
            //Console.WriteLine(answer);


            //string myString = "aaAA";
            //string pat = "aaaaa";
            //int answer = 0;
            //StringBuilder sb = new StringBuilder();
            //if (myString.ToLower().Contains(pat.ToLower()))
            //    //ToLower로 두 문자열을 소문자로 변환.
            //    // Contains로 변환된 문자열에서 pat가 포함되어 있는지 확인.
            //{ 
            //    answer = 1;
            //}
            //else 
            //{
            //    answer = 0;
            //}
            //Console.WriteLine(answer);

            //string myString = "aBcDeFg";
            //string answer = "";
            //StringBuilder sb = new StringBuilder();
            //foreach (char ch in myString) 
            //{
            //    if (char.IsUpper(ch))
            //        sb.Append(char.ToLower(ch));
            //    else
            //    {
            //        sb.Append(ch);
            //    }
            //}
            //answer = sb.ToString();
            //Console.WriteLine(answer);

            //string[] strArr = { "AAA", "BBB", "CCC", "DDD" };

            //for (int i = 0; i < strArr.Length; i++) 
            //{
            //    if (i % 2 == 0)
            //    {
            //        strArr[i] = strArr[i].ToLower();
            //    }
            //    else 
            //    {
            //        strArr[i] = strArr[i].ToUpper();
            //    }
            //}
            //string[] answer = new string[strArr.Length];
            //Array.Copy(strArr, answer, strArr.Length);
            //foreach (string str in answer) 
            //{
            //    Console.WriteLine(str);
            //}


            //string myString = "aBcDeFgHiJkLmNoP";
            //string answer = "";
            //StringBuilder sb = new StringBuilder();
            //foreach (char ch in myString) 
            //{
            //    if (ch == 'a')
            //    {
            //        sb.Append('A');
            //    }
            //    else if(char.IsUpper(ch) && ch != 'A')
            //    {

            //        //char.IsUpper() 함수는 C#의 System 네임스페이스에
            //        //정의된 char 구조체의 메서드로, 특정 문자가 대문자인지
            //        //여부를 확인하는 데 사용됩니다. 이 메서드는 문자가
            //        //대문자일 경우 true를 반환하고, 그렇지 않으면 false를
            //        //반환합니다.
            //        sb.Append(char.ToLower(ch));
            //    }
            //    else 
            //    {
            //        sb.Append(ch);
            //    }
            //}
            //answer = sb.ToString();
            //Console.WriteLine(answer);

            //string my_string = "programmers";
            //string alp = "p";
            //string answer = "";

            //char alpChar = alp[0];
            //// 문자열을 문자로 바꾸기 위함임. alp[0]은 결국 문자 하나로 이루어진 
            //// 문자열 이기 때문에 0번째 인덱스가 문자 형태가 됨.
            //StringBuilder sb = new StringBuilder();
            //foreach (char ch in my_string) 
            //{
            //    if (ch == alpChar) 
            //    {
            //        sb.Append(char.ToUpper(ch));
            //    }
            //    else
            //    {
            //        sb.Append(ch);
            //    }
            //}
            //answer = sb.ToString();
            //Console.WriteLine(answer);

            //단어가 공백 한 개 이상으로 구분되어 있는 문자열 my_string이
            //매개변수로 주어질 때, my_string에 나온 단어를 앞에서부터 순서대로
            //담은 문자열 배열을 return 하는 solution 함수를 작성해 주세요.
            //string my_string = " i    love  you";
            //string[] answer = new string[] { };

            //answer = my_string.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //StringSplitOptions.RemoveEmptyEntries:
            //빈 문자열을 반환하지 않고, 공백만 있는 부분을 제외한 실제 값을 반환합니다.


            //문자 "A"와 "B"로 이루어진 문자열 myString과 pat가 주어집니다.
            //myString의 "A"를 "B"로, "B"를 "A"로 바꾼 문자열의 연속하는 부분
            //문자열 중 pat이 있으면 1을 아니면 0을 return 하는 solution 함수를
            //완성하세요.
            //string myString = "ABAB";
            //string pat = "ABAB";
            //int answer = 0;
            //string str = "";
            //StringBuilder sb = new StringBuilder(myString);
            //sb.Replace("A", "C");
            //sb.Replace("B", "A");
            //sb.Replace("C", "B");
            //str = sb.ToString();
            //if (str.Contains(pat))
            //{
            //    answer = 1;
            //}
            //else
            //{
            //    answer = 0;
            //}

            //Console.WriteLine(answer);
            //Console.WriteLine(str);

            //string rny_string = "masterpiece";
            //string answer = "";
            //StringBuilder sb = new StringBuilder(rny_string);
            //sb.Replace("m","rn");

            //answer = sb.ToString();

            //Console.WriteLine(answer);


            // 아무 원소도 들어있지 않은 빈 배열 X가 있습니다.
            // 양의 정수 배열 arr가 매개변수로 주어질 때,
            // arr의 앞에서부터 차례대로 원소를 보면서 원소가
            // a라면 X의 맨 뒤에 a를 a번 추가하는 일을 반복한 뒤의 배열 X를
            // return 하는 solution 함수를 작성해 주세요.

            //int[] arr = { 5, 1, 4 };
            //int[] answer = new int[] { };

            //List<int> list = new List<int>();


            //foreach (int array in arr) 
            //{
            //    for(int i = 0; i < array; i++)
            //    {
            //        list.Add(array);
            //    }
            //}
            //answer = list.ToArray();

            //foreach (int array in answer)
            //{
            //    Console.WriteLine(array);
            //}

        }

    }
}
