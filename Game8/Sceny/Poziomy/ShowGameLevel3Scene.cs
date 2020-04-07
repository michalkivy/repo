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
    class ShowGameLevel3Scene : ShowGameScene
    {
        public ShowGameLevel3Scene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaScenyPoziomow = new FlagaScenyPoziomow(EnumFlagaSceny.ShowGameLevel3Scene);
            flagaScenyPoziomow.IsShowGameLevel3Scene = true;

            background.UstawTlo(ref Texture.ShowGameLevel3Scene);
            //GameState.FlagiScenyPoziomow[2].IsShowGameLevel3Scene = true;
            PunktyPoziomu = Poziomy.ShowGameLevel3ScenePunktyMax;
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