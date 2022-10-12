namespace WFA_POE
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblMap = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Attack = new System.Windows.Forms.Button();
            this.ComboBox_Enemies = new System.Windows.Forms.ComboBox();
            this.Re_Player_Stats = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Re_Enemy_Stats = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblStart = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Stay = new System.Windows.Forms.Button();
            this.Btn_Down = new System.Windows.Forms.Button();
            this.Btn_Left = new System.Windows.Forms.Button();
            this.Btn_Right = new System.Windows.Forms.Button();
            this.Btn_Up = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblMap
            // 
            this.LblMap.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblMap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblMap.Location = new System.Drawing.Point(338, 65);
            this.LblMap.Name = "LblMap";
            this.LblMap.Size = new System.Drawing.Size(400, 400);
            this.LblMap.TabIndex = 0;
            this.LblMap.Text = "XXXXXXXXXXXXXX \r\nX░░░░░░░X \r\nX░░░░░░░X \r\nX░░░░░░░X \r\nX░░░░░░░X \r\nX░░░░░░░X \r\nX░░░" +
    "░░░░X \r\nXXXXXXXXXXXXXXX \r\n\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.Btn_Attack);
            this.panel1.Controls.Add(this.ComboBox_Enemies);
            this.panel1.Controls.Add(this.Re_Player_Stats);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 613);
            this.panel1.TabIndex = 1;
            // 
            // Btn_Attack
            // 
            this.Btn_Attack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Attack.Location = new System.Drawing.Point(13, 359);
            this.Btn_Attack.Name = "Btn_Attack";
            this.Btn_Attack.Size = new System.Drawing.Size(303, 45);
            this.Btn_Attack.TabIndex = 5;
            this.Btn_Attack.Text = "Attack Selected";
            this.Btn_Attack.UseVisualStyleBackColor = false;
            this.Btn_Attack.Click += new System.EventHandler(this.Btn_Attack_Click);
            // 
            // ComboBox_Enemies
            // 
            this.ComboBox_Enemies.FormattingEnabled = true;
            this.ComboBox_Enemies.Location = new System.Drawing.Point(13, 330);
            this.ComboBox_Enemies.Name = "ComboBox_Enemies";
            this.ComboBox_Enemies.Size = new System.Drawing.Size(303, 23);
            this.ComboBox_Enemies.TabIndex = 5;
            this.ComboBox_Enemies.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Enemies_SelectedIndexChanged);
            // 
            // Re_Player_Stats
            // 
            this.Re_Player_Stats.Location = new System.Drawing.Point(13, 10);
            this.Re_Player_Stats.Name = "Re_Player_Stats";
            this.Re_Player_Stats.Size = new System.Drawing.Size(303, 300);
            this.Re_Player_Stats.TabIndex = 1;
            this.Re_Player_Stats.Text = "Player Stats";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.Re_Enemy_Stats);
            this.panel2.Location = new System.Drawing.Point(743, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 613);
            this.panel2.TabIndex = 2;
            // 
            // Re_Enemy_Stats
            // 
            this.Re_Enemy_Stats.Location = new System.Drawing.Point(15, 13);
            this.Re_Enemy_Stats.Name = "Re_Enemy_Stats";
            this.Re_Enemy_Stats.Size = new System.Drawing.Size(303, 592);
            this.Re_Enemy_Stats.TabIndex = 1;
            this.Re_Enemy_Stats.Text = "Enemy Stats";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblStart);
            this.panel3.Location = new System.Drawing.Point(337, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 60);
            this.panel3.TabIndex = 3;
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Location = new System.Drawing.Point(155, 16);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(79, 15);
            this.LblStart.TabIndex = 0;
            this.LblStart.Text = "GAME started";
            this.LblStart.Click += new System.EventHandler(this.LblStart_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.Btn_Stay);
            this.panel4.Controls.Add(this.Btn_Down);
            this.panel4.Controls.Add(this.Btn_Left);
            this.panel4.Controls.Add(this.Btn_Right);
            this.panel4.Controls.Add(this.Btn_Up);
            this.panel4.Location = new System.Drawing.Point(336, 468);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 147);
            this.panel4.TabIndex = 4;
            // 
            // Btn_Stay
            // 
            this.Btn_Stay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Stay.Location = new System.Drawing.Point(168, 53);
            this.Btn_Stay.Name = "Btn_Stay";
            this.Btn_Stay.Size = new System.Drawing.Size(45, 45);
            this.Btn_Stay.TabIndex = 4;
            this.Btn_Stay.Text = "None";
            this.Btn_Stay.UseVisualStyleBackColor = false;
            this.Btn_Stay.Click += new System.EventHandler(this.Btn_Stay_Click);
            // 
            // Btn_Down
            // 
            this.Btn_Down.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Down.Location = new System.Drawing.Point(168, 102);
            this.Btn_Down.Name = "Btn_Down";
            this.Btn_Down.Size = new System.Drawing.Size(45, 45);
            this.Btn_Down.TabIndex = 3;
            this.Btn_Down.Text = "↓";
            this.Btn_Down.UseVisualStyleBackColor = false;
            this.Btn_Down.Click += new System.EventHandler(this.Btn_Down_Click);
            // 
            // Btn_Left
            // 
            this.Btn_Left.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Left.Location = new System.Drawing.Point(117, 53);
            this.Btn_Left.Name = "Btn_Left";
            this.Btn_Left.Size = new System.Drawing.Size(45, 45);
            this.Btn_Left.TabIndex = 2;
            this.Btn_Left.Text = "←";
            this.Btn_Left.UseVisualStyleBackColor = false;
            this.Btn_Left.Click += new System.EventHandler(this.Btn_Left_Click);
            // 
            // Btn_Right
            // 
            this.Btn_Right.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Right.Location = new System.Drawing.Point(219, 53);
            this.Btn_Right.Name = "Btn_Right";
            this.Btn_Right.Size = new System.Drawing.Size(45, 45);
            this.Btn_Right.TabIndex = 1;
            this.Btn_Right.Text = "→";
            this.Btn_Right.UseVisualStyleBackColor = false;
            this.Btn_Right.Click += new System.EventHandler(this.Btn_Right_Click);
            // 
            // Btn_Up
            // 
            this.Btn_Up.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Up.Location = new System.Drawing.Point(168, 2);
            this.Btn_Up.Name = "Btn_Up";
            this.Btn_Up.Size = new System.Drawing.Size(45, 45);
            this.Btn_Up.TabIndex = 0;
            this.Btn_Up.Text = "↑";
            this.Btn_Up.UseVisualStyleBackColor = false;
            this.Btn_Up.Click += new System.EventHandler(this.Btn_Up_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 616);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LblMap);
            this.Name = "GameForm";
            this.Text = "Game Window";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label LblMap;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label LblStart;
        private RichTextBox Re_Player_Stats;
        private RichTextBox Re_Enemy_Stats;
        private Panel panel4;
        private Button Btn_Stay;
        private Button Btn_Down;
        private Button Btn_Left;
        private Button Btn_Right;
        private Button Btn_Up;
        private Button Btn_Attack;
        private ComboBox ComboBox_Enemies;
    }
}