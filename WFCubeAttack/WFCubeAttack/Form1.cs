using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;


namespace WFCubeAttack
{
    public partial class Form1 : Form
    {
        
        Player player = new Player();
        bool gameOver;
        int kills;
        //bool isPaused;

        Enemy enemy = new Enemy();
        Enemy enemy1 = new Enemy();
        Enemy enemy2 = new Enemy();
        Enemy enemy3 = new Enemy();

        //PictureBox life2 = new PictureBox();

        // create instance of player picturebox
        PictureBox pbPlayer = new PictureBox();

        // create instance of enemy pictureboxes
        PictureBox pbEnemy = new PictureBox();
        PictureBox pbEnemy1 = new PictureBox();
        PictureBox pbEnemy2 = new PictureBox();
        PictureBox pbEnemy3 = new PictureBox();

        // instance of projectile
        Projectile proj = new Projectile();


        Game game = new Game();
        Random rnd = new Random();
        
        
        public Form1()
        {
            InitializeComponent();
            player.Health = 200;
           

            game.EnemyCount = 15;
            // int offset = rnd.Next(0, 40);


            //initialise enemy position
            enemy.XPos -= 150;
            enemy.YPos = 0;
            
            enemy1.XPos = 0;
            enemy1.YPos += 0;

            enemy2.XPos -= 200;
            enemy2.YPos += 30;

            enemy3.XPos -= 50;
            enemy3.YPos += 300;


        }

        
       

        private void Form1_PaintPlayer(object sender, PaintEventArgs e)
        {

           // initialise enemy speed
            enemy.Speed = 2.5;
            enemy1.Speed = 2;
            enemy2.Speed = 3;
            enemy3.Speed = 4;  // 3 4 5 6
           
      

            /////////////// code to make enemies chase player
            if (timer1.Enabled)
            {
                if (enemy.XPos > player.XPos)
                {
                    enemy.XPos -= (float)enemy.Speed;
                }
                if (enemy.YPos > player.YPos)
                {
                    enemy.YPos -= (float)enemy.Speed;
                }
                if (enemy.XPos < player.XPos)
                {
                    enemy.XPos += (float)enemy.Speed;
                }
                if (enemy.YPos < player.YPos)
                {
                    enemy.YPos += (float)enemy.Speed;
                }
                ///////////////  2nd enemy
                if (enemy1.XPos > player.XPos)
                {
                    enemy1.XPos -= (float)enemy1.Speed;
                }
                if (enemy1.YPos > player.XPos)
                {
                    enemy1.YPos -= (float)enemy1.Speed;
                }
                if (enemy1.XPos < player.XPos)
                {
                    enemy1.XPos += (float)enemy1.Speed;
                }
                if (enemy1.YPos < player.YPos)
                {
                    enemy1.YPos += (float)enemy1.Speed;
                }

                ////// 3rd enemy
                if (enemy2.XPos > player.XPos)
                {
                    enemy2.XPos -= (float)enemy2.Speed;
                }
                if (enemy2.YPos > player.XPos)
                {
                    enemy2.YPos -= (float)enemy2.Speed;
                }
                if (enemy2.XPos < player.XPos)
                {
                    enemy2.XPos += (float)enemy2.Speed;
                }
                if (enemy2.YPos < player.YPos)
                {
                    enemy2.YPos += (float)enemy2.Speed;
                }

                ////// 4th enemy
                if (enemy3.XPos > player.XPos)
                {
                    enemy3.XPos -= (float)enemy3.Speed;
                }
                if (enemy3.YPos > player.XPos)
                {
                    enemy3.YPos -= (float)enemy3.Speed;
                }
                if (enemy3.XPos < player.XPos)
                {
                    enemy3.XPos += (float)enemy3.Speed;
                }
                if (enemy3.YPos < player.YPos)
                {
                    enemy3.YPos += (float)enemy3.Speed;
                }
            }
            //////////////////////////////
            ///


            ////////// code that handles enemies interactive with projectiles
            foreach (Control x in this.Controls)
                    foreach (Control j in this.Controls)
                {
                   

                    if ((j is PictureBox && j.Tag == "projectile") && x is PictureBox && x.Tag == "enemy2")
                    {
                        // below is the if statement thats checking if bullet hits the enemy
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                          
                            this.Controls.Remove(j); // this will remove the bullet from the screen
                            j.Dispose(); // this will dispose the bullet all together from the program
                           // this.Controls.Remove(x); // this will remove the enemy from the screen
                           // x.Dispose(); // this will dispose the enemy from the program
                            enemy2.XPos = -150;
                            pbEnemy2.Left = -150;

                            kills++;
                            
                          
                        }

                    }
                    

                     else if ((j is PictureBox && j.Tag == "projectile") && x is PictureBox && x.Tag == "enemy")
                    {
                        // below is the if statement thats checking if bullet hits the enemy
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                           
                            this.Controls.Remove(j); // this will remove the bullet from the screen
                            j.Dispose(); // this will dispose the bullet all together from the program
                            //this.Controls.Remove(x); 
                            //x.Dispose(); 
                            enemy.XPos = 1000;

                            pbEnemy.Left = 1000;

                            enemy.YPos = rnd.Next(0, 600);
                            pbEnemy.Top = rnd.Next(0, 600);

                            // enemy.XPos = 100000;

                            kills++;
                        }

                    }
                    
