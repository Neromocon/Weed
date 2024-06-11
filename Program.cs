using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._06._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string rsp = "2052205";
            //string answer = "";


            //foreach (char c in rsp) 
            //{
            //    if (c == '2')
            //    {
            //        answer += "0";
            //    }
            //    else if (c == '0')
            //    {
            //        answer += "5";
            //    }
            //    else if (c == '5')
            //    {
            //        answer += "2" ;
            //    }
            //}
            //Console.WriteLine(answer);

            //string my_string = "1a2b3c4d123";
            //int answer = 0;

            //foreach (char c in my_string) 
            //{
            //    if (char.IsDigit(c))
            //        answer += (c - 48);
            //}
            //Console.WriteLine(answer);

            //string cipher = "pfqallllabwaoclk";
            //int code = 2;
            //string answer = "";

            //for (int i = 0; i < cipher.Length; i++)
            //{
            //    if ((i + 1) % code == 0)
            //        answer += cipher[i].ToString();
            //}

            //int x = 0;

            //foreach (char c in cipher) 
            //{
            //    if((x+1) % code == 0)
            //        answer += c;
            //    x++;
            //}
            //Console.WriteLine(answer);

            //string my_string = "nice to meet you";
            //string answer = "";
            //foreach (char c in my_string) 
            //{
            //    if(c != 'a' && c != 'e' && c != 'i' && c != 'o' && c != 'u')
            //        answer += c;
            //}
            //Console.WriteLine(answer);

            //string message = "I love you~";
            //int len = 2;
            //int answer = message.Length * len;

            //Console.WriteLine(answer);

            //string my_string = "abCdEfghIJ";

            //char[] c = my_string.ToCharArray();
            //for(int i = 0; i < my_string.Length; i++)
            //{
            //    if (char.IsUpper(c[i]))
            //        c[i] = char.ToLower(c[i]);
            //    else if (char.IsLower(c[i]))
            //        c[i] = char.ToUpper(c[i]);
            //}
            //string answer = new string(c);
            //Console.WriteLine(answer);

            int[] array = { 1, 8, 3 };
            int max = int.MinValue;
            int maxIndex = -1;

            
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                } 
               
            }
            int[] answer = new int[] { max, maxIndex};
            Console.WriteLine(answer);

        }
    }
}
