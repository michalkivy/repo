
using Game8.Flagi;
using Game8.Sceny;
using System.Collections.Generic;
using System.Diagnostics;

namespace Game8
{
    class Flaga : GameState
    {
        public string nazwa;
        public bool aktywna;
        public EnumFlagaSceny nazwaEnumSceny;

        public static bool _IsFlaga { get; set; }                   //0
        public static bool _IsShowGameMainMenuScene { get; set; }   //1
        public static bool _IsShowGameScene { get; set; }           //2
        public static bool _IsShowGameLevel1Scene { get; set; }     //3
        public static bool _IsShowGameLevel2Scene { get; set; }     //4 
        public static bool _IsShowGameLevel3Scene { get; set; }     //5
        public static bool _IsShowGameLevel4Scene { get; set; }     //6
        public static bool _IsShowGameLevel5Scene { get; set; }     //7
        public static bool _IsShowGameLevel6Scene { get; set; }     //8
        public static bool _IsShowGameLevel7Scene { get; set; }     //9
        public static bool _IsShowGameOverScene { get; set; }       //10
        public static bool _IsShowOpisScene { get; set; }           //11
        public static bool _IsShowWynikiScene { get; set; }         //12
        public static bool _IsShowGameInterfejsScene { get; set; }  //13

        public Flaga()
        {
            //nazwa = "Flaga";
            //aktywna = false;
        }

        public Flaga(EnumFlagaSceny nazwaFlagi)
        {
            //nazwa = nazwaFlagi;
            //aktywna = false;
        }

        public bool IsFlaga
        {
            get { return _IsFlaga; }
            set
            {
                if (value == true)
                {
                    Flaga._IsFlaga = value;
                    Scena._IsScenaPoziomy = false;
                    Scena._IsScenaGry = false;
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
                    _IsShowWynikiScene = false;
                    _IsShowGameInterfejsScene = false;
                }
            }
        }

        public void SetTrue(FlagaSceny Flaga)
        {
            SprawdzIUstawFlageNaTrue(Flaga.nazwaEnumSceny);
        }
        public void SetTrue(FlagaScenyPoziomow Flaga)
        {
            SprawdzIUstawFlageNaTrue(Flaga.nazwaEnumSceny);
        }
        new public string ToString()
        {
            return nazwa;
        }

        static public void SprawdzIUstawFlageNaTrue(EnumFlagaSceny flagaScenyPoziomow)
        {
            switch (flagaScenyPoziomow)
            {
                case EnumFlagaSceny.ShowGameLevel1Scene:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.ShowGameLevel1Scene)].GetFlagaScenyPoziomow().IsShowGameLevel1Scene = true;
                    break;
                case EnumFlagaSceny.ShowGameLevel2Scene:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.ShowGameLevel2Scene)].GetFlagaScenyPoziomow().IsShowGameLevel2Scene = true; break;
                case EnumFlagaSceny.ShowGameLevel3Scene:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.ShowGameLevel3Scene)].GetFlagaScenyPoziomow().IsShowGameLevel3Scene = true;
                    break;
                case EnumFlagaSceny.ShowGameLevel4Scene:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.ShowGameLevel4Scene)].GetFlagaScenyPoziomow().IsShowGameLevel4Scene = true; ;
                    break;
                case EnumFlagaSceny.ShowGameLevel5Scene:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.ShowGameLevel5Scene)].GetFlagaScenyPoziomow().IsShowGameLevel5Scene = true;
                    break;
                case EnumFlagaSceny.ShowGameLevel6Scene:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.ShowGameLevel6Scene)].GetFlagaScenyPoziomow().IsShowGameLevel6Scene = true;
                    break;
                case EnumFlagaSceny.ShowGameLevel7Scene:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.ShowGameLevel7Scene)].GetFlagaScenyPoziomow().IsShowGameLevel7Scene = true;
                    break;
                case EnumFlagaSceny.ShowGameInterfejsScene:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.ShowGameInterfejsScene)].GetFlagaScenyPoziomow().IsShowGameInterfejsScene = true;
                    break;
                case EnumFlagaSceny.Flaga:
                    Scena.ScenyPoziomow[FindFlaga(EnumFlagaSceny.Flaga)].GetFlagaScenyPoziomow().IsFlaga = true;
                    break;
                case EnumFlagaSceny.ShowGameMainMenuScene:
                    Scena.Sceny[FindFlaga(EnumFlagaSceny.ShowGameMainMenuScene)].GetFlagaSceny().IsShowGameMainMenuScene = true;
                    break;
                case EnumFlagaSceny.ShowGameOverScene:
                    Scena.Sceny[FindFlaga(EnumFlagaSceny.ShowGameOverScene)].GetFlagaSceny().IsShowGameOverScene = true;
                    break;
                case EnumFlagaSceny.ShowGameScene:
                    Scena.Sceny[FindFlaga(EnumFlagaSceny.ShowGameScene)].GetFlagaSceny().IsShowGameScene = true;
                    break;
                case EnumFlagaSceny.ShowOpisScene:
                    Scena.Sceny[FindFlaga(EnumFlagaSceny.ShowOpisScene)].GetFlagaSceny().IsShowOpisScene = true;
                    break;
                case EnumFlagaSceny.ShowWynikiScene:
                    Scena.Sceny[FindFlaga(EnumFlagaSceny.ShowWynikiScene)].GetFlagaSceny().IsShowWynikiScene = true;
                    break;
                default:
                    Debug.WriteLine("Nie ma takiej nazwy flagi");
                    break;
            }
        }

    }
}
