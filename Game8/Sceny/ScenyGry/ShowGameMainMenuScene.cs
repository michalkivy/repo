using Game8.Flagi;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Diagnostics;

namespace Game8.Sceny
{
    class ShowGameMainMenuScene : ShowGame
    {
        //public PrzyciskiMenu przyciskiMenu;

        PrzyciskiMenu przyciskiMenu;

        public ShowGameMainMenuScene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaSceny = new FlagaSceny(EnumFlagaSceny.ShowGameMainMenuScene);
            flagaSceny.IsShowGameMainMenuScene = true;

            IsScenaGry = true;

            nazwa = flagaSceny.nazwa;
            Active = false;
            //MenuPrzyciski.PrzyciskStart = new Przycisk(ref Texture.PrzyciskStart, Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2, "Start");
            //przyciskiMenu = new PrzyciskiMenu( new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2),ref Texture.PrzyciskStart, Przycisk.NazwaPrzyciskuEnum.Start);
            background.UstawTlo(ref Texture.ShowGameMainMenuScene);
            przyciskiMenu = new PrzyciskiMenu(new Vector2(Ekran.SzerEkranu, Ekran.WysEkranu), Przycisk.NazwaMenuPrzyciskowEnum.PrzyciskiMenu);
        }

        override public void Draw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch);

            spriteBatch.DrawString(Font.FontArial, "GRA", new Vector2(Ekran.SzerEkranu / 2, 123), Color.White);
            przyciskiMenu.Draw(spriteBatch);
            //MenuPrzyciski.PrzyciskStart.Draw();
            //przyciskiMenu.Draw();
        }

        override public void Update(ref GameTime gameTime)
        {
            przyciskiMenu.Update(ref gameTime);
            //MenuPrzyciski.PrzyciskStart.Update(ref deltaTime);
            //przyciskiMenu.Update(ref deltaTime);
        }
        

    }
}