using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_POE
{
    abstract class Enemy : Character
    {
        public Random rndm = new();

        protected Enemy(int x, int y, int hp, int maxHp, int damage) : base(x, y, hp, maxHp, damage)
        {

        }

        #region Methods

        public override string ToString() // Display enemy stats
        {
            return ($"Enemy at: [{this.X}, {this.Y}], Damage amount: ({this.Damage})\n To remove: Health = {this.hp}");
        }

        #endregion
    }
}
