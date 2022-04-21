using System;
using System.Collections.Generic;
using Raylib_cs;


namespace RayLibPractice
{
    class Player : Actor
    {       
        public int _lives{get; set;} = 5;
        public Player()
        {
            int x = Constants.MAX_X /2;
            int y = Constants.MAX_Y /2;

            Point position = new Point(x,y);
            _position = position;
            _boxColor = Raylib_cs.Color.SKYBLUE;

        }

        public override void UpdateActor()
        {
            base.UpdateActor();
            int x = Constants.MAX_X /2;
            int y = Constants.MAX_Y /2;

            Point position = new Point(x,y);
            _position = position;
            
        }

        public void LoseLife()
        {
            _lives--;
        }

    }
}
