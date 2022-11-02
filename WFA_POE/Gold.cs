using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_POE
{
    internal class Gold : Item 
    {
        private int goldAmount;
        private Random rndm = new Random();

        public Gold(int x, int y) : base(x, y)
        {
            goldAmount = rndm.Next(1, 6);
        }

        public int GoldAmount { get => goldAmount; }

        public override string ToString()
        {
            return goldAmount.ToString();
        }
    }

}
