using System;
using System.Collections.Generic;
using Raylib_cs;


namespace RayLibPractice
{
    // parent class so be sure to use protected member variables.
    // They can be accesed by the children
    class Actor
    {       
        // should I have these as public and specify their specific protection level in get, set?
        public Point _velocity{get; set;}
        public Point _position{get; set;}

        public int _width{get; protected set;} = Constants.DEFAULT_SQUARE_SIZE;
        public int _height{get; protected set;} = Constants.DEFAULT_SQUARE_SIZE;

        public string _text{get; set;} = "";

        public Raylib_cs.Color _boxColor{get; protected set;} = Raylib_cs.Color.GRAY;

        public bool IsBox()
        {
            return _width > 0  && _height > 0;
        }

        public bool IsText()
        {
            return _text != "";
        }

        public void MoveNext()
        {
            int x = _position._x;
            int y = _position._y;

            int dx = _velocity._x;
            int dy = _velocity._y;

            int newX = (x + dx);
            int newY = (y + dy);

            _position = new Point(newX, newY);
        }

        public bool IsOffScreen()
        {
            return _position._x <= -10;
        }

        public virtual void UpdateActor()
        {
            int x = 0;
            int y = 0;

            Point position = new Point(x,y);
            _position = position;
        }

    }
}
