using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_POE
{
    internal class Map
    {
        private Tile[,] map;
        private Hero hero;
        private Enemy[] enemies;
        private int mapWidth, mapHeight;
        private Random random = new();
        private Item[] items;

        /// <summary>
        /// The Constructor for the map object
        /// </summary>
        /// <param name="minMapWidth">The inclusive minimum width of the map</param>
        /// <param name="maxMapWidth">The exclusive maximum width of the map </param>
        /// <param name="minMapHeight">The inclusive minimum height of the map</param>
        /// <param name="maxMapHeight">The exclusive maximum height of the map</param>
        /// <param name="enemyCount">The amount of enemies to spawn</param>
        /// <param name="goldCount">The amount of gold to spawn</param>
        public Map(int minMapWidth, int maxMapWidth, int minMapHeight, int maxMapHeight, int enemyCount, int goldCount)  
        {
            enemies = new Enemy[enemyCount];
            items = new Item[goldCount];

            mapWidth = random.Next(minMapWidth, maxMapWidth);
            mapHeight = random.Next(minMapHeight, maxMapHeight);
            
            map = new Tile[mapWidth, mapHeight];

            //Generate map boundry and inside with TileType.Obstacle and TileType.EmptyTile
            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {

                    if ((i == 0 || i == mapWidth - 1) || (j == 0 || j == mapHeight - 1))
                    {
                        map[i, j] = new Obstacle(i, j) { Type = Tile.TileType.Obstacle };
                    }
                    else
                    {
                        map[i, j] = new EmptyTile(i, j) { Type = Tile.TileType.EmptyTile };
                    }

                }
            }

            hero = (Hero)Create(Tile.TileType.Hero);
            hero.Hp = 99;
            hero.MaxHp = 99;

            int randomEnemy = 0;
            Random rnd = new Random();
            


            for (int i = 0; i < enemies.Length; i++)  // 50/ 50 enemy or mage spwan on map
            {
                randomEnemy = rnd.Next(0, 10); // Random number 
                
                if (randomEnemy <= 5)
                {
                    Create(Tile.TileType.Enemy);
                }
                else
                {
                    Create(Tile.TileType.Mage);
                }

                
            }
            for (int i = 0; i < items.Length; i++)
            {
                randomEnemy = rnd.Next(0, 10);

                if (randomEnemy <= 5)
                {
                    Create(Tile.TileType.Enemy);
                }
                else
                {
                    Create(Tile.TileType.Mage);
                }
            }
            UpdateVision();
        }

        #region Properties

        public Tile[,] GameMap { get { return map; } } 
        public Hero GameHero { get { return hero; } }
        public Enemy[] GameEnemies { get { return enemies; } set { enemies = value; } }
        public Item[] Items { get { return items; } set { items = value; } }

        #endregion

        #region Methods

        public void UpdateVision() //Update Vision for each class
        {
            Tile[] tmp = new Tile[4];
            tmp[0] = map[hero.Y - 1, hero.X]; //up
            tmp[1] = map[hero.Y + 1, hero.X]; //down
            tmp[2] = map[hero.Y, hero.X - 1]; //left
            tmp[3] = map[hero.Y, hero.X + 1]; //right
            hero.Charactermovement = tmp;

            foreach (Enemy e in enemies)
            {
                Tile[] enemyTmp = new Tile[4];
                enemyTmp[0] = map[e.Y - 1, e.X]; //up
                enemyTmp[1] = map[e.Y + 1, e.X]; //down
                enemyTmp[2] = map[e.Y, e.X - 1]; //left
                enemyTmp[3] = map[e.Y, e.X + 1]; //right
                e.Charactermovement = enemyTmp;
            }
        }

        private Tile Create(Tile.TileType type)
        {
            bool loop;
            int rndmX;
            int rndmY;
            do
            {
                rndmY = random.Next(2, mapWidth - 2);
                rndmX = random.Next(2, mapHeight - 2);

                if (map[rndmY, rndmX] == null)
                {
                    loop = false;
                }
                else
                {
                    loop = (map[rndmY, rndmX].Type != Tile.TileType.EmptyTile);
                }

            } while (loop);

            switch (type)
            {
                case Tile.TileType.Hero:
                    Hero tmp = new Hero(rndmX, rndmY, 99, 99);
                    map[rndmY, rndmX] = tmp;
                    map[rndmY, rndmX].Type = Tile.TileType.Hero;
                    return tmp;
                case Tile.TileType.Enemy:
                    SwampCreature tmp2 = new SwampCreature(rndmX, rndmY);
                    map[rndmY, rndmX] = tmp2;
                    map[rndmY, rndmX].Type = Tile.TileType.Enemy;
                    AddEnemy(tmp2);
                    return tmp2;
                case Tile.TileType.EmptyTile:
                    EmptyTile tmp3 = new EmptyTile(rndmX, rndmY);
                    map[rndmY, rndmX] = tmp3;
                    map[rndmY, rndmX].Type = Tile.TileType.EmptyTile;
                    return tmp3;
                case Tile.TileType.Gold:
                    Gold gold = new Gold(rndmX, rndmY);
                    map[rndmY, rndmX] = gold;
                    map[rndmY, rndmX].Type = Tile.TileType.EmptyTile;
                    return gold;
                default:
                    EmptyTile tmp4 = new EmptyTile(rndmX, rndmY);
                    map[rndmY, rndmX] = tmp4;
                    map[rndmY, rndmX].Type = Tile.TileType.EmptyTile;
                    return tmp4;

            }
        }

        private void AddEnemy(Enemy enemy)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] == null)
                {
                    enemies[i] = enemy;
                    break;
                }
            }
        }

        private void AddIte(Item item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = item;
                    break;
                }
            }
        }

        #endregion
    
    }
}
