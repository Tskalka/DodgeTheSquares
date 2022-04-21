using System;
using System.Collections.Generic;
using Raylib_cs;


namespace RayLibPractice
{
    class InputService
    {       

        public bool IsWindowClosing()
        {
            return Raylib.WindowShouldClose();
        }

        public bool IsLeftKeyPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_LEFT) || Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_A);
        }
        public bool IsRightKeyPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_RIGHT) || Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_D);
        }
        public bool IsUpKeyPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_UP) || Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_W);
        }
        public bool IsDownKeyPressed()
        {
            return Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_DOWN) || Raylib.IsKeyDown(Raylib_cs.KeyboardKey.KEY_S);
        }


        public Point GetDirection()
        {
            int x = 0;
            int y = 0;
            if(IsLeftKeyPressed())
            {
                x = -3;
            }
            if(IsRightKeyPressed())
            {
                x = 3;
            }
            if(IsUpKeyPressed())
            {
                y = -3;
            }
            if(IsDownKeyPressed())
            {
                y = 3;
            }

            return new Point (x,y);
        }



    }
}