                    else if ((j is PictureBox && j.Tag == "projectile") && x is PictureBox && x.Tag == "enemy1")
                    {
                        // below is the if statement thats checking if bullet hits the enemy
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            this.Controls.Remove(j); // this will remove the bullet from the screen
                            j.Dispose(); // this will dispose the bullet all together from the program
                            //this.Controls.Remove(x);
                            //x.Dispose(); 
                            enemy1.XPos = -100;
                            pbEnemy1.Left = -100;

                            enemy1.YPos = rnd.Next(0, 600);
                            pbEnemy1.Top = rnd.Next(0, 600);
                            // enemy1.XPos = 100000;

                            kills++;
                            
                        }

                    }

                    else if ((j is PictureBox && j.Tag == "projectile") && x is PictureBox && x.Tag == "enemy3")
                    {
                        // below is the if statement thats checking if bullet hits the zombie
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {

                            this.Controls.Remove(j); // this will remove the bullet from the screen
                            j.Dispose(); // this will dispose the bullet all together from the program
                                         //this.Controls.Remove(x); // this will remove the zombie from the screen
                                         //x.Dispose(); // this will dispose the zombie from the program

                            enemy3.XPos = -200;
                            pbEnemy3.Left = -200;

                            enemy3.YPos = rnd.Next(0, 600);
                            pbEnemy3.Top = rnd.Next(0, 600);
                            // enemy3.XPos = 100000;
                            kills++;
                           
                        }

                    }
    
                }
            
           ////// everything at the bottom used to be here

            GameOver();
            
            // reset();
         
        }


        ///////////// key down input for player
        private void PbPlayerKeyDown(object o, KeyEventArgs ke)
        {
            //key down conditions
            player.Speed = 10;

            if (ke.KeyData == Keys.A)
            {
                player.MovingLeft = true;
                player.Facing = "left"; //change facing to left
                

            }
            if (ke.KeyData == Keys.D)
            {
                player.MovingRight = true;
                player.Facing = "right"; //change facing to right

            }
            if (ke.KeyData == Keys.W)
            {
                player.MovingUp = true;
                player.Facing = "up"; //change facing to up

            }
            if (ke.KeyData == Keys.S)
            {
                player.MovingDown = true;
                player.Facing = "down"; //change facing to down

            }
            if (timer1.Enabled)
            {
                if (ke.KeyData == Keys.Space)
                {
                    shooting(player.Facing);

                }
            }

            //if (ke.KeyData == Keys.P)
            //{
            //    isPaused = !isPaused;


            //}

            if (ke.KeyData == Keys.P)
            {
                //isPaused = false;
                timer1.Stop();
            }

            if (ke.KeyData == Keys.O)
            {   
                    //isPaused = false;
                    timer1.Start();
            }
        }

       ////////////// key up input for player
        private void PbPlayerKeyUp(object o, KeyEventArgs ke)
        {
            //key up conditions
            if (ke.KeyData == Keys.A)
            {
                player.MovingLeft = false;
                
            }
            if (ke.KeyData == Keys.D)
            {
                player.MovingRight = false;

            }
            if (ke.KeyData == Keys.W)
            {
                player.MovingUp = false;

            }
            if (ke.KeyData == Keys.S)
            {
                player.MovingDown = false;

            }

            //if (ke.KeyData == Keys.P)
            //{
            //    //isPaused = false;
            //    timer1.Stop();


            //}

           

        }

        private void GameOver()
        {

            if (player.IsDead == true)
            {
                
                timer1.Stop();
                
               
                MessageBox.Show("You died");
                Close();
                // gameOver = true;

            }
            //if (pbEnemy.IsDisposed == true){enemy.IsDead = true;}
            //if(pbEnemy1.IsDisposed == true){enemy1.IsDead = true;}
            //if(pbEnemy2.IsDisposed == true){ enemy2.IsDead = true;}
            //if(pbEnemy3.IsDisposed == true){enemy3.IsDead = true;}


            if(kills == game.EnemyCount)
            {
                timer1.Stop();
                MessageBox.Show("Congrats level 1 is complete");
            }


            
        }
        private void shooting(string direct)
        {
            // this is the function thats makes the new bullets in this game
            Projectile shoot = new Projectile(); // create a new instance of the bullet class

            shoot.direction = direct; // assignment the direction to the bullet
            shoot.projectileLeft = (int)player.XPos; // place the bullet to left half of the player
            shoot.projectileTop = (int)player.YPos; // place the bullet on top half of the player
            shoot.mkProjectile(this); // run the function mkprojectile from the bullet class. 
        }

        //public void reset()
        //{
        //    if (gameOver == true)
        //    {
        //        MessageBox.Show("You're Dead at this game");

        //        player.XPos = 200;
        //        player.YPos = 200;
        //        player.Health = 100;
        //        enemy1.XPos += 100;
        //        enemy1.YPos += 100;
        //    }
        //    else gameOver = false;
        //}
        private void SpawnPlayer()
        {
            
            pbPlayer.BackColor = Color.Blue; 
            pbPlayer.Size = new Size(40, 40);
            pbPlayer.Tag = "player";
            //pbPlayer.Left = (int)player.XPos; // set left 
            //pbPlayer.Top = (int)player.YPos; // set right
            pbPlayer.BringToFront();
            
            Controls.Add(pbPlayer); // add the bullet to the screen
            
        }

        private void SpawnEnemy(PictureBox enemy0, Enemy enemy01)
        {          
            enemy0.Left = (int)enemy01.XPos; // set left 
            enemy0.Top = (int)enemy01.YPos; // set right
            enemy0.Size = new Size(25, 25);

            enemy0.BringToFront();

            Controls.Add(enemy0); // add the enemy to the screen

        }

        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            Invalidate();

            // move player on screen
            pbPlayer.Left = (int)player.XPos; // set left 
            pbPlayer.Top = (int)player.YPos; // set right
            SpawnPlayer();

            // set enemy on screen
           
            pbEnemy.Tag = "enemy";
            pbEnemy.BackColor = Color.Red;
            SpawnEnemy(pbEnemy,enemy);

            // set enemy2 on screen
            pbEnemy1.Tag = "enemy1";
            pbEnemy1.BackColor = Color.OrangeRed;
            SpawnEnemy(pbEnemy1,enemy1);

            //move enemy3 on screen
            pbEnemy2.Tag = "enemy2";
            pbEnemy2.BackColor = Color.DarkOrange;
            SpawnEnemy(pbEnemy2,enemy2);

            //move enemy4 on screen
            pbEnemy3.Tag = "enemy3";
            pbEnemy3.BackColor = Color.Firebrick;
            SpawnEnemy(pbEnemy3,enemy3);



            //code to move player

            if (player.MovingLeft == true)
            {
                player.XPos -= (int)player.Speed;

                if (player.XPos <= 0 - 40)
                {
                    player.XPos = 800;
                }

            }
           
            if(player.MovingRight == true)
            {
                player.XPos += (int)player.Speed;

                if (player.XPos >= 800 + 40)
                {
                    player.XPos = 0;
                }
            }
            if (player.MovingUp == true)
            {
                player.YPos -= (int)player.Speed;

                if (player.YPos <= 0 - 40)
                {
                    player.YPos = 490;
                }
            }
            if (player.MovingDown == true)
            {
                player.YPos += (int)player.Speed;
                if (player.YPos >= 450 + 40)
                {
                    player.YPos = 0 - 40;
                }
            }

            //if (isPaused == true)
            //{
            //    timer1.Stop();
            //}
            //else if (isPaused == false) { timer1.Start(); }

            // if the player is intersecting with the enemy then minus 10 from player health
            if (pbPlayer.Bounds.IntersectsWith(pbEnemy.Bounds) && enemy.IsDead == false ||
                pbPlayer.Bounds.IntersectsWith(pbEnemy1.Bounds) && enemy1.IsDead == false ||
                pbPlayer.Bounds.IntersectsWith(pbEnemy2.Bounds) && enemy2.IsDead == false ||
                pbPlayer.Bounds.IntersectsWith(pbEnemy3.Bounds) && enemy3.IsDead == false)
            {

                player.Health -= 10;
            }
            lbHealth.Text = "Health = " + player.Health.ToString();  // display health

            if (player.Health == 0 && player.IsDead == false) // if player has no health then he is dead
            {

                player.IsDead = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pMenu.Dispose();
            
            timer1.Start();
           
        }

        
    }
}
