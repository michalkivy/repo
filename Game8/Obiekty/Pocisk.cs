using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Diagnostics;
using Microsoft.Xna.Framework.Input.Touch;

namespace Game8
{
    class Pocisk : ObiektGracza
    {


        public Pocisk()
        {
            //
        }

        public Pocisk(ref Vector2 pozycjaGracza)
        {
            nazna = "Pocisk";

            obrazek = Texture._TexturaPocisk;

            predkoscX = 0;
            predkoscY = 160;

            Width = obrazek.Width;
            Height = obrazek.Height;

            position = new Vector2(pozycjaGracza.X+100, pozycjaGracza.Y); // przypisanie

            rectObiekt = new Rectangle((int)position.X, (int)position.Y, Width, Height);
        }

        override public void Draw(SpriteBatch spriteBatch)
        {
            rectObiekt = new Rectangle((int)position.X, (int)position.Y, obrazek.Width, obrazek.Height);
            spriteBatch.Draw(obrazek, rectObiekt, Color.White);
        }

        override public void Update(ref GameTime gameTime) //Move
        {
            double deltaTime = gameTime.ElapsedGameTime.TotalSeconds;



            position.X += (float)(predkoscX * deltaTime);
            position.Y -= (float)(predkoscY * deltaTime);

            //TouchCollection touchCollection = TouchPanel.GetState(); //gdzie użytkownik dotyka ekranu. 
            //touch Collection jest 0 gdy uzytkownik nie dotyka ekranu
            //if (touchCollection.Count > 0)
            //{
                //Jeśli użytkownik dotyka ekranu, zmienimy znak w kierunku pierwszego dotknięcia, innymi słowy, TouchLocation pod indeksem 0.Początkowo ustawimy pożądaną prędkość tak, aby była równa różnicy między lokalizacją znaku a pierwszą lokalizacją dotknięcia:
                //Debug.WriteLine("touchCollection[0].State(): " + touchCollection[0].State);


            //}

        }



    }
}