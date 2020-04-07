using Microsoft.Xna.Framework; //ostatnie
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Text;
using Microsoft.Xna.Framework.Input.Touch;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using Game8.Flagi;

namespace Game8.Sceny
{
    class ShowGameOverScene : ShowGame
    {
        PrzyciskiGameOver przyManuGameOver;

        public ShowGameOverScene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaSceny = new FlagaSceny(EnumFlagaSceny.ShowGameOverScene);
            flagaSceny.IsShowGameOverScene = true;

            IsScenaGry = true;
            //GameState.FlagiSceny[3].IsShowGameOverScene = true;
            nazwa = flagaSceny.nazwa;
            Active = true;
            background.UstawTlo(ref Texture.ShowGameOverScene);
            //MenuPrzyciski.PrzyciskStart = new Przycisk(ref Texture.PrzyciskStart, Ekran.SzerEkranu / 2, Ekran.WysEkranu / 2, "Start");
            przyManuGameOver = new PrzyciskiGameOver(new Vector2(100, 100), Przycisk.NazwaMenuPrzyciskowEnum.PrzyciskiGameOver);
        }

        override public void Update(ref GameTime gameTime)
        {
            przyManuGameOver.Update(ref gameTime);
        }


        override public void Draw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch);
            spriteBatch.DrawString(Font.FontArial, "GAME OVER", new Vector2(20, 20), Color.White);
            spriteBatch.DrawString(Font.FontArial, "GAME OVER", new Vector2(Ekran.SzerEkranu - 400, 20), Color.White);
            //MenuPrzyciski.PrzyciskStart.Draw();
            //Debug.WriteLine("Draw ShowGameOverScene");

            przyManuGameOver.Draw(spriteBatch);
        }
    }


}