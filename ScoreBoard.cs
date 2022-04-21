using System;
using System.Collections.Generic;
using Raylib_cs;


namespace RayLibPractice
{
    class ScoreBoard : Actor
    {       
        public int _score{get;set;} = 0;

        public ScoreBoard()
        {
            int x = 10;
            int y = 0;
            _width = 0;
            _height = 0;
            _position = new Point(x,y);

            _text = $"Score: {_score} Lives: 5";
        }

        
    }
}
