using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _24._06._05
{
    internal class Program
    {
        //정수 리스트 num_list가 주어질 때, 마지막 원소가 그전 원소보다 크면 마지막 원소에서 그전
        //원소를 뺀 값을 마지막 원소가 그전 원소보다 크지 않다면 마지막 원소를 두 배한 값을 추가하여
        //return하도록 solution 함수를 완성해주세요.
        // num_list             result
        // [2, 1, 6]       [2, 1, 6, 5]
        // [5, 2, 1, 7, 5] [5, 2, 1, 7, 5, 10]
        /*public int[] solution(int[] num_list)
        {

            int result = 0;
            int[] answer = new int[] {2, 1, 6 };
            List<int> list = answer.ToList();
            int[] answer_list = new int[answer.Length+1];
                        
            
            if (answer[2] > answer[1])
                result = answer[2] - answer[1];

            else
                result = answer[2] * 2;
            
            list.Add(result);

            return list.ToArray();

        }
        */

        /*
         * 문자열 my_string과 이차원 정수 배열 queries가 매개변수로 주어집니다. 
         * queries의 원소는 [s, e] 형태로, my_string의 인덱스 s부터 인덱스 e까지를 
         * 뒤집으라는 의미입니다.
         * my_string에 queries의 명령을 순서대로 처리한 후의 문자열을 return 하는 solution 함수를 작성해 주세요.
         */

        /*
        public string solution(string my_string, int[,] queries)
        {
            string my_string2 = "rermgorpsam";
            int[,] queries2 = new int[4, 2] 
            {
                {2, 3},
                {0, 7},
                {5, 9},
                {6, 10}
            };

            char[] answer = my_string2.ToCharArray();
            // 문자열중 몇 개를 임의로 순서를 바꾸기 때문에 문자 타입으로 변경해준다.
            // ToCharArray()이 해당 문자열 배열을 문자 배열로 바꾸는 메소드.

            for (int i = 0;i <= queries.GetLength(0); i++)           
            // 2차원 배열이기 때문에 GetLength()로 구한다. 
            // queries.GetLength(0)에서 0을 넣은 이유는 이차원 배열의 첫 번째 차원의 길이를 구하기 위함.
            {
                int start = queries[i, 0];
                // 현재 queries의 처음 원소를 구함
                int end = queries[i, 1] - queries[i, 0] + 1;
                // 현재 queries의 끝 원소를 가져와 범위의 길이를 계산.
                Array.Reverse(answer, start, end);
                // Array.Reverse() 메서드를 이용해서 지정된 범위를 뒤집음.
                // ex) Array.Reverse(answer, start, end)
                // answer 배열의 start(시작부분)에서 end(끝부분)까지
            }

            return new string(answer);
        }
        */

        /*
         문자열 배열 intStrs와 정수 k, s, l가 주어집니다. intStrs의 원소는 숫자로 이루어져 있습니다.
        배열 intStrs의 각 원소마다 s번 인덱스에서 시작하는 길이 l짜리 부분 문자열을 잘라내
        정수로 변환합니다. 
        이때 변환한 정수값이 k보다 큰 값들을 담은 배열을 return 하는 solution 함수를 완성해 주세요.
         */

        public int[] solution(string[] intStrs, int k, int s, int l)
        {
            string[] intStrs2 = { "0123456789", "987654321", "9999999999" };
            int x = 50000; // == k
            int y = 5; // == s
            int z = 5; // == l
            char[] charStrs = intStrs2.ToArray();

            for (int i = 0; i < intStrs2.Length; i++)
            {

            }
            //intStrs2[intStrs2[y]]

            int[] answer = new int[] { };
            return answer;
        }

        static void Main(string[] args)
        {
            
        }
    }
}
