namespace WFA_POE
{
    public partial class GameForm : Form
    {
        private GameEngine engine;
        public delegate void Updaters();
        Updaters Update;

        public GameForm()
        {
            InitializeComponent();
            engine = new GameEngine();
            UpdateMap();
            DispPlayerStats();
            UpdateEnemyComboBox();

            Update += UpdateMap;
            Update += DispPlayerStats;
            Update += UpdateVision;
        }



        #region Events
        private void Btn_Attack_Click(object sender, EventArgs e)
        {
            if (ComboBox_Enemies.SelectedIndex == -1) return;
            if (engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex].IsDead())
            {
                Re_Enemy_Stats.Text = "Enemy Dead";
                engine.GameMap.GameMap[engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex].Y,
                               engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex].X]
                    = new EmptyTile(engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex].X, engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex].Y)
                    {
                        Type = Tile.TileType.EmptyTile
                    };
                UpdateMap();
                UpdateEnemyComboBox();
                return;
            }
            bool success = engine.GameMap.GameHero.CheckRange(engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex]);
            engine.GameMap.GameHero.Attack(engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex]);
            if (success) UpdateSelectedEnemyStats();
            else Re_Enemy_Stats.Text = "Attack Unsucessful";
        }

        private void ComboBox_Enemies_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedEnemyStats();
        }
        
        private void GameForm_Load(object sender, EventArgs e)
        {
            
        }

        private void LblStart_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region DisplayMethods
        private void UpdateEnemyComboBox() //Tells if enemy is dead
        {
            ComboBox_Enemies.Items.Clear();
            for (int i = 0; i < engine.GameMap.GameEnemies.Length; i++)
            {
                if (engine.GameMap.GameEnemies[i].IsDead()) ComboBox_Enemies.Items.Add("Enemy dead.");
                else ComboBox_Enemies.Items.Add(engine.GameMap.GameEnemies[i].ToString());
            }
        }
        private void UpdateSelectedEnemyStats() // if enemy is dead is tells us
        {
            if (engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex].IsDead())
            {
                Re_Enemy_Stats.Text = "Enemy is already dead.";
            }
            else Re_Enemy_Stats.Text = engine.GameMap.GameEnemies[ComboBox_Enemies.SelectedIndex].ToString();
        }

        private void DispPlayerStats() // Player stats
        {
            Re_Player_Stats.Text = engine.GameMap.GameHero.ToString();
        }

        private void UpdateMap() // Update tile map
        {
            LblMap.Text = engine.ToString();
        }

        private void UpdateVision() // Update hero or enemy vision
        {
            engine.GameMap.UpdateVision();
        }
        #endregion

        #region Directional Buttons
        private void Btn_Up_Click(object sender, EventArgs e) // Up Button
        {
            engine.MovePlayer(Character.Movement.Up);
            Update();
        }

        private void Btn_Down_Click(object sender, EventArgs e) // Down Button
        {
            engine.MovePlayer(Character.Movement.Down);
            Update();

        }

        private void Btn_Left_Click(object sender, EventArgs e) // Left Button
        {
            engine.MovePlayer(Character.Movement.Left);
            Update();

        }

        private void Btn_Right_Click(object sender, EventArgs e) // Right Button
        {
            engine.MovePlayer(Character.Movement.Right);
            Update();

        }

        private void Btn_Stay_Click(object sender, EventArgs e)
        {
            engine.MovePlayer(Character.Movement.NoMovement);
            Update();

        }
        #endregion

    }
}