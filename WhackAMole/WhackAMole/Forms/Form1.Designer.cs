namespace WhackAMole
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pn_Main = new System.Windows.Forms.Panel();
            this.pn_PlayArea = new System.Windows.Forms.Panel();
            this.btn_FakeButton = new System.Windows.Forms.Button();
            this.btn_GameButton = new System.Windows.Forms.Button();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Restart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_LivesLeftNum = new System.Windows.Forms.TextBox();
            this.lb_CheckpointNum = new System.Windows.Forms.Label();
            this.lb_CheckpointText = new System.Windows.Forms.Label();
            this.lb_TimeMissNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.piB_Life3 = new System.Windows.Forms.PictureBox();
            this.piB_Life2 = new System.Windows.Forms.PictureBox();
            this.piB_Life1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_ScoreNum = new System.Windows.Forms.Label();
            this.lb_ScoreText = new System.Windows.Forms.Label();
            this.lb_FakeHitsNum = new System.Windows.Forms.Label();
            this.lb_MisclickNum = new System.Windows.Forms.Label();
            this.lb_HitsNum = new System.Windows.Forms.Label();
            this.lb_FakeHitsText = new System.Windows.Forms.Label();
            this.lb_MisClick = new System.Windows.Forms.Label();
            this.lb_HitsText = new System.Windows.Forms.Label();
            this.btn_ScoreSubmit = new System.Windows.Forms.Button();
            this.pn_ScoreList = new System.Windows.Forms.Panel();
            this.lb_Points = new System.Windows.Forms.Label();
            this.lb_ScoreName = new System.Windows.Forms.Label();
            this.lb_ScoreRank = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.Design_Right3 = new System.Windows.Forms.Button();
            this.Design_Right2 = new System.Windows.Forms.Button();
            this.Design_Left2 = new System.Windows.Forms.Button();
            this.Design_Left3 = new System.Windows.Forms.Button();
            this.Design_Right1 = new System.Windows.Forms.Button();
            this.Design_Left1 = new System.Windows.Forms.Button();
            this.btn_Menu = new System.Windows.Forms.Button();
            this.pn_Main.SuspendLayout();
            this.pn_PlayArea.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Life1)).BeginInit();
            this.pn_ScoreList.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Tick += new System.EventHandler(this.GameTicks);
            // 
            // pn_Main
            // 
            this.pn_Main.Controls.Add(this.pn_PlayArea);
            this.pn_Main.Controls.Add(this.btn_Pause);
            this.pn_Main.Controls.Add(this.btn_Start);
            this.pn_Main.Controls.Add(this.btn_Restart);
            this.pn_Main.Location = new System.Drawing.Point(10, 58);
            this.pn_Main.Name = "pn_Main";
            this.pn_Main.Size = new System.Drawing.Size(581, 391);
            this.pn_Main.TabIndex = 12;
            this.pn_Main.Tag = "GameIcon";
            // 
            // pn_PlayArea
            // 
            this.pn_PlayArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_PlayArea.Controls.Add(this.btn_FakeButton);
            this.pn_PlayArea.Controls.Add(this.btn_GameButton);
            this.pn_PlayArea.Location = new System.Drawing.Point(15, 14);
            this.pn_PlayArea.Name = "pn_PlayArea";
            this.pn_PlayArea.Size = new System.Drawing.Size(549, 316);
            this.pn_PlayArea.TabIndex = 4;
            this.pn_PlayArea.Click += new System.EventHandler(this.LifeHurt);
            // 
            // btn_FakeButton
            // 
            this.btn_FakeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btn_FakeButton.BackgroundImage = global::WhackAMole.Properties.Resources.Mole_Fake;
            this.btn_FakeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_FakeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FakeButton.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FakeButton.Location = new System.Drawing.Point(114, 71);
            this.btn_FakeButton.Name = "btn_FakeButton";
            this.btn_FakeButton.Size = new System.Drawing.Size(50, 50);
            this.btn_FakeButton.TabIndex = 12;
            this.btn_FakeButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_FakeButton.UseVisualStyleBackColor = false;
            this.btn_FakeButton.Visible = false;
            this.btn_FakeButton.Click += new System.EventHandler(this.LifeHurt);
            // 
            // btn_GameButton
            // 
            this.btn_GameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btn_GameButton.BackgroundImage = global::WhackAMole.Properties.Resources.Mole;
            this.btn_GameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_GameButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_GameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GameButton.Font = new System.Drawing.Font("Roboto Light", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GameButton.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn_GameButton.Location = new System.Drawing.Point(237, 71);
            this.btn_GameButton.Name = "btn_GameButton";
            this.btn_GameButton.Size = new System.Drawing.Size(50, 50);
            this.btn_GameButton.TabIndex = 8;
            this.btn_GameButton.Text = "1000";
            this.btn_GameButton.UseVisualStyleBackColor = false;
            this.btn_GameButton.Visible = false;
            this.btn_GameButton.Click += new System.EventHandler(this.GameButton);
            // 
            // btn_Pause
            // 
            this.btn_Pause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btn_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Pause.FlatAppearance.BorderSize = 0;
            this.btn_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pause.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pause.Image = global::WhackAMole.Properties.Resources.Pause;
            this.btn_Pause.Location = new System.Drawing.Point(172, 336);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(75, 50);
            this.btn_Pause.TabIndex = 1;
            this.btn_Pause.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pause.UseVisualStyleBackColor = false;
            this.btn_Pause.Click += new System.EventHandler(this.Buttonclicked);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Start.FlatAppearance.BorderSize = 0;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Image = global::WhackAMole.Properties.Resources.Play;
            this.btn_Start.Location = new System.Drawing.Point(253, 336);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 50);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.Buttonclicked);
            // 
            // btn_Restart
            // 
            this.btn_Restart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btn_Restart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Restart.FlatAppearance.BorderSize = 0;
            this.btn_Restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restart.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restart.Image = global::WhackAMole.Properties.Resources.Replay;
            this.btn_Restart.Location = new System.Drawing.Point(334, 336);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(75, 50);
            this.btn_Restart.TabIndex = 3;
            this.btn_Restart.UseVisualStyleBackColor = false;
            this.btn_Restart.Click += new System.EventHandler(this.Buttonclicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_LivesLeftNum);
            this.groupBox1.Controls.Add(this.lb_CheckpointNum);
            this.groupBox1.Controls.Add(this.lb_CheckpointText);
            this.groupBox1.Controls.Add(this.lb_TimeMissNum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.piB_Life3);
            this.groupBox1.Controls.Add(this.piB_Life2);
            this.groupBox1.Controls.Add(this.piB_Life1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_ScoreNum);
            this.groupBox1.Controls.Add(this.lb_ScoreText);
            this.groupBox1.Controls.Add(this.lb_FakeHitsNum);
            this.groupBox1.Controls.Add(this.lb_MisclickNum);
            this.groupBox1.Controls.Add(this.lb_HitsNum);
            this.groupBox1.Controls.Add(this.lb_FakeHitsText);
            this.groupBox1.Controls.Add(this.lb_MisClick);
            this.groupBox1.Controls.Add(this.lb_HitsText);
            this.groupBox1.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Location = new System.Drawing.Point(610, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 330);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Game Stats";
            // 
            // lb_LivesLeftNum
            // 
            this.lb_LivesLeftNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.lb_LivesLeftNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_LivesLeftNum.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lb_LivesLeftNum.Location = new System.Drawing.Point(6, 303);
            this.lb_LivesLeftNum.Name = "lb_LivesLeftNum";
            this.lb_LivesLeftNum.ReadOnly = true;
            this.lb_LivesLeftNum.Size = new System.Drawing.Size(188, 21);
            this.lb_LivesLeftNum.TabIndex = 16;
            this.lb_LivesLeftNum.TabStop = false;
            this.lb_LivesLeftNum.Text = "%%%%";
            this.lb_LivesLeftNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_CheckpointNum
            // 
            this.lb_CheckpointNum.AutoSize = true;
            this.lb_CheckpointNum.Location = new System.Drawing.Point(9, 181);
            this.lb_CheckpointNum.Name = "lb_CheckpointNum";
            this.lb_CheckpointNum.Size = new System.Drawing.Size(39, 20);
            this.lb_CheckpointNum.TabIndex = 15;
            this.lb_CheckpointNum.Text = "###";
            // 
            // lb_CheckpointText
            // 
            this.lb_CheckpointText.AutoSize = true;
            this.lb_CheckpointText.Location = new System.Drawing.Point(6, 161);
            this.lb_CheckpointText.Name = "lb_CheckpointText";
            this.lb_CheckpointText.Size = new System.Drawing.Size(96, 20);
            this.lb_CheckpointText.TabIndex = 14;
            this.lb_CheckpointText.Text = "Checkpoint:";
            // 
            // lb_TimeMissNum
            // 
            this.lb_TimeMissNum.AutoSize = true;
            this.lb_TimeMissNum.Location = new System.Drawing.Point(110, 95);
            this.lb_TimeMissNum.Name = "lb_TimeMissNum";
            this.lb_TimeMissNum.Size = new System.Drawing.Size(39, 20);
            this.lb_TimeMissNum.TabIndex = 13;
            this.lb_TimeMissNum.Text = "###";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Time Miss:";
            // 
            // piB_Life3
            // 
            this.piB_Life3.BackgroundImage = global::WhackAMole.Properties.Resources.Heart;
            this.piB_Life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piB_Life3.Location = new System.Drawing.Point(144, 242);
            this.piB_Life3.Name = "piB_Life3";
            this.piB_Life3.Size = new System.Drawing.Size(50, 50);
            this.piB_Life3.TabIndex = 11;
            this.piB_Life3.TabStop = false;
            // 
            // piB_Life2
            // 
            this.piB_Life2.BackgroundImage = global::WhackAMole.Properties.Resources.Heart;
            this.piB_Life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piB_Life2.Location = new System.Drawing.Point(77, 242);
            this.piB_Life2.Name = "piB_Life2";
            this.piB_Life2.Size = new System.Drawing.Size(50, 50);
            this.piB_Life2.TabIndex = 10;
            this.piB_Life2.TabStop = false;
            // 
            // piB_Life1
            // 
            this.piB_Life1.BackgroundImage = global::WhackAMole.Properties.Resources.Heart;
            this.piB_Life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piB_Life1.Location = new System.Drawing.Point(6, 242);
            this.piB_Life1.Name = "piB_Life1";
            this.piB_Life1.Size = new System.Drawing.Size(50, 50);
            this.piB_Life1.TabIndex = 9;
            this.piB_Life1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(53, 213);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "LIVES LEFT";
            // 
            // lb_ScoreNum
            // 
            this.lb_ScoreNum.AutoSize = true;
            this.lb_ScoreNum.Location = new System.Drawing.Point(110, 35);
            this.lb_ScoreNum.Name = "lb_ScoreNum";
            this.lb_ScoreNum.Size = new System.Drawing.Size(39, 20);
            this.lb_ScoreNum.TabIndex = 7;
            this.lb_ScoreNum.Text = "###";
            // 
            // lb_ScoreText
            // 
            this.lb_ScoreText.AutoSize = true;
            this.lb_ScoreText.Location = new System.Drawing.Point(5, 35);
            this.lb_ScoreText.Name = "lb_ScoreText";
            this.lb_ScoreText.Size = new System.Drawing.Size(57, 20);
            this.lb_ScoreText.TabIndex = 6;
            this.lb_ScoreText.Text = "Score:";
            // 
            // lb_FakeHitsNum
            // 
            this.lb_FakeHitsNum.AutoSize = true;
            this.lb_FakeHitsNum.Location = new System.Drawing.Point(110, 116);
            this.lb_FakeHitsNum.Name = "lb_FakeHitsNum";
            this.lb_FakeHitsNum.Size = new System.Drawing.Size(39, 20);
            this.lb_FakeHitsNum.TabIndex = 5;
            this.lb_FakeHitsNum.Text = "###";
            // 
            // lb_MisclickNum
            // 
            this.lb_MisclickNum.AutoSize = true;
            this.lb_MisclickNum.Location = new System.Drawing.Point(110, 75);
            this.lb_MisclickNum.Name = "lb_MisclickNum";
            this.lb_MisclickNum.Size = new System.Drawing.Size(39, 20);
            this.lb_MisclickNum.TabIndex = 4;
            this.lb_MisclickNum.Text = "###";
            // 
            // lb_HitsNum
            // 
            this.lb_HitsNum.AutoSize = true;
            this.lb_HitsNum.Location = new System.Drawing.Point(110, 55);
            this.lb_HitsNum.Name = "lb_HitsNum";
            this.lb_HitsNum.Size = new System.Drawing.Size(39, 20);
            this.lb_HitsNum.TabIndex = 3;
            this.lb_HitsNum.Text = "###";
            // 
            // lb_FakeHitsText
            // 
            this.lb_FakeHitsText.AutoSize = true;
            this.lb_FakeHitsText.Location = new System.Drawing.Point(6, 116);
            this.lb_FakeHitsText.Name = "lb_FakeHitsText";
            this.lb_FakeHitsText.Size = new System.Drawing.Size(83, 20);
            this.lb_FakeHitsText.TabIndex = 2;
            this.lb_FakeHitsText.Text = "Fake Hits:";
            // 
            // lb_MisClick
            // 
            this.lb_MisClick.AutoSize = true;
            this.lb_MisClick.Location = new System.Drawing.Point(5, 75);
            this.lb_MisClick.Name = "lb_MisClick";
            this.lb_MisClick.Size = new System.Drawing.Size(75, 20);
            this.lb_MisClick.TabIndex = 1;
            this.lb_MisClick.Text = "Misclick:";
            // 
            // lb_HitsText
            // 
            this.lb_HitsText.AutoSize = true;
            this.lb_HitsText.Location = new System.Drawing.Point(5, 55);
            this.lb_HitsText.Name = "lb_HitsText";
            this.lb_HitsText.Size = new System.Drawing.Size(43, 20);
            this.lb_HitsText.TabIndex = 0;
            this.lb_HitsText.Text = "Hits:";
            // 
            // btn_ScoreSubmit
            // 
            this.btn_ScoreSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.btn_ScoreSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ScoreSubmit.FlatAppearance.BorderSize = 0;
            this.btn_ScoreSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ScoreSubmit.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ScoreSubmit.Location = new System.Drawing.Point(608, 394);
            this.btn_ScoreSubmit.Name = "btn_ScoreSubmit";
            this.btn_ScoreSubmit.Size = new System.Drawing.Size(202, 50);
            this.btn_ScoreSubmit.TabIndex = 5;
            this.btn_ScoreSubmit.Text = "SUBMIT SCORE";
            this.btn_ScoreSubmit.UseVisualStyleBackColor = false;
            this.btn_ScoreSubmit.Visible = false;
            this.btn_ScoreSubmit.Click += new System.EventHandler(this.Buttonclicked);
            // 
            // pn_ScoreList
            // 
            this.pn_ScoreList.Controls.Add(this.lb_Points);
            this.pn_ScoreList.Controls.Add(this.lb_ScoreName);
            this.pn_ScoreList.Controls.Add(this.lb_ScoreRank);
            this.pn_ScoreList.Font = new System.Drawing.Font("Roboto Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_ScoreList.Location = new System.Drawing.Point(853, 58);
            this.pn_ScoreList.Name = "pn_ScoreList";
            this.pn_ScoreList.Size = new System.Drawing.Size(412, 330);
            this.pn_ScoreList.TabIndex = 16;
            this.pn_ScoreList.Tag = "HighscoreList";
            this.pn_ScoreList.Visible = false;
            // 
            // lb_Points
            // 
            this.lb_Points.AutoSize = true;
            this.lb_Points.Location = new System.Drawing.Point(230, 14);
            this.lb_Points.Name = "lb_Points";
            this.lb_Points.Size = new System.Drawing.Size(56, 20);
            this.lb_Points.TabIndex = 2;
            this.lb_Points.Text = "Points";
            // 
            // lb_ScoreName
            // 
            this.lb_ScoreName.AutoSize = true;
            this.lb_ScoreName.Location = new System.Drawing.Point(100, 14);
            this.lb_ScoreName.Name = "lb_ScoreName";
            this.lb_ScoreName.Size = new System.Drawing.Size(54, 20);
            this.lb_ScoreName.TabIndex = 1;
            this.lb_ScoreName.Text = "Name";
            // 
            // lb_ScoreRank
            // 
            this.lb_ScoreRank.AutoSize = true;
            this.lb_ScoreRank.Location = new System.Drawing.Point(10, 14);
            this.lb_ScoreRank.Name = "lb_ScoreRank";
            this.lb_ScoreRank.Size = new System.Drawing.Size(46, 20);
            this.lb_ScoreRank.TabIndex = 0;
            this.lb_ScoreRank.Text = "Rank";
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(59)))));
            this.tb_Username.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_Username.Location = new System.Drawing.Point(616, 11);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(194, 38);
            this.tb_Username.TabIndex = 17;
            this.tb_Username.Text = "Enter Username";
            this.tb_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Username.Visible = false;
            this.tb_Username.Enter += new System.EventHandler(this.UsernameSub);
            this.tb_Username.Leave += new System.EventHandler(this.UsernameSub);
            // 
            // Design_Right3
            // 
            this.Design_Right3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.Design_Right3.BackgroundImage = global::WhackAMole.Properties.Resources.Mole_Fake;
            this.Design_Right3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Design_Right3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Design_Right3.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Design_Right3.Location = new System.Drawing.Point(400, 11);
            this.Design_Right3.Name = "Design_Right3";
            this.Design_Right3.Size = new System.Drawing.Size(30, 30);
            this.Design_Right3.TabIndex = 11;
            this.Design_Right3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Design_Right3.UseVisualStyleBackColor = false;
            // 
            // Design_Right2
            // 
            this.Design_Right2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.Design_Right2.BackgroundImage = global::WhackAMole.Properties.Resources.Mole_Fake;
            this.Design_Right2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Design_Right2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Design_Right2.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Design_Right2.Location = new System.Drawing.Point(354, 7);
            this.Design_Right2.Name = "Design_Right2";
            this.Design_Right2.Size = new System.Drawing.Size(40, 40);
            this.Design_Right2.TabIndex = 10;
            this.Design_Right2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Design_Right2.UseVisualStyleBackColor = false;
            // 
            // Design_Left2
            // 
            this.Design_Left2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.Design_Left2.BackgroundImage = global::WhackAMole.Properties.Resources.Mole;
            this.Design_Left2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Design_Left2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Design_Left2.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Design_Left2.Location = new System.Drawing.Point(196, 7);
            this.Design_Left2.Name = "Design_Left2";
            this.Design_Left2.Size = new System.Drawing.Size(40, 40);
            this.Design_Left2.TabIndex = 9;
            this.Design_Left2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Design_Left2.UseVisualStyleBackColor = false;
            // 
            // Design_Left3
            // 
            this.Design_Left3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.Design_Left3.BackgroundImage = global::WhackAMole.Properties.Resources.Mole;
            this.Design_Left3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Design_Left3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Design_Left3.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Design_Left3.Location = new System.Drawing.Point(160, 12);
            this.Design_Left3.Name = "Design_Left3";
            this.Design_Left3.Size = new System.Drawing.Size(30, 30);
            this.Design_Left3.TabIndex = 8;
            this.Design_Left3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Design_Left3.UseVisualStyleBackColor = false;
            // 
            // Design_Right1
            // 
            this.Design_Right1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.Design_Right1.BackgroundImage = global::WhackAMole.Properties.Resources.Mole_Fake;
            this.Design_Right1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Design_Right1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Design_Right1.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Design_Right1.Location = new System.Drawing.Point(298, 2);
            this.Design_Right1.Name = "Design_Right1";
            this.Design_Right1.Size = new System.Drawing.Size(50, 50);
            this.Design_Right1.TabIndex = 7;
            this.Design_Right1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Design_Right1.UseVisualStyleBackColor = false;
            // 
            // Design_Left1
            // 
            this.Design_Left1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.Design_Left1.BackgroundImage = global::WhackAMole.Properties.Resources.Mole;
            this.Design_Left1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Design_Left1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Design_Left1.Font = new System.Drawing.Font("Roboto Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Design_Left1.Location = new System.Drawing.Point(242, 2);
            this.Design_Left1.Name = "Design_Left1";
            this.Design_Left1.Size = new System.Drawing.Size(50, 50);
            this.Design_Left1.TabIndex = 6;
            this.Design_Left1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Design_Left1.UseVisualStyleBackColor = false;
            // 
            // btn_Menu
            // 
            this.btn_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btn_Menu.BackgroundImage = global::WhackAMole.Properties.Resources.HighscoreList;
            this.btn_Menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Menu.FlatAppearance.BorderSize = 0;
            this.btn_Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Menu.Font = new System.Drawing.Font("Roboto Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Menu.Location = new System.Drawing.Point(10, 11);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(50, 30);
            this.btn_Menu.TabIndex = 4;
            this.btn_Menu.UseVisualStyleBackColor = false;
            this.btn_Menu.Click += new System.EventHandler(this.MenuChange);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1611, 453);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.pn_ScoreList);
            this.Controls.Add(this.btn_ScoreSubmit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pn_Main);
            this.Controls.Add(this.Design_Right3);
            this.Controls.Add(this.Design_Right2);
            this.Controls.Add(this.Design_Left2);
            this.Controls.Add(this.Design_Left3);
            this.Controls.Add(this.Design_Right1);
            this.Controls.Add(this.Design_Left1);
            this.Controls.Add(this.btn_Menu);
            this.Font = new System.Drawing.Font("Roboto Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Wack a Mole";
            this.pn_Main.ResumeLayout(false);
            this.pn_PlayArea.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piB_Life1)).EndInit();
            this.pn_ScoreList.ResumeLayout(false);
            this.pn_ScoreList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Button btn_Restart;
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button Design_Left1;
        private System.Windows.Forms.Button Design_Right1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_GameButton;
        private System.Windows.Forms.Button Design_Left3;
        private System.Windows.Forms.Button Design_Left2;
        private System.Windows.Forms.Button Design_Right2;
        private System.Windows.Forms.Button Design_Right3;
        private System.Windows.Forms.Button btn_FakeButton;
        private System.Windows.Forms.Panel pn_Main;
        private System.Windows.Forms.Panel pn_PlayArea;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox piB_Life3;
        private System.Windows.Forms.PictureBox piB_Life2;
        private System.Windows.Forms.PictureBox piB_Life1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_ScoreNum;
        private System.Windows.Forms.Label lb_ScoreText;
        private System.Windows.Forms.Label lb_FakeHitsNum;
        private System.Windows.Forms.Label lb_MisclickNum;
        private System.Windows.Forms.Label lb_HitsNum;
        private System.Windows.Forms.Label lb_FakeHitsText;
        private System.Windows.Forms.Label lb_MisClick;
        private System.Windows.Forms.Label lb_HitsText;
        private System.Windows.Forms.Button btn_ScoreSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_TimeMissNum;
        private System.Windows.Forms.Label lb_CheckpointNum;
        private System.Windows.Forms.Label lb_CheckpointText;
        private System.Windows.Forms.TextBox lb_LivesLeftNum;
        private System.Windows.Forms.Panel pn_ScoreList;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label lb_ScoreRank;
        private System.Windows.Forms.Label lb_Points;
        private System.Windows.Forms.Label lb_ScoreName;
    }
}

