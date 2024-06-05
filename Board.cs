using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlueMarbleEx2
{
    public partial class Board : Form
    {
        Place[] places = new Place[Place.N_PLACES];
        Player[] players = new Player[Player.N_PLAYERS];

        string[] place_names = {
            "출발", "타이베이", "황금열쇠", "베이징", "마닐라", "제주", "싱가포르", "황금열쇠", "카이로", "이스탄불", "무인도",
            "아테네", "황금열쇠", "코펜하겐", "스톡홀름", "콩코드여객기", "베른", "황금열쇠", "베를린", "오타와", "사회복지기금",
            "부에노스아이레스", "황금열쇠", "상파울로", "시드니", "부산", "하와이", "리스본", "퀸엘리자베스호", "마드리드", "우주여행",
            "도쿄", "컬럼버스호", "파리", "로마", "황금열쇠", "런던", "뉴욕", "사회복지기금", "서울"
        };

        int[] place_price = {
             0, 5, 0, 8, 8, 20, 10, 0, 10, 12, 0,
            14, 0, 16, 16, 20, 18, 0, 18, 20, 0,
            22, 0, 24, 24, 50, 26, 26, 30, 28, 0,
            30, 45, 32, 32, 0, 35, 35, 15, 100
        };

        public Board()
        {
            InitializeComponent();

            for (int i = 0; i < places.Length; i++)
            {
                Place p = new Place(i, place_names[i], price: place_price[i]);
                places[i] = p;
                //p.Text = i.ToString();
                Controls.Add(p);
            }
            for (int i = 0; i < players.Length; i++)
            {
                Player p = new Player(i);
                players[i] = p;
                p.Text = i.ToString();
                Controls.Add(p);
                MovePlayerToPlace(p, 0);
            }
        }

        private void Board_Load(object sender, EventArgs e)
        {
            
        }

        public void MovePlayerToPlace(Player p, int pos_index)
        {
            p.MoveXY(places[pos_index].center_x, places[pos_index].center_y);
            p.place_id = pos_index ;
        }

    }
}
