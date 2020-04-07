
using Game8.Flagi;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Diagnostics;

namespace Game8.Sceny
{

    class Scena 
    {
        public static int IndexSzukanejSceny { get; set; }
        public static int IndexSzukanejScenyPoziomy { get; set; }

        public static List<Scena> Sceny = new List<Scena> { }; // wszystkie sceny, każda ma status oraz nazwę
        public static List<Scena> ScenyPoziomow = new List<Scena> { }; // wszystkie sceny poziomow

        public static bool _IsScenaGry { get; set; }
        public static bool _IsScenaPoziomy { get; set; }

        public static bool IsScenaGry       { get { return _IsScenaGry; }       set { if (value == true) _IsScenaGry = value; _IsScenaPoziomy = false;  } }
        public static bool IsScenaPoziomy   { get { return _IsScenaPoziomy; }   set { if (value == true) _IsScenaGry = false; _IsScenaPoziomy = value; } }

        public string nazwa;
        public bool Active;

        public int PunktyPoziomu;

        public Background background;

        public FlagaSceny flagaSceny ;
        public FlagaScenyPoziomow flagaScenyPoziomow;

        public Scena(GraphicsDevice graphicsDevice)
        {   /*
            flagaSneny = new Flaga("Flaga");
            flagaSneny.IsFlaga = true;
            FlagiSceny.Add(flagaSneny);
            EnumFlaga = EnumFlagaSceny.Flaga;
            EnumFlagiSceny.Add(EnumFlaga);

            IsScenaGry = false;
            IsScenaPoziomy = false;
            Active = false;*/
            background = new Background();
        }
        public virtual void Update(ref GameTime gameTime)
        {

        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch);
        }
        public string GetNameSceny()
        {
            return nazwa;
        }
        public bool GetActive()
        {
            return Active;
        }
        public int GetPunktySceny()
        {
            return PunktyPoziomu;
        }
        public FlagaSceny GetFlagaSceny()
        {
            return flagaSceny;
        }
        public FlagaScenyPoziomow GetFlagaScenyPoziomow()
        {
            return flagaScenyPoziomow;
        }
        public Flaga GetFlaga()
        {
            if (IsScenaGry == true)
            {
                return flagaSceny;
            }
            else
            {
                return flagaScenyPoziomow;
            }
        }

        public string getShowScene()
        {
            if (Flaga._IsShowGameMainMenuScene)
            {
                Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowGameMainMenuScene)].GetFlagaSceny().IsShowGameMainMenuScene = true;
                return Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowGameMainMenuScene)].nazwa;
            }
            if (Flaga._IsShowGameScene)
            {
                Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowGameScene)].GetFlagaSceny().IsShowGameScene = true;
                return Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowGameScene)].nazwa;
            }
            if (Flaga._IsShowGameLevel1Scene)
            {
                Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel1Scene)].GetFlagaScenyPoziomow().IsShowGameLevel1Scene = true;
                return Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel1Scene)].nazwa;
            }
            if (Flaga._IsShowGameLevel2Scene)
            {
                Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel2Scene)].GetFlagaScenyPoziomow().IsShowGameLevel2Scene = true;
                return Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel2Scene)].nazwa;
            }
            if (Flaga._IsShowGameLevel3Scene)
            {
                Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel3Scene)].GetFlagaScenyPoziomow().IsShowGameLevel3Scene = true;
                return Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel3Scene)].nazwa;
            }
            if (Flaga._IsShowGameLevel4Scene)
            {
                Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel4Scene)].GetFlagaScenyPoziomow().IsShowGameLevel4Scene = true;
                return Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel4Scene)].nazwa;
            }
            if (Flaga._IsShowGameLevel5Scene)
            {
                Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel5Scene)].GetFlagaScenyPoziomow().IsShowGameLevel5Scene = true;
                return Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel5Scene)].nazwa;
            }
            if (Flaga._IsShowGameLevel6Scene)
            {
                Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel6Scene)].GetFlagaScenyPoziomow().IsShowGameLevel6Scene = true;
                return Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel6Scene)].nazwa;
            }
            if (Flaga._IsShowGameLevel7Scene)
            {
                Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel7Scene)].GetFlagaScenyPoziomow().IsShowGameLevel7Scene = true;
                return Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameLevel7Scene)].nazwa;
            }
            if (Flaga._IsShowGameOverScene)
            {
                Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowGameOverScene)].GetFlagaSceny().IsShowGameOverScene = true;
                return Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowGameOverScene)].nazwa;
            }
            if (Flaga._IsShowOpisScene)
            {
                Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowOpisScene)].GetFlagaSceny().IsShowOpisScene = true;
                return Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowOpisScene)].nazwa;
            }
            if (Flaga._IsShowWynikiScene)
            {
                Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowWynikiScene)].GetFlagaSceny().IsShowWynikiScene = true;
                return Scena.Sceny[GameState.FindFlaga(EnumFlagaSceny.ShowWynikiScene)].nazwa;
            }
            if (Flaga._IsShowGameInterfejsScene)
            {
                Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameInterfejsScene)].GetFlagaScenyPoziomow().IsShowGameInterfejsScene = true;
                return Scena.ScenyPoziomow[GameState.FindFlaga(EnumFlagaSceny.ShowGameInterfejsScene)].nazwa;
            }
            return "brak";
        }


        //public EnumFlagaSceny GetEnumFlaga()
        //{
        //    if(IsScenaGry == true)
        //    {
        //         return flagaSceny.nazwaEnumSceny;
        //    }
        //     else 
        //     {
        //        return flagaScenyPoziomow.nazwaEnumSceny;
        //     }
        //     // złapiemy flake _blank i zrobimy cos dalej...
        // }
    }
}