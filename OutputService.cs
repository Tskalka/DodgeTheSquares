using System;
using System.Collections.Generic;
using Raylib_cs;


namespace RayLibPractice
{
    // anything drawn to the screen
    class OutputService
    {
        private Raylib_cs.Color _backgroundColor = Raylib_cs.Color.LIGHTGRAY;

        public void OpenWindow(int height, int width, string title, int frameRate)
        {
            Raylib.InitWindow(height, width, title);
            Raylib.SetTargetFPS(frameRate);

        }

        public void StartDrawing()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(_backgroundColor);
        }
        
        public void DrawBox(int x, int y, int width, int height, Raylib_cs.Color color)
        {
            Raylib.DrawRectangle(x, y, width, height, color);
        }

        public void DrawText(int x, int y, string text, bool darkText)
        {
            Raylib_cs.Color color = Raylib_cs.Color.WHITE;

            if (darkText)
            {
                color = Raylib_cs.Color.BLACK;
            }

            Raylib.DrawText(text,x,y,Constants.DEFAULT_TEXT_SIZE,color);
        }


        public void DrawActor(Actor actor)
        {

            int width = actor._width;
            int height = actor._height;
            int x = actor._position._x;
            int y = actor._position._y;
            Raylib_cs.Color color = actor._boxColor;
            
            bool darkText = true;
            if (actor.IsBox())
            {
                DrawBox(x, y, width, height,color);
            }

            if (actor.IsText())
            {
                string text = actor._text;
                DrawText(x,y,text,darkText);
            }

        }

        public void DrawActors(List<Actor> actors)
        {
            foreach (Actor actor in actors)
            {
                DrawActor(actor);
            }
        }

        public void EndDrawing()
        {
            Raylib.EndDrawing();
        }
        
    }
}
