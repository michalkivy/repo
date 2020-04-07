
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Diagnostics;

namespace Game8
{
    class PrzyciskiGameOver : PrzyciskiScen
    {
        public Przycisk PrzyciskStart;
        public Przycisk PrzyciskMenu;
        public Przycisk PrzyciskOpcje;
        public Przycisk PrzyciskReturn;
        public Przycisk PrzyciskExit;

        

        public PrzyciskiGameOver()
        {
            //nazwaMenuPrzyciskow = NazwaMenuPrzyciskowEnum.PrzyciskiGameOver;
            //nazwaManuPrzyciskowS = NazwaMenuPrzyciskowEnum.PrzyciskiGameOver.ToString();
        }

        public PrzyciskiGameOver(Vector2 miejsceMenu, NazwaMenuPrzyciskowEnum nazwaEnumMenu)
        {
            nazwaMenuPrzyciskow = NazwaMenuPrzyciskowEnum.PrzyciskiGameOver;
            nazwaManuPrzyciskowS = NazwaMenuPrzyciskowEnum.PrzyciskiGameOver.ToString();

            positionMenu = miejsceMenu;

            PrzyciskStart = new Przycisk(new Vector2(Ekran.SzerEkranu/2, Ekran.WysEkranu / 2 - Texture.Start.Height*3 -5), ref Texture.Start, NazwaPrzyciskuEnum.Start, nazwaMenuPrzyciskow);
            PrzyciskMenu = new Przycisk(new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2 - Texture.Opcje.Height*2 - 5), ref Texture.Menu, NazwaPrzyciskuEnum.Menu, nazwaMenuPrzyciskow);
            PrzyciskOpcje = new Przycisk(new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2 - Texture.Opcje.Height - 5), ref Texture.Opcje, NazwaPrzyciskuEnum.Opcje, nazwaMenuPrzyciskow);
            PrzyciskReturn = new Przycisk(new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2 - 5), ref Texture.Return, NazwaPrzyciskuEnum.Return, nazwaMenuPrzyciskow);
            PrzyciskExit = new Przycisk(new Vector2(Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2 + Texture.Exit.Height), ref Texture.Exit, NazwaPrzyciskuEnum.Exit, nazwaMenuPrzyciskow);

            PrzyciskiGameOver.Add(PrzyciskStart);
            PrzyciskiGameOver.Add(PrzyciskMenu);
            PrzyciskiGameOver.Add(PrzyciskOpcje);
            PrzyciskiGameOver.Add(PrzyciskReturn);
            PrzyciskiGameOver.Add(PrzyciskExit);

        }

        public override void Update(ref GameTime gameTime)
        {
            for (int i = 0; i < PrzyciskiGameOver.Count; i++)
            {
                PrzyciskiGameOver[i].Update(ref gameTime);
            }
                //PrzyciskStart.Update(ref deltaTime);
            //PrzyciskOpcje.Update(ref deltaTime);
            //PrzyciskReturn.Update(ref deltaTime);
            //PrzyciskExit.Update(ref deltaTime);
            //base.Update(ref deltaTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < PrzyciskiGameOver.Count; i++)
            {
                PrzyciskiGameOver[i].Draw(spriteBatch);
            }
        }


    }
}