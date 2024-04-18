using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Card.Card;

namespace Card
{
    internal class Program
    {
        static Random random = new Random();

        static int Dice() 
        {
            int r = random.Next();  // 0~~
            int d = 1 + (r % 6); // 1~6: 6개
            return d;
        }

        static bool Yut()
        {
            int r = random.Next();  
            return  (r % 2) == 0; // 짝,홀
            
        }

        static string[] Yutnori = {"모", "도", "개", "걸", "윳" };

        static void throwYut()
        {
            int c = 0;

            for (int i = 0; i < 4; i++) 
            {
                bool y = Yut();
                Console.Write(y ? "X" : "O");
                if (y) 
                {
                    c++;
                }
            }

            Console.WriteLine(Yutnori[c]);
        }


        static void Main(string[] args)
        {

            Deck deck = new Deck();

            deck.Shuffle();

            Console.WriteLine(deck);

            Random random = new Random();


            int d1 = Dice();
            int d2 = Dice();
            Console.WriteLine($"{d1}, {d2}");
            throwYut();


        }
    }
}
