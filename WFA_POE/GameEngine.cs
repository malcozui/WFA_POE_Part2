using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_POE
{
    internal class GameEngine
    {
        private Map gameMap;
        private static readonly string HERO = "ඞ", EMPTY = "░", SWAMP_CREATURE = "👾", OBSTACLE = "◙", GOLD = "©" , MAGE = "M";  // Map TileType icons

        public GameEngine()
        {
            gameMap = new Map(10, 15, 10, 15, 5, 3); 
        }

        #region Properties
        
        public Map GameMap { get { return gameMap; } }   //👾

        #endregion

        #region Methods 

        public bool MovePlayer(Character.Movement direction)  // Player movement
        {
            //checks if the move is valid
            if (gameMap.GameHero.ReturnMove(direction) == direction)
            {
                //Moves the player in the requested direction
                gameMap.GameHero.Move(direction);
                gameMap.GameMap[gameMap.GameHero.Y, gameMap.GameHero.X] = new Hero(gameMap.GameHero.Y, gameMap.GameHero.X, gameMap.GameHero.Hp, gameMap.GameHero.MaxHp) { Type = Tile.TileType.Hero };
                switch (direction)
                {
                    //makes the tile the player was in empty after they leave.
                    case Character.Movement.Up:
                        gameMap.GameMap[gameMap.GameHero.Y + 1, gameMap.GameHero.X] = new EmptyTile(gameMap.GameHero.X, gameMap.GameHero.Y) { Type = Tile.TileType.EmptyTile };
                        break;
                    case Character.Movement.Down:
                        gameMap.GameMap[gameMap.GameHero.Y - 1, gameMap.GameHero.X] = new EmptyTile(gameMap.GameHero.X, gameMap.GameHero.Y) { Type = Tile.TileType.EmptyTile };
                        break;
                    case Character.Movement.Left:
                        gameMap.GameMap[gameMap.GameHero.Y, gameMap.GameHero.X + 1] = new EmptyTile(gameMap.GameHero.X, gameMap.GameHero.Y) { Type = Tile.TileType.EmptyTile };
                        break;
                    case Character.Movement.Right:
                        gameMap.GameMap[gameMap.GameHero.Y, gameMap.GameHero.X - 1] = new EmptyTile(gameMap.GameHero.X, gameMap.GameHero.Y) { Type = Tile.TileType.EmptyTile };
                        break;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString() // Display methode
        {
            StringBuilder sb = new();
            for (int i = 0; i < gameMap.GameMap.GetLength(0); i++)
            {
                for (int j = 0; j < gameMap.GameMap.GetLength(1); j++)
                {
                    switch (gameMap.GameMap[i, j].Type)
                    {
                        case Tile.TileType.Hero:
                            sb.Append(HERO);
                            break;
                        case Tile.TileType.Enemy:
                            sb.Append(SWAMP_CREATURE);
                            break;
                        case Tile.TileType.Obstacle:
                            sb.Append(OBSTACLE);
                            break;
                        case Tile.TileType.EmptyTile:
                            sb.Append(EMPTY);
                            break;
                        case Tile.TileType.Gold:
                            sb.Append(GOLD);
                            break;
                        case Tile.TileType.Mage:
                            sb.Append(MAGE);
                            break;
                        default:
                            break;
                    }
                    sb.Append(' ');
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        #endregion
    }
}
