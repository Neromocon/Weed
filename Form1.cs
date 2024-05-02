using CardWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardWin_WF
{
   
    

    public partial class Board : Form
    {

        private Deck deck;
        
        private Cards[] player = new Cards[2]; 
        public Board()
        {
            deck = new Deck(Controls);
            deck.Shuffle();
            for(int i = 0; i < player.Length; i++) 
            {
                player[i] = new Cards(Controls, "선수", false);
                player[i].Location = new Point(0, 320 + 80 * i);
            }

            player[0].setMe(true);

            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Card c = deck.TakeOut(0);
                    player[j].PutIn(c);
                }
                
            }
            


            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < player.Length;i++) 
            {
                player[i].SortByNumber();
                player[i].OpenAll();
            }


            result.Text = player[0].Result() + "/" + player[1].Result();

        }
    }
}
