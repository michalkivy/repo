
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Diagnostics;

namespace Game8
{
    class PrzyciskiMenu : PrzyciskiScen
    {
        public Przycisk PrzyciskStart;
        public Przycisk PrzyciskOpcje;
        public Przycisk PrzyciskReturn;
        public Przycisk PrzyciskExit;

        public PrzyciskiMenu()
        {
            //nazwaMenuPrzyciskow = NazwaMenuPrzyciskowEnum.PrzyciskiGameOver;
            //nazwaManuPrzyciskowS = NazwaMenuPrzyciskowEnum.PrzyciskiGameOver.ToString();
        }

        public PrzyciskiMenu(Vector2 miejsceMenu, NazwaMenuPrzyciskowEnum nazwaEnumMenu)
        {
            nazwaMenuPrzyciskow = NazwaMenuPrzyciskowEnum.PrzyciskiMenu;
            nazwaManuPrzyciskowS = NazwaMenuPrzyciskowEnum.PrzyciskiMenu.ToString();

            positionMenu = miejsceMenu;

            PrzyciskStart = new Przycisk(new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2 - Texture.Start.Height * 4 - 5), ref Texture.Start, NazwaPrzyciskuEnum.Start, nazwaMenuPrzyciskow);
            PrzyciskOpcje = new Przycisk(new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2 - Texture.Opcje.Height - 5), ref Texture.Opcje, NazwaPrzyciskuEnum.Opcje, nazwaMenuPrzyciskow);
            PrzyciskReturn = new Przycisk(new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2 - 5), ref Texture.Return, NazwaPrzyciskuEnum.Return, nazwaMenuPrzyciskow);
            PrzyciskExit = new Przycisk(new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2 + Texture.Exit.Height), ref Texture.Exit, NazwaPrzyciskuEnum.Exit, nazwaMenuPrzyciskow);

            PrzyciskiMenu.Add(PrzyciskStart);
            PrzyciskiMenu.Add(PrzyciskOpcje);
            PrzyciskiMenu.Add(PrzyciskReturn);
            PrzyciskiMenu.Add(PrzyciskExit);

        }

        public override void Update(ref GameTime gameTime)
        {
            for (int i = 0; i < PrzyciskiMenu.Count; i++)
            {
                PrzyciskiMenu[i].Update(ref gameTime);
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < PrzyciskiMenu.Count; i++)
            {
                PrzyciskiMenu[i].Draw(spriteBatch);
            }
        }


    }
}