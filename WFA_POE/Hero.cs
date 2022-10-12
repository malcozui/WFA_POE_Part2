    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_POE
{
    internal class Hero : Character
    {
        public Hero(int x, int y, int hp, int maxHp) : base(x, y, hp, maxHp, 2)
        {
            
        }

        public override Movement ReturnMove(Movement move)
        {
            if (move == Movement.NoMovement) return move;
            return (Charactermovement[(int)move].Type is TileType.EmptyTile or TileType.Gold) ? move : Movement.NoMovement;
        }

        public override string ToString() // Display hero stats
        {
            return ($"Player Stats :\nHp : {this.hp} / {this.maxHp} \nDamage : {this.damage}\n[{this.X},{this.Y}]\n Gold {this.goldAmount}");
        }
    }
}
