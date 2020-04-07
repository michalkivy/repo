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
    class ShowGameLevel2Scene : ShowGameScene
    {

        public ShowGameLevel2Scene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaScenyPoziomow = new FlagaScenyPoziomow(EnumFlagaSceny.ShowGameLevel2Scene);
            flagaScenyPoziomow.IsShowGameLevel2Scene = true;

            background.UstawTlo(ref Texture.ShowGameLevel2Scene);
            //GameState.FlagiScenyPoziomow[1].IsShowGameLevel2Scene = true;
            PunktyPoziomu = Poziomy.ShowGameLevel2ScenePunktyMax;
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