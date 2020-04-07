using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game8
{
    class Obiekt
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

        public Obiekt()
        {
            //
        }

        public Obiekt(ref Texture2D texture)
        {
            //
        }

        public Vector2 GetPosition() // funkcja zwracajaca pozycje worka
        {
            return position;
        }

        public Rectangle GetRect()
        {
            return rectObiekt;
        }

        virtual public void Draw(SpriteBatch spriteBatch)
        {
            //
        }

        virtual public void Update(ref GameTime gametime) //Move
        {
            //
        }

        virtual public bool Collider(ObiektSpadajacy gracz)
        {
            if (rectObiekt.Intersects(gracz.rectObiekt))
            {
                return true;
            }
            return false;
        }

        /// <summary>Class <c>ColliderEkran</c> Sprawdza czy obiekt znajduje się na ekranie
        /// Sprawdza czy obiekt znajduje się na ekranie</summary>
        ///
        virtual public bool ColliderEkran()
        {
            if (rectObiekt.Intersects(Ekran.rectEkran))
            {
                return true;
            }
            return false;
        }


    }
}
