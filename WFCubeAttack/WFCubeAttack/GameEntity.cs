using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCubeAttack
{
    class GameEntity
    {
        float xPos;
        float yPos;
        double speed;
        int health;
        bool isOnScreen;
        bool isDead;
        bool movingLeft;
        bool movingRight;
        bool movingUp;
        bool movingDown;
        string facing;


        public GameEntity()
        {

        }
        // getters and setters for variables
        public float XPos { get => xPos; set => xPos = value; }
        public float YPos { get => yPos; set => yPos = value; }
        public double Speed { get => speed; set => speed = value; }
        public int Health { get => health; set => health = value; }
        public bool IsOnScreen { get => isOnScreen; set => isOnScreen = value; }
        public bool IsDead { get => isDead; set => isDead = value; }
        public bool MovingLeft { get => movingLeft; set => movingLeft = value; }
        public bool MovingRight { get => movingRight; set => movingRight = value; }
        public bool MovingUp { get => movingUp; set => movingUp = value; }
        public bool MovingDown { get => movingDown; set => movingDown = value; }
        public string Facing { get => facing; set => facing = value; }
    }

}
