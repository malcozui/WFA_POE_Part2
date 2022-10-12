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


        public Map(int minMapWidth, int maxMapWidth, int minMapHeight, int maxMapHeight, int enemyCount)  
        {
            enemies = new Enemy[enemyCount];
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


            for (int i = 0; i < enemies.Length; i++)
            {
                Create(Tile.TileType.Enemy);
            }
            UpdateVision();
        }

        #region Properties

        public Tile[,] GameMap { get { return map; } } 
        public Hero GameHero { get { return hero; } }
        public Enemy[] GameEnemies { get { return enemies; } set { enemies = value; } }

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

        #endregion
    }
}
