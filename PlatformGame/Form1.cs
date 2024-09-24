using System.Media;

namespace PlatformGame
{
    public partial class frmGame : Form
    {
        private int enemy1Speed_;
        private int enemy2Speed_;
        private int playerSpeed_;
        private bool goLeft_, goRight_, lastKeyRight_, lastKeyLeft_, jumping_;
        private int jumpSpeed_, gravity_, score_, startingTop_, startingLeft_, right_, top_;
        private SoundPlayer gameTheme_;
        public frmGame()
        {
            InitializeComponent();
            enemy1Speed_ = 4;
            enemy2Speed_ = 5;
            playerSpeed_ = 6;
            pbxEnemy1.BringToFront();
            pbxEnemy2.BringToFront();

            right_ = ClientSize.Width;
            top_ = ClientSize.Height;

            startingTop_ = pbxPlayer.Top;
            startingLeft_ = pbxPlayer.Left;

            gameTheme_ = new SoundPlayer(Properties.Resources.theme);

            restartGame();

        }
        private void tmrGame_Tick(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + score_;
            pbxPlayer.Top += jumpSpeed_;
            if (goLeft_ == true)
            {
                pbxPlayer.Left -= playerSpeed_;

                if (pbxPlayer.Left < 0)
                {
                    pbxPlayer.Left = startingLeft_;
                    pbxPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pbxPlayer.Refresh();
                }
            }

            if (goRight_ == true)
            {
                pbxPlayer.Left += playerSpeed_;

                if (pbxPlayer.Left + pbxPlayer.Width > ClientSize.Width)
                { 
                    pbxPlayer.Left = ClientSize.Width - pbxPlayer.Width;
                    pbxPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pbxPlayer.Refresh();
                }
            }

            if (jumping_ == true && gravity_ < 0)
            {
                jumping_ = false;
            }

            if (jumping_ == true)
            {
                jumpSpeed_ = -7;
                gravity_ -= 1;
            }
            else
            {
                jumpSpeed_ = 10;
            }

            foreach (Control control in this.Controls)
            {
                if ((string)control.Tag == "enemy")
                {
                    if (pbxPlayer.Bounds.IntersectsWith(control.Bounds))
                    {
                        tmrGame.Stop();
                        restartGame();
                    }
                }

                if ((string)control.Tag == "platform")
                {
                    if (pbxPlayer.Bounds.IntersectsWith(control.Bounds))
                    {
                        gravity_ = 7;
                        pbxPlayer.Top = control.Top - pbxPlayer.Height;
                    }
                }

                if (((string)control.Tag == "coin"))
                {
                    if (pbxPlayer.Bounds.IntersectsWith(control.Bounds) && control.Visible == true)
                    {
                        control.Visible = false;
                        score_++;
                    }
                }
            }

            pbxEnemy1.Left -= enemy1Speed_;

            if (pbxEnemy1.Left < pbxGround6.Left || pbxEnemy1.Left + pbxEnemy1.Width > pbxGround6.Width + pbxGround6.Left)
            {
                enemy1Speed_ = -enemy1Speed_;
            }

            pbxEnemy2.Left -= enemy2Speed_;

            if (pbxEnemy2.Left < pbxGround3.Left || pbxEnemy2.Left + pbxEnemy2.Width > pbxGround3.Width + pbxGround3.Left)
            {
                enemy2Speed_ = -enemy2Speed_;
            }

            if (pbxPlayer.Bounds.IntersectsWith(pictureBox21.Bounds))
            {
                tmrGame.Stop();

                if (MessageBox.Show("You won! Score: " + score_ + "\n\nPlay Again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    restartGame();
                }
                else
                {
                    Application.Exit();
                }
            }

            if (pbxPlayer.Top > ClientSize.Height)
            {
                tmrGame.Stop();

                if (MessageBox.Show("You died! Score: " + score_ + "\n\nPlay Again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    restartGame();
                }
                else
                {
                    Application.Exit();
                }
            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft_ = true;

                if (lastKeyRight_ == true)
                {
                    pbxPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pbxPlayer.Refresh();
                }

                lastKeyRight_ = false;
                lastKeyLeft_ = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight_ = true;

                if (lastKeyLeft_ == true)
                {
                    pbxPlayer.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    pbxPlayer.Refresh();
                }

                lastKeyRight_ = true;
                lastKeyLeft_ = false;
            }

            if (e.KeyCode == Keys.Space && jumping_ == false)
            {
                jumping_ = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft_ = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight_ = false;
            }

            if (jumping_ == true)
            {
                jumping_ = false;
            }
        }

        private void restartGame()
        {
            lastKeyLeft_ = false;
            lastKeyRight_ = false;
            jumping_ = false;
            jumpSpeed_ = 0;
            gravity_ = 0;
            score_ = 0;

            lblScore.Text = "Score: " + score_;

            foreach (Control control in this.Controls)
            {
                if (control is PictureBox && control.Visible == false)
                {
                    control.Visible = true;
                }
            }
            pbxPlayer.Top = startingTop_;
            pbxPlayer.Left = startingLeft_;

            goLeft_ = false;
            goRight_ = false;

            gameTheme_.PlayLooping();

            tmrGame.Start();
        }
        
    }
}
