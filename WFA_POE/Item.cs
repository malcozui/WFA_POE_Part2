using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_POE
{
    public abstract class Item : Tile
    {
        protected Item(int x, int y) : base(x, y)
        {

        }

        public abstract override string ToString();
    }
}
