using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card
{
    internal class Card
    {
        public enum Symbol {Heart, Diamond, Clover, Spade, BlackJoker, ColorJoker }

        private Symbol symbol;
        private int number;
        private string card;
        private static string mark = "♥◆♣♠ ";
        private static string[] numbers = 
            { " ", "A","2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};


        public Card(Symbol symbol, int number)  // 일반 카드용. 조커 제외
        {
            this.symbol = symbol;
            this.number = number;
            this.card = mark[(int)symbol].ToString() + numbers[number];
        }

        public Card(Symbol symbol)  // 조커용
        {
            this.symbol = symbol;
            this.number = 0;
            if (symbol == Symbol.BlackJoker)
                this.card = "BlackJoker";
            else if (symbol == Symbol.ColorJoker)
                this.card = "ColorJoker";
        }

        public override string ToString()
        {


            return this.card;
        }


    }
}
