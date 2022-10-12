using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_POE
{
    internal class SwampCreature : Enemy
    {
        public SwampCreature(int x, int y, int hp = 10) : base(x, y, hp, 10, 1)
        {
            this.hp = hp;
        }

        public override Movement ReturnMove(Movement move = Movement.NoMovement) // Check movemnet
        {
            int randomDirection = 0;
            bool loop = true;
            int blockedCount = 0;

            for (int i = 0; i < charactermovement.Length; i++)
            {
                if (charactermovement[i].Type != TileType.EmptyTile) blockedCount++;
            }
            if (blockedCount >= 4) return Movement.NoMovement;

            while (loop)
            {
                randomDirection = rndm.Next(4);

                loop = !(charactermovement[randomDirection].Type == TileType.EmptyTile);
            }
            // when loop false the enemy move
            switch (randomDirection)
            {
                case 0:
                    return Movement.Up;
                    
                case 1:
                    return Movement.Down;
                    
                case 3:
                    return Movement.Left;
                    
                case 4:
                    return Movement.Right;
                    
                default:
                    return Movement.NoMovement;                
            }

        }
    }
}
