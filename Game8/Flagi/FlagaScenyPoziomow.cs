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
    class FlagaScenyPoziomow : Flaga
    {
        public bool IsShowGameLevel1Scene
        {
            get { return _IsShowGameLevel1Scene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = false;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = value;
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

        public bool IsShowGameLevel2Scene
        {
            get { return _IsShowGameLevel2Scene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = false;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = value;
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

        public bool IsShowGameLevel3Scene
        {
            get { return _IsShowGameLevel3Scene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = false;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = value;
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

        public bool IsShowGameLevel4Scene
        {
            get { return _IsShowGameLevel4Scene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = false;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = value;
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

        public bool IsShowGameLevel5Scene
        {
            get { return _IsShowGameLevel5Scene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = false;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = false;
                    _IsShowGameLevel5Scene = value;
                    _IsShowGameLevel6Scene = false;
                    _IsShowGameLevel7Scene = false;
                    _IsShowGameOverScene = false;
                    _IsShowOpisScene = false;
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public bool IsShowGameLevel6Scene
        {
            get { return _IsShowGameLevel6Scene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = false;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = false;
                    _IsShowGameLevel5Scene = false;
                    _IsShowGameLevel6Scene = value;
                    _IsShowGameLevel7Scene = false;
                    _IsShowGameOverScene = false;
                    _IsShowOpisScene = false;
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public bool IsShowGameLevel7Scene
        {
            get { return _IsShowGameLevel7Scene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = false;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = false;
                    _IsShowGameLevel2Scene = false;
                    _IsShowGameLevel3Scene = false;
                    _IsShowGameLevel4Scene = false;
                    _IsShowGameLevel5Scene = false;
                    _IsShowGameLevel6Scene = false;
                    _IsShowGameLevel7Scene = value;
                    _IsShowGameOverScene = false;
                    _IsShowOpisScene = false;
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public bool IsShowGameInterfejsScene
        {
            get { return _IsShowGameInterfejsScene; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = false;
                    Scena._IsScenaPoziomy = true;
                    Scena._IsScenaGry = false;
                    _IsShowGameMainMenuScene = false;
                    _IsShowGameScene = false;
                    _IsShowGameLevel1Scene = true;
                    _IsShowGameLevel2Scene = true;
                    _IsShowGameLevel3Scene = true;
                    _IsShowGameLevel4Scene = true;
                    _IsShowGameLevel5Scene = true;
                    _IsShowGameLevel6Scene = true;
                    _IsShowGameLevel7Scene = true;
                    _IsShowGameOverScene = false;
                    _IsShowOpisScene = false;
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public FlagaScenyPoziomow()
        {
            //
        }
        public FlagaScenyPoziomow(EnumFlagaSceny nazwaFlagiEnum)
        {
            nazwaEnumSceny = nazwaFlagiEnum;
            this.nazwa = nazwaFlagiEnum.ToString();
            this.aktywna = false;
            IsFlagiScenyPoziomow = true;
        }
    }
}