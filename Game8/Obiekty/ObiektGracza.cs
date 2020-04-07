using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace Game8
{
    class ObiektGracza : Obiekt
    {
        public string nazna;
        public int X { get; set; }
        public int Y { get; set; }

        public int Width { get; set; }  // trzeba przypisac 
        public int Height { get; set; } // trzeba przypisac 

        public int predkoscX { get; set; }
        public int predkoscY { get; set; }

        public Texture2D obrazek { get; set; }
        public Vector2 position; //pozycja obiektu

        public Rectangle rectObiekt { get; set; }

        public ObiektGracza()
        {


        }

    }
}