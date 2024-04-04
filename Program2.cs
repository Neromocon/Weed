
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
        //static int InputInt(string s)
        //{
        //    Console.Write(s+":");

        //    return int.Parse(Console.ReadLine());
        //}

        //static int InputInt(string s, int start, int end)    //입력값의 범위를 지정  = 나 이 범위를 제외한 값은 필요 없음!
        //{
        //    string msg = s + "("+start+"~"+end+")";

        //    int v = 0;
        //    while (true)
        //    {
        //        v = InputInt(msg);
        //        if (v >= start && v <= end)
        //            break;
        //        Console.WriteLine("다시 입력해주세요.");
        //    }

        //}

        static bool CheckPassword(string pass)
        {
            Console.Write("비밀번호를 입력하세요. : ");
            string user = Console.ReadLine();
            return (user == pass);
        }

        //static bool CheckPassword(string pass, int retry)
        //{
        //    for (int i = 1; i <= retry; i++)
        //    {
        //        if (CheckPassword(pass))
        //            return true;
        //        if (i != retry)
        //            Console.WriteLine("재시도({0}번 남았습니다.)", retry - i);
        //    }
        //    return false;
        //}


        static bool CheckPassword2(string pass, int retry)
        {
            for (int i = 1; i <= retry; i++)
            {
                if (i != 1)
                    Console.WriteLine("재시도({0}번 남았습니다.)", retry -i+1);

                if (CheckPassword(pass))
                    return true;
                
            }
            return false;
        }

        static void Main(string[] args)
        {
            string p = "pass";
            if (CheckPassword2(p, 3))
            {
                Console.WriteLine("장비를 해제합니다.");
            }
            else
            {
                Console.WriteLine("장비를 정지합니다.");
            }
        }
    }
}
