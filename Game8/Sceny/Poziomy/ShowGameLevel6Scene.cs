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
    class ShowGameLevel6Scene : ShowGameScene
    {

        public ShowGameLevel6Scene(GraphicsDevice graphicsDevice) :base(graphicsDevice)
        {
            flagaScenyPoziomow = new FlagaScenyPoziomow(EnumFlagaSceny.ShowGameLevel6Scene);
            flagaScenyPoziomow.IsShowGameLevel6Scene = true;

            background.UstawTlo(ref Texture.ShowGameLevel6Scene);
            //GameState.FlagiScenyPoziomow[5].IsShowGameLevel6Scene = true;
            PunktyPoziomu = Poziomy.ShowGameLevel6ScenePunktyMax;
            nazwa = flagaScenyPoziomow.nazwa;
            Active = false;
        }
        override public void Update(ref GameTime gameTime)
        {
            base.Update(ref gameTime);


            //pozostałe akcje
        }

    }


}