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
    class ShowGameLevel5Scene : ShowGameScene
    {

        public ShowGameLevel5Scene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaScenyPoziomow = new FlagaScenyPoziomow(EnumFlagaSceny.ShowGameLevel5Scene);
            flagaScenyPoziomow.IsShowGameLevel5Scene = true;

            background.UstawTlo(ref Texture.ShowGameLevel5Scene);
            //GameState.FlagiScenyPoziomow[4].IsShowGameLevel5Scene = true;
            PunktyPoziomu = Poziomy.ShowGameLevel5ScenePunktyMax;
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