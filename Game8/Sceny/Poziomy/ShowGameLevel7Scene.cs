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
    class ShowGameLevel7Scene : ShowGameScene
    {

        public ShowGameLevel7Scene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaScenyPoziomow = new FlagaScenyPoziomow(EnumFlagaSceny.ShowGameLevel7Scene);
            flagaScenyPoziomow.IsShowGameLevel7Scene = true;

            background.UstawTlo(ref Texture.ShowGameLevel7Scene);

            PunktyPoziomu = Poziomy.ShowGameLevel7ScenePunktyMax;
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