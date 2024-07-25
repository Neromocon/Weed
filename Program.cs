using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ////문자열 my_string과 정수 s, e가 매개변수로 주어질 때, my_string에서
            ////인덱스 s부터 인덱스 e까지를 뒤집은 문자열을 return 하는 solution
            ////함수를 작성해 주세요.
            //string my_string = "Progra21Sremm3";
            //int s = 6;
            //int e = 12;
            //int length = e - s + 1;
            //// 삽입할 문자열 == result A
            //// 기본 문자열 == my_string B
            //string answer = "";

            //string RemoveStr = my_string.Remove(s, length);
            //// s번째 인덱스를 기준으로 분할

            //string Str = my_string.Substring(s,length);

            //char[] charArr = Str.ToCharArray();
            //char[] reverse = charArr.Reverse().ToArray();
            //string result = new string(reverse);

            //for (int i = 0; i < s; i++) 
            //{
            //    answer += my_string[i];
            //}

            //answer += result;

            //for (int i = e + 1; i < my_string.Length; i++) 
            //{
            //    answer += my_string[i];
            //}


            //Console.WriteLine(answer);


            ////문자열 my_string과 정수 배열 indices가 주어질 때, my_string에서
            ////indices의 원소에 해당하는 인덱스의 글자를 지우고 이어 붙인 문자열을
            ////return 하는 solution 함수를 작성해 주세요.
            //string my_string = "apporoograpemmemprs";
            //int[] indices = { 1, 16, 6, 15, 0, 10, 11, 3 };
            //Array.Sort(indices);
            //Array.Reverse(indices);
            //char[] charArr = my_string.ToCharArray();
            //foreach (int index in indices) 
            //{ 
            //    if(index >= 0 && index < charArr.Length)
            //    {
            //        charArr[index] = '\0';
            //    }
            //}
            //string answer = new string(charArr).Replace("\0","");

            //Console.WriteLine(answer);


            //string myString = "AbCdEFG";
            //string pat = "dE";
            //string answer = "";
            //int index = myString.LastIndexOf(pat);
            //answer = myString.Substring(0, index) + pat;
            //Console.WriteLine(answer);



            //int[] arr = { 3, 2, 4, 1, 3 };
            //bool[] flag = { true, false, true, false, false };
            //int[] answer = new int[] { };

            //List<int> X = new List<int>();
            //for (int i = 0; i < arr.Length; i++) 
            //{                
            //    if (flag[i] == true)
            //    {
            //        for (int j = 0; j < arr[i] * 2; j++)
            //        {
            //            X.Add(arr[i]);
            //        }
            //    }
            //    else
            //    {
            //        for(int j = 0; j < arr[i]; j++)
            //        {
            //            if(X.Count > 0)
            //            {
            //                X.RemoveAt(X.Count-1);
            //            }
            //        }

            //    }
            //}
            //answer = X.ToArray();
            //foreach (int i in answer) 
            //{
            //    Console.WriteLine(i);
            //}

            //int[] date1 = { 1024, 10, 24 };
            //int[] date2 = { 1024, 10, 24 };
            //int answer = 0;
            //int n = 0;
            //if (date1[0]<date2[0] ||
            //    (date1[0] == date2[0] && date1[1] < date2[1]) ||
            //    (date1[0] == date2[0] && date1[1] == date2[1] && date1[2] < date2[2]))
            //{
            //    answer = 1;
            //}
            //Console.WriteLine(answer);


            ////문자열 my_string이 매개변수로 주어집니다. my_string에서
            ////중복된 문자를 제거하고 하나의 문자만 남긴 문자열을 return하도록
            ////solution 함수를 완성해주세요.
            //string my_string = "people";
            //string answer = "";

            //for (int i = 0; i < my_string.Length; i++) 
            //{
            //    if (!answer.Contains(my_string[i]))
            //    // answer에 현재 문자가 없는 경우
            //    {
            //       answer += my_string[i];
            //        //answer에 문자를 추가. 즉, 이미 존재하는 문자가 있는 경우에는
            //        // answer에 추가하지 않는다.
            //    }

            //}
            //Console.WriteLine(answer);

        }
    }
}
