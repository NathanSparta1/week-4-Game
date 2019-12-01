using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;


namespace WFCubeAttack
{

    class Projectile
    {
       
        public string direction; // creating a public string called direction
        public int projSpeed = 20; // creating a integer called speed and assigning a value of 20
        PictureBox projectile = new PictureBox(); // create a picture box 
        Timer tm = new Timer(); // create a new timer called tm. 

        public int projectileLeft; // create a new public integer
        public int projectileTop; // create a new public integer

        // end of the variables
        public Projectile()
        {
             
            
        }
        public void mkProjectile(Form1 form)
        {
            // this function will add the projectile to the game play
            // it is required to be called from the main class
            //PictureBox projectile = new PictureBox();
            projectile.BackColor = System.Drawing.Color.Black; // set the colour white for the bullet
            projectile.Size = new Size(10, 10); // set the size to the bullet to 5 pixel by 5 pixel
            projectile.Tag = "projectile"; // set the tag to projectile
            projectile.Left = projectileLeft; // set left 
           projectile.Top = projectileTop; // set right
            projectile.BringToFront(); // bring the bullet to front of other objects
            form.Controls.Add(projectile); // add the bullet to the screen

            tm.Interval = projSpeed; // set the timer interval to speed
            tm.Tick += new EventHandler(tm_Tick); // assignment the timer with an event
            tm.Start(); // start the timer

        }
        
        public void tm_Tick(object sender, EventArgs e)
        {
            // if direction equals to left
            if (direction == "left")
            {
                projectile.Left -= projSpeed; //towards the left of the screen
            }
            // if direction equals right
            if (direction == "right")
            {
                projectile.Left += projSpeed; //towards the right of the screen
            }
            // if direction is up
            if (direction == "up")
            {
                projectile.Top -= projSpeed; //towards top of the screen
            }
            // if direction is down
            if (direction == "down")
            {
                projectile.Top += projSpeed; // towards bottom of the screen
            }


            // checks if bullet is off screen, if yes delete the bullet
            if (projectile.Left < 0 || projectile.Left > 900 || projectile.Top < 0 || projectile.Top > 660)
            {
                tm.Stop(); // stop the timer
                tm.Dispose(); // dispose the timer event and component from the program
                projectile.Dispose(); // dispose the bullet
                tm = null; // nullify the timer object
                projectile = null; // nullify the bullet object
            }

        }


            

    }
    
}
