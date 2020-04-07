using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Diagnostics;

namespace Game8
{
    class ObiektSpadajacy : Obiekt
    {
        
        public Random randX = new Random();
        public Random randY = new Random();

        public ObiektSpadajacy()
        {
            //
        }

        public ObiektSpadajacy(ref Texture2D texture)
        {
            //
        }
        

        override public void Draw(SpriteBatch spriteBatch)
        {
            rectObiekt = new Rectangle((int)position.X, (int)position.Y, obrazek.Width, obrazek.Height);
            spriteBatch.Draw(obrazek, rectObiekt, Color.White);
        }

        override public void Update(ref GameTime gametime) //Move
        {
            double deltaTime = gametime.ElapsedGameTime.TotalSeconds;
            position.X += (float)(predkoscX * deltaTime);
            position.Y += (float)(predkoscY * deltaTime);
        }

        override public bool Collider(ObiektSpadajacy gracz)
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
        override public bool ColliderEkran()
        {
            if (rectObiekt.Intersects(Ekran.rectEkran))
            {
                return true;
            }
            return false;
        }


    }
}
