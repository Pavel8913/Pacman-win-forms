#region кот
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }
        bool goup,godown,goleft,goright;
        int count_coin = 0, score;
        int playerSpeed,redghostSpeed,yellowghostSpeed,pinkghostSpeed,pinkghostX,pinkghostY;
        bool goPinkghost = true;
        PictureBox[,] coin = new PictureBox[10, 9];

        #region управление
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //switch(e.KeyCode)
            //{
            //    case Keys.W:goup= true; break;
            //    case Keys.S:godown= true;break;
            //    case Keys.A:goleft= true;break;
            //    case Keys.D:goright= true;break;
            //}
            if (e.KeyCode == Keys.W)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
            }
            if (e.KeyCode == Keys.A)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if (e.KeyCode == Keys.F1)
            {
                score+= 70;
            }   
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.W: goup = false; break;
            //    case Keys.S: godown = false; break;
            //    case Keys.A: goleft = false; break;
            //    case Keys.D: goright = false; break;
            //}

            if (e.KeyCode == Keys.W)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }
            if (e.KeyCode == Keys.A)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.D)
            {
                goright = false;
            }
            if (e.KeyCode==Keys.Enter)
            {
                resetGame();
                game_Timer.Stop();
                timer1.Stop();
            }
            if(e.KeyCode==Keys.F5)
            {
                resetGame();
                game_Timer.Stop();
                timer1.Start();
            }
        }
        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            ScoreLabel.Text="Score: "+score+Environment.NewLine+"All the coins: "+count_coin;
            ScoreLabel.Visible=true;
            if(goleft)
            {

                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.pacman_left;
            }
            if(goright)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.pacman;

            }
            if(goup)
            {
                pacman.Top-= playerSpeed;
                pacman.Image= Properties.Resources.pacman_up;

            }
            if(godown)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.pacman_down;
            }
            if (pacman.Left > this.Width)
            {
                pacman.Left = 0;
            }
            
            if (pacman.Left > this.Width)
            {
                pacman.Left = 500;
            }

            if (pacman.Top > this.Height)
            {
                pacman.Top = 0;
            }

            if (pacman.Top < -40)
            {
                pacman.Top = 400;
            }

            if (pacman.Left < -40)
            {
                pacman.Left = 500;
            }

            if (score>=count_coin)
            {
                GameOvr("You Win!");
                game_Timer.Stop();
                timer1.Stop();
            }

            if (pinkGhost.Top < -40)
            {
                pinkghostX *= 1;
            }


            pinkGhost.Left -= pinkghostX;
            pinkGhost.Top -= pinkghostY;

            if(pinkGhost.Left<0||pinkGhost.Left>500)
            {
                pinkghostX *= -1;
            }
            if(pinkGhost.Top<0||pinkGhost.Top>400)
            {
                pinkghostY *= -1;
            }

           // pinkGhost.Left -= pinkghostX;
           // pinkGhost.Top -= pinkghostY;
           // if(goPinkghost)
           // {
           //     if (pinkGhost.Top < this.Top| pinkGhost.Top >this.Top)
           //     {
           //         pinkghostX *= -1;                    
           //     }

           //     if (pinkGhost.Width < this.Width || pinkGhost.Width >this.Width)
           //     {
           //         pinkghostX *= -1;
           //     }
           //     goPinkghost = false;
           // }

           //if(!goPinkghost)
           //{
           //     if (pinkGhost.Top > 0 || pinkGhost.Top < 400)
           //     {
           //         pinkghostX *= 1;
                   
           //     }

           //     if (pinkGhost.Width < 0 || pinkGhost.Width > 500)
           //     {
           //         pinkghostX *= 1;
           //     }
           //     goPinkghost = true;
           // }
           
           


        }
        private void game_Timer_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.Controls.Remove(x);
                            score++;
                        }
                    }



                    if ((string)x.Tag == "wall")
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameOvr("You Lose!");
                            timer1.Stop();
                        }
                        
                            if (pinkGhost.Bounds.IntersectsWith(x.Bounds))
                            {
                                pinkghostX *= -1;
                            }
                            redGhost.Left += redghostSpeed;
                            if (redGhost.Bounds.IntersectsWith(wall1.Bounds) || redGhost.Bounds.IntersectsWith(wall2.Bounds))
                            {
                                redghostSpeed *= -1;
                            }
                            yellowGhost.Left += yellowghostSpeed;
                            if (yellowGhost.Bounds.IntersectsWith(wall3.Bounds) || yellowGhost.Bounds.IntersectsWith(wall4.Bounds))
                            {
                                yellowghostSpeed *= -1;
                            }


                           


                        }

                    
                }
            }
            foreach (Control y in this.Controls)
            {
                if (y is PictureBox)
                {


                    if ((string)y.Tag == "ghost")
                    {
                        if (pacman.Bounds.IntersectsWith(y.Bounds))
                        {
                            GameOvr("You Lose!");
                            timer1.Stop();
                        }
                    }
                }
            }
            //foreach (Control y in this.Controls)
            //{
            //    if (y is PictureBox)
            //    {
            //        if ((string)y.Tag == "ghost")
            //        {

            //        }
            //    }
            //}
        }

        private void level1_Click_1(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            foreach (Control x in this.Controls)
            {
                if (x is Button)
                {
                    x.Enabled = false;
                    x.Visible = false;
                }
            }
            generate_map1();
            game_Timer.Start();
            timer1.Start();
            switch (bt.Text)
            {
                case "level1":
                    {
                        redghostSpeed = 5;
                        yellowghostSpeed = 5;
                        pinkghostX = 3;
                        pinkghostY = 3;
                        playerSpeed = 8;
                        break;
                    }


                case "level2":
                    {
                        redghostSpeed = 7;
                        yellowghostSpeed = 7;
                        pinkghostX = 4;
                        pinkghostY = 6;
                        playerSpeed = 10;
                        break;
                    }


                case "level3":
                    {
                        redghostSpeed = 9;
                        yellowghostSpeed = 9;
                        pinkghostX = 2;
                        pinkghostY = 11;
                        playerSpeed = 12;
                        break;
                    }


            }
        }

        
        
        private void generate_map1()
        {
            
            pacman.Left = 30;
            pacman.Top = 30;

            redGhost.Left= 215;
            redGhost.Top = 60;

            //251; 264
            yellowGhost.Left= 251;
            yellowGhost.Top= 264;

            //344; 161
            pinkGhost.Left= 344;
            pinkGhost.Top = 161;

            for(int i=0;i<10;i++)
            {
                for(int j=0;j<9;j++)
                {
                    coin[i, j] = new PictureBox();
                    coin[i, j].Location = new Point(coin[i, j].Location.X + i * 50, coin[i,j].Location.Y+j*34);
                    coin[i, j].Image = Properties.Resources.coin;
                    coin[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                    coin[i, j].Size = new Size(25,25);
                    coin[i, j].Tag = "coin";
                    count_coin++;
                    this.Controls.Add(coin[i,j]);
                    foreach(Control x in this.Controls)
                    {
                        if (coin[i,j].Bounds.IntersectsWith(x.Bounds)&&((string)x.Tag=="wall"))
                        {
                            this.Controls.Remove(coin[i,j]);
                            count_coin--;
                        }
                        //if (coin[i,j].Bounds.IntersectsWith(x.Bounds)&&(string)x.Tag=="ghost")
                        //{
                        //    this.Controls.Remove(coin[i, j]);
                        //    count_coin--;
                        //}
                    }
                    
                }
            }
            




        }
        private void resetGame()
        {
            timer1.Start();
            foreach(Control x in this.Controls)
            {
                if(x is Button)
                {
                    x.Visible = true;
                    x.Enabled= true;
                }
                for(int i=0;i<10;i++)
                {
                    for(int j=0;j<9;j++)
                    {
                        this.Controls.Remove(coin[i,j]);
                    }
                }

                count_coin = 0;
                score = 0;


            }
        }
        private void GameOvr(string message)
        {
            game_Timer.Stop();
            ScoreLabel.Text="Score: "+score+Environment.NewLine+message;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
#endregion
