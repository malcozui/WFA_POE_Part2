using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_POE
{
    internal class Mage : Enemy
    {
        public Mage(int x, int y, int hp = 5) : base(x, y, hp, 5, 5)
        {
            this.hp = hp;
        }

        public override Movement ReturnMove(Movement move = Movement.NoMovement) // Check movemnet
        {
            return Movement.NoMovement;
        }

        public override bool CheckRange(Character target)
        {
            //checks if the target is within the 8 tiles around the enemy
            return (Math.Abs(target.X - this.X) <= 1 && Math.Abs(target.Y - this.Y) <= 1);
        }
    }
}
