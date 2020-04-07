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
    class ShowGameLevel1Scene : ShowGameScene
    {
        public ShowGameLevel1Scene(GraphicsDevice graphicsDevice) : base(graphicsDevice)
        {
            flagaScenyPoziomow = new FlagaScenyPoziomow(EnumFlagaSceny.ShowGameLevel1Scene);
            flagaScenyPoziomow.IsShowGameLevel1Scene = true;

            background.UstawTlo(ref Texture.ShowGameLevel1Scene);
            //GameState.FlagiScenyPoziomow[0].IsShowGameLevel1Scene = true;
            PunktyPoziomu = Poziomy.ShowGameLevel1ScenePunktyMax;
            
            nazwa = flagaScenyPoziomow.nazwa;
            Active = false;
        }

        override public void Update(ref GameTime gametime)
        {
            base.Update(ref gametime);
            
        }

    }


}