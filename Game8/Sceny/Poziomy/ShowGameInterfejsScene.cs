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
    class ShowGameInterfejsScene : ShowGameScene
    {
        public String PktZycia;
        public String PktGracza;

        public ShowGameInterfejsScene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaScenyPoziomow = new FlagaScenyPoziomow(EnumFlagaSceny.ShowGameInterfejsScene);
            flagaScenyPoziomow.IsShowGameInterfejsScene = true;
            
            IsScenaPoziomy = true;

            nazwa = flagaScenyPoziomow.nazwa;
            Active = false;
            PktZycia = "Punkty Zycia: ";
            PktGracza = "Punkty gracza: ";

        }

        override public void Update(ref GameTime gameTime)
        {
            //aktualizacja napisow zycia punktow itp
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.DrawString(Font.FontArial,  "IndexSzukanejSceny " + Scena.IndexSzukanejSceny.ToString(), new Vector2(200, 60), Color.White);
            //spriteBatch.DrawString(Font.FontArial, "Scena.IsScenaGry: " + Scena.IsScenaGry, new Vector2(200, 200), Color.White);
            //spriteBatch.DrawString(Font.FontArial, "Scena.IsScenaPoziomy: " + Scena.IsScenaPoziomy, new Vector2(200, 230), Color.White);
            //spriteBatch.DrawString(Font.FontArial, "IndexSzukanejSceny " + Scena.IndexSzukanejSceny, new Vector2(200, 260), Color.White);
            //spriteBatch.DrawString(Font.FontArial, "IndexSzukanejScenyPoziomy " + Scena.IndexSzukanejScenyPoziomy, new Vector2(200, 300), Color.White);



            spriteBatch.DrawString(Font.FontArial, PktZycia + gracz.PktZycia.ToString(), new Vector2(20, 20), Color.White);
            spriteBatch.DrawString(Font.FontArial, PktGracza + gracz.PunktyGracza.ToString(), new Vector2(Ekran.SzerEkranu-400, 20), Color.White);
            //aktualizacja napisow zycia punktow itp
        }

    }


}