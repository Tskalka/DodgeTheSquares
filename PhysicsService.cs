using System;
using System.Collections.Generic;
using Raylib_cs;


namespace RayLibPractice
{
    class PhysicsService
    {       
        public PhysicsService()
        {

        }

        public bool IsCollision(Actor first, Actor second)
        {
            int x1 = first._position._x;
            int y1 = first._position._y;
            int width1 = first._width;
            int height1 = first._height;

            Raylib_cs.Rectangle rectangle1
                = new Raylib_cs.Rectangle(x1, y1, width1, height1);

            int x2 = second._position._x;
            int y2 = second._position._y;
            int width2 = second._width;
            int height2 = second._height;

            Raylib_cs.Rectangle rectangle2
                = new Raylib_cs.Rectangle(x2, y2, width2, height2);

            return Raylib.CheckCollisionRecs(rectangle1, rectangle2);
        }


    }
}
