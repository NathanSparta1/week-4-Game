using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCubeAttack
{
    class Player:GameEntity
    {
        bool isShooting;
        int ammo;
        public Player()
        {
            // initialise player position in middle of screen
            XPos = 400;
            YPos = 200;

        }

        public bool IsShooting { get => isShooting; set => isShooting = value; }
        public int Ammo { get => ammo; set => ammo = value; }
    }
}
