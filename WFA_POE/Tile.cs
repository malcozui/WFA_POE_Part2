using System;

namespace WFA_POE
{
    // Tile is the base class for all in-game objects that have positions on the map.
    public abstract class Tile  
    {
        private int x;
        private int y;
        
        public enum TileType // Tile type that the map is made out of
        {
            Hero,
            Enemy,
            Gold,
            Weapon,
            Obstacle,
            EmptyTile
        }

        public Tile(int x, int y) // X and y position in map of Tiletype
        {
            this.x = x;
            this.y = y;
        }

        #region Properties

        public int X { get { return x; } set { x = value; } } //Get and setter
        public int Y { get { return y; } set { y = value; } } //Get and setter
        public TileType Type { get; set; } //Get and setter

        #endregion   //Expand this for more 

    }
}
