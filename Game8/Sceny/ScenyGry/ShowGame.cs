using System;
using System.Diagnostics;
using Game8.Flagi;
using Microsoft.Xna.Framework; //ostatnie
using Microsoft.Xna.Framework.Graphics;

namespace Game8.Sceny
{
    class ShowGame : Scena
    {
        public ShowGame(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            /*
            flagaSceny = new FlagaSceny("ShowGame");
            FlagiSceny.Add(flagaSceny);
            EnumFlaga = EnumFlagaSceny.ShowGame;
            EnumFlagiSceny.Add(EnumFlaga);
            */
            IsScenaGry = true;
            /*
            Name = flagaSceny.nazwa;
            Active = false;
            MenuPrzyciski.PrzyciskStart = new Przycisk(ref Texture.PrzyciskStart, Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2, "Start");
            */
            background.UstawTlo(ref Texture.ShowGameMainMenuScene);
        }

        override public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Font.FontArial, "GRA", new Vector2(Ekran.SzerEkranu / 2, 123), Color.White);
            //MenuPrzyciski.PrzyciskStart.Draw();
        }

        override public void Update(ref GameTime gameTime)
        {
            //MenuPrzyciski.PrzyciskStart.Update(ref deltaTime);
        }



    }
}