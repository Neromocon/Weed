using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectD
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("문자를 입력하세요: ");
            string plainText = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            foreach (char ch in plainText)
            {
                char newchar = ch;
                if ((ch >= 'A' && ch <='Z') || (ch >='a' && ch<='z')) 
                {
                    newchar = (char)(ch + 3);
                    if ((Char.IsUpper(ch) && newchar >'Z') || (Char.IsLower(ch) && newchar > 'z'))
                    {
                        newchar = (char)(newchar - 26);
                    }
                }
                sb.Append(newchar);
            }
            Console.WriteLine(sb.ToString());
            
        }
        static void Main2() //시저의 암호
        {
            Console.Write("문자를 입력하세요: ");
            string plainText = Console.ReadLine();

            StringBuilder sb = new StringBuilder(); //StringBuilder는 여러 문자열을 효율적으로 결합하는데 사용하는 클래스.
            foreach (char ch in plainText) //foreach는 반복 가능한 자료형의 순환을 쉽게 할 수 있도록 도와준다.
            {                             // foreach(변수 유형 in 반복할 자료)
                char newchar = ch;

                if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                {
                    newchar = (char)(ch + 3);//newchar라는 변수에 ch라는 문자변수를 추가할 때 3만큼 더하라 그리고 (char)를 붙임으로서 문자 유형으로 변환하라.
                    if ((Char.IsUpper(ch) && newchar > 'Z') || (Char.IsLower(ch) && newchar <= 'z'))
                        //Char.IsUpper(ch)는 ()안의 변수(여기서는 ch)가 대문자인지를 확인한다. 반대로 Char.IsLower(ch)는 소문자인지를 확인한다.
                        //만약 ch가 Z보다 크고 또는 z보다 작을 때 둘 중의 하나라도 참 이면 알파벳 범위(해당 알파벳이 할당 된 유니코드)를 넘어간다.
                        //그래서 (char)newchar-26을 해 줌으로서 알파벳 범위로 되돌려 올바르게 출력할 수 있게 한다.
                    {
                        newchar = (char)(newchar - 26);
                    }
                }
                sb.Append(newchar);
            }
            Console.WriteLine(sb.ToString());
        
        }
        static void Main3()//대문자,소문자 변환
        {
            string s = "Hello World";
            string result = string.Empty;
            for (int i=0;i < s.Length ;i++ ) 
            {
                char t = s[i];
                if (char.IsUpper(t))
                {
                    t = char.ToLower(t);
                }
                else if (char.IsLower(t))
                {
                    t = char.ToUpper(t);
                }
                result +=t;
            }
            Console.WriteLine(result);
        }
    }
}
