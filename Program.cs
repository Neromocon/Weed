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
        static int InputInt(string s)
        {
            Console.Write(s + ":");

            return int.Parse(Console.ReadLine());
        }

        static int InputInt(string s, int start, int end)    //입력값의 범위를 지정  = 나 이 범위를 제외한 값은 필요 없음!
        {
            string msg = s + "(" + start + "~" + end + ")";

            // 정상 범위
            //(v >= start && v <= end)
            //(start <= v && v<= end)
            // 정상 범위가 아님
            //(v < start) || (v > end)
            //!(v >= start) && (v <= end)
            //!(start <= v && v<= end)

            int v = 0;
            //while (true)
            //{
            //    v = InputInt(msg);
            //    if (v >= start && v <= end)
            //        break;
            //    Console.WriteLine("다시 입력해주세요.");
            //}
            //------------------------- 타입 1
            //bool first = true;
            //do  // 잘못된 조건의 입력을 전제로 함.
            //{
            //    if (!first)
            //        Console.WriteLine("다시 입력해주세요.");

            //    first = false;
            //    v = InputInt(msg);
            //} while (!(v >= start && v <= end));
            //----------------------------- 타입2

            //bool retry = false;
            //do
            //{
            //    if (retry)
            //        Console.WriteLine("다시 입력해주세요.");
            //    retry = true;
            //    v = InputInt(msg);
            //} while (!(v >= start && v <= end));
            //----------------------------타입3

            bool retry = false;
            do
            {
                if (retry)
                    Console.WriteLine("다시 입력해주세요.");
                retry = true;
                v = InputInt(msg);
            } while (v < start || v > end);


            return v;
        }

        static void Main(string[] args)
        {
            int w = InputInt("입력", 1, 7);

            string s = "";

            switch (w)
            {
                case 1:
                    s = "월요일";
                    break;  // 해당 case에 대한 더 이상의 문장은 없음.
                case 2:
                    s = "화요일";
                    break;
                case 3:
                    s = "수요일";
                    break;
                case 4:
                    s = "목요일";
                    break;
                case 5:
                    s = "금요일";
                    break;
                case 6:
                    s = "토요일";
                    break;
                case 7:
                    s = "일요일";
                    break;

                default:   // 위의 case에 해당안될 때
                    s = "입력값을 다시 확인하세요.";
                    break;
            }

            Console.WriteLine(s);
        }
    }
}
