using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Game8.Sceny;

namespace Game8.Flagi
{
    class FlagaSceny : Flaga
    {
        public bool IsShowGameMainMenuScene
        {
            get { return _IsShowGameMainMenuScene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = false;
                    Scena._IsScenaGry = true;
                    _IsShowGameMainMenuScene = value;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = false;
                    _IsShowGameLevel5Scene = false;
                    _IsShowGameLevel6Scene = false;
                    _IsShowGameLevel7Scene = false;
                    _IsShowGameOverScene = false;
                    _IsShowOpisScene = false;
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public bool IsShowGameOverScene
        {
            get { return _IsShowGameOverScene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = false;
                    Scena._IsScenaGry = true;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = false;
                    _IsShowGameLevel5Scene = false;
                    _IsShowGameLevel6Scene = false;
                    _IsShowGameLevel7Scene = false;
                    _IsShowGameOverScene = value;
                    _IsShowOpisScene = false;
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public bool IsShowGameScene
        {
            get { return _IsShowGameScene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = true;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = value;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = false;
                    _IsShowGameLevel5Scene = false;
                    _IsShowGameLevel6Scene = false;
                    _IsShowGameLevel7Scene = false;
                    _IsShowGameOverScene = false;
                    _IsShowOpisScene = false;
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public bool IsShowOpisScene
        {
            get { return _IsShowOpisScene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = false;
                    Scena._IsScenaGry = true;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = false;
                    _IsShowGameLevel5Scene = false;
                    _IsShowGameLevel6Scene = false;
                    _IsShowGameLevel7Scene = false;
                    _IsShowGameOverScene = false;
                    _IsShowOpisScene = value;
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public bool IsShowWynikiScene
        {
            get { return _IsShowWynikiScene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = false;
                    Scena._IsScenaGry = true;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = false;
                    _IsShowGameLevel5Scene = false;
                    _IsShowGameLevel6Scene = false;
                    _IsShowGameLevel7Scene = false;
                    _IsShowGameOverScene = false;
                    _IsShowOpisScene = false;
                    _IsShowWynikiScene = value;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public FlagaSceny()
        {
            //
        }
        public FlagaSceny(EnumFlagaSceny nazwaFlagiEnum)
        {
            nazwaEnumSceny = nazwaFlagiEnum;
            this.nazwa = nazwaFlagiEnum.ToString();
            this.aktywna = false;
            IsFlagiSceny = true;
        }
    }
}