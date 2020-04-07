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
    class ShowGameLevel4Scene : ShowGameScene
    {
        public ShowGameLevel4Scene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaScenyPoziomow = new FlagaScenyPoziomow(EnumFlagaSceny.ShowGameLevel4Scene);
            flagaScenyPoziomow.IsShowGameLevel4Scene = true;

            background.UstawTlo(ref Texture.ShowGameLevel4Scene);
            //GameState.FlagiScenyPoziomow[3].IsShowGameLevel4Scene = true;
            PunktyPoziomu = Poziomy.ShowGameLevel4ScenePunktyMax;
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