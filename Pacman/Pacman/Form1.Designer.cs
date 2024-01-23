namespace Pacman
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

       
        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.level1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.game_Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pacman = new System.Windows.Forms.PictureBox();
            this.yellowGhost = new System.Windows.Forms.PictureBox();
            this.pinkGhost = new System.Windows.Forms.PictureBox();
            this.redGhost = new System.Windows.Forms.PictureBox();
            this.wall4 = new System.Windows.Forms.PictureBox();
            this.wall3 = new System.Windows.Forms.PictureBox();
            this.wall2 = new System.Windows.Forms.PictureBox();
            this.wall1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreLabel.Location = new System.Drawing.Point(1, 7);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(54, 27);
            this.ScoreLabel.TabIndex = 8;
            this.ScoreLabel.Text = "Score: ";
            // 
            // level1
            // 
            this.level1.BackColor = System.Drawing.Color.Blue;
            this.level1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.level1.Location = new System.Drawing.Point(137, 94);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(200, 30);
            this.level1.TabIndex = 9;
            this.level1.Tag = "level";
            this.level1.Text = "level1";
            this.level1.UseVisualStyleBackColor = false;
            this.level1.Click += new System.EventHandler(this.level1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(137, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 32);
            this.button1.TabIndex = 10;
            this.button1.Tag = "level";
            this.button1.Text = "level2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.level1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(137, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 28);
            this.button2.TabIndex = 11;
            this.button2.Tag = "level";
            this.button2.Text = "level3";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.level1_Click_1);
            // 
            // game_Timer
            // 
            this.game_Timer.Tick += new System.EventHandler(this.game_Timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pacman
            // 
            this.pacman.BackColor = System.Drawing.Color.Transparent;
            this.pacman.Cursor = System.Windows.Forms.Cursors.No;
            this.pacman.Image = global::Pacman.Properties.Resources.pacman;
            this.pacman.Location = new System.Drawing.Point(39, 76);
            this.pacman.Name = "pacman";
            this.pacman.Size = new System.Drawing.Size(40, 40);
            this.pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pacman.TabIndex = 7;
            this.pacman.TabStop = false;
            this.pacman.Tag = "player";
            // 
            // yellowGhost
            // 
            this.yellowGhost.Image = global::Pacman.Properties.Resources.yellow_guy;
            this.yellowGhost.Location = new System.Drawing.Point(251, 264);
            this.yellowGhost.Name = "yellowGhost";
            this.yellowGhost.Size = new System.Drawing.Size(53, 50);
            this.yellowGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowGhost.TabIndex = 6;
            this.yellowGhost.TabStop = false;
            this.yellowGhost.Tag = "ghost";
            // 
            // pinkGhost
            // 
            this.pinkGhost.Image = global::Pacman.Properties.Resources.pinkghost;
            this.pinkGhost.Location = new System.Drawing.Point(344, 161);
            this.pinkGhost.Name = "pinkGhost";
            this.pinkGhost.Size = new System.Drawing.Size(58, 50);
            this.pinkGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pinkGhost.TabIndex = 5;
            this.pinkGhost.TabStop = false;
            this.pinkGhost.Tag = "ghost";
            // 
            // redGhost
            // 
            this.redGhost.Image = global::Pacman.Properties.Resources.red_guy;
            this.redGhost.Location = new System.Drawing.Point(174, 56);
            this.redGhost.Name = "redGhost";
            this.redGhost.Size = new System.Drawing.Size(51, 48);
            this.redGhost.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redGhost.TabIndex = 4;
            this.redGhost.TabStop = false;
            this.redGhost.Tag = "ghost";
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.Blue;
            this.wall4.Location = new System.Drawing.Point(365, 250);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(27, 96);
            this.wall4.TabIndex = 3;
            this.wall4.TabStop = false;
            this.wall4.Tag = "wall";
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Blue;
            this.wall3.Location = new System.Drawing.Point(173, 250);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(27, 96);
            this.wall3.TabIndex = 2;
            this.wall3.TabStop = false;
            this.wall3.Tag = "wall";
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Blue;
            this.wall2.Location = new System.Drawing.Point(310, 0);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(27, 135);
            this.wall2.TabIndex = 1;
            this.wall2.TabStop = false;
            this.wall2.Tag = "wall";
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Blue;
            this.wall1.Location = new System.Drawing.Point(141, 0);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(27, 135);
            this.wall1.TabIndex = 0;
            this.wall1.TabStop = false;
            this.wall1.Tag = "wall";
            this.wall1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.level1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.pacman);
            this.Controls.Add(this.yellowGhost);
            this.Controls.Add(this.pinkGhost);
            this.Controls.Add(this.redGhost);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacman";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinkGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redGhost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wall1;
        private System.Windows.Forms.PictureBox wall2;
        private System.Windows.Forms.PictureBox wall3;
        private System.Windows.Forms.PictureBox wall4;
        private System.Windows.Forms.PictureBox redGhost;
        private System.Windows.Forms.PictureBox pinkGhost;
        private System.Windows.Forms.PictureBox yellowGhost;
        private System.Windows.Forms.PictureBox pacman;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Button level1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer game_Timer;
        private System.Windows.Forms.Timer timer1;
    }
}

