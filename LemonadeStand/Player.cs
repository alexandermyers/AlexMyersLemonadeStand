using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Player
    {
        private double wallet;
        public double Wallet
        {
            if(wallet <= 0)
            {
                set wallet = 0;
                set => wallet = value;
        }
        public Pitcher Pitcher
        {
            get => default(Pitcher);
            set
            {
            }
        }

        public Inventory Inventory
        {
            get => default(Inventory);
            set
            {
            }
        }
    }
}