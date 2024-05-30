﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueMarble
{
    public class City : Place
        // City 클래스 생성
    {
        public const int NO_OWNER = -1;
         
        private int owner = NO_OWNER;
        public readonly bool can_build;
        private RealEstate[] real_estates = null;
        
        private int total_pay = 0;
        private int total_refund = 0; // 환불 받을 돈

        City(int id, string name = "", string eng_name = "", int price = 0, int pay = 0, bool can_build = true)
            :base(id, name, eng_name, price, pay, true)
        {
            this.can_build = can_build;
            if (can_build)
            {
                real_estates = new RealEstate[3];
                for (int i = 0; i < real_estates.Length; i++) 
                {
                    real_estates[i] = new RealEstate((RealEstate.eKind)i, 100, 10); // 금액은 변경.
                }
            }

        }

        public void Refund()
        {
            if (owner == NO_OWNER)
                return;

            // total_refund 송금 ==> 원 소유주.   :)

            SetOwner(NO_OWNER);


        }

        public void CalculateTotalPay()
        {
            if(owner == NO_OWNER)
            {
                total_pay = 0;
                total_refund = 0;
                return;
            }

            {
                int sum = pay;
                for (int i = 0; i < real_estates.Length; i++)
                {
                    sum += real_estates[i].GetTotalPay();
                }
                total_pay = sum;
            }

            {
                int sum = price;
                for (int i = 0; i < real_estates.Length; i++)
                {
                    sum += real_estates[i].GetTotalCost();
                }
                total_refund = sum;
            }
        }

        public void SetOwner(int player_id)
        {
            owner = player_id;
            // 도착 시 즉시 결재 여부???
            CalculateTotalPay();
        }

        public void Build(RealEstate.eKind kind)
        {
            int i = (int)kind;
            real_estates[i].Build();
            CalculateTotalPay();
        }

        

    }
}
