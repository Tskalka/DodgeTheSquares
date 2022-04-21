using System;
using System.Collections.Generic;
using Raylib_cs;


namespace RayLibPractice
{
    class Enemy: Actor
    {      
        public Enemy()
        {

            _boxColor = Raylib_cs.Color.BLACK;

            Random randNum = new Random();
            int x = Constants.MAX_X;
            int y = randNum.Next(40, Constants.MAX_Y - 40);
            _position = new Point(x, y);

            int dx = randNum.Next(2,5);
            _velocity = new Point(-dx, 0);
            _velocity._x *= Constants.ENEMY_SPEED;
        }

        public override void UpdateActor()
        {
            base.UpdateActor();
            Random randNum = new Random();
            int x = Constants.MAX_X;
            int y = randNum.Next(40, Constants.MAX_Y - 40);
            _position = new Point(x, y);

            int dx = randNum.Next(2,5);
            _velocity = new Point(-dx, 0);
            _velocity._x *= Constants.ENEMY_SPEED;
        
        }

        public void HardMode()
        {
            Random randNum = new Random();
            int dx = randNum.Next(5,8);
            _velocity = new Point(-dx, 0);
            _velocity._x *= Constants.ENEMY_SPEED;
        }


    }
}
