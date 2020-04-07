using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game8
{
    class Texture : DrawableGameComponent
    {
        //Statyczne zmienne texture
        public static Texture2D TexturaObiektu;
        public static Texture2D TexturaPrzedmiotu1;
        public static Texture2D TexturaPrzeciwnik;
        public static Texture2D _TexturaPocisk;
        public static Texture2D _TexturaGracz;

        public static Texture2D characterSheetTexture;
        public static Texture2D characterSheetTexture2;

        public Texture2D TexturaGracz
        {
            get { return _TexturaGracz; }
            set
            {
                _TexturaGracz = value;
            }
        }
        public Texture2D TexturaPocisk
        {
            get { return _TexturaPocisk; }
            set
            {
                _TexturaPocisk = value;
            }
        }

        public static Texture2D ShowGameLevel1Scene;
        public static Texture2D ShowGameLevel2Scene;
        public static Texture2D ShowGameLevel3Scene;
        public static Texture2D ShowGameLevel4Scene;
        public static Texture2D ShowGameLevel5Scene;
        public static Texture2D ShowGameLevel6Scene;
        public static Texture2D ShowGameLevel7Scene;
        public static Texture2D ShowGameMainMenuScene;
        public static Texture2D ShowGameOverScene;

        public static Texture2D Button; // Podstawowa Textura Przycisku
        public static Texture2D Play;
        public static Texture2D Next;
        public static Texture2D Back;
        public static Texture2D Exit;
        public static Texture2D Opcje;
        public static Texture2D Return;
        public static Texture2D Start;
        public static Texture2D Menu;

        public Texture(Game game): base(game)
        {
            //
        }
        public void LoadContentTexturyScen()
        {
            //Ladowanie plikow z Assets / dostep na Adnroidach
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameLevel1Scene.jpg"))
            {
                ShowGameLevel1Scene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameLevel2Scene.jpg"))
            {
                ShowGameLevel2Scene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameLevel3Scene.jpg"))
            {
                ShowGameLevel3Scene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameLevel4Scene.jpg"))
            {
                ShowGameLevel4Scene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameLevel5Scene.jpg"))
            {
                ShowGameLevel5Scene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameLevel6Scene.jpg"))
            {
                ShowGameLevel6Scene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameLevel7Scene.jpg"))
            {
                ShowGameLevel7Scene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameMainMenuScene.jpg"))
            {
                ShowGameMainMenuScene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyScen/ShowGameOverScene.jpg"))
            {
                ShowGameOverScene = Texture2D.FromStream(this.GraphicsDevice, stream);
            }


            /* Mobile Phone Windows
            Game.Content.RootDirectory = "Content/TexturyScen";
            ShowGameLevel1Scene = Game.Content.Load<Texture2D>("ShowGameLevel1Scene");
            ShowGameLevel2Scene = Game.Content.Load<Texture2D>("ShowGameLevel2Scene");
            ShowGameLevel3Scene = Game.Content.Load<Texture2D>("ShowGameLevel3Scene");
            ShowGameLevel4Scene = Game.Content.Load<Texture2D>("ShowGameLevel4Scene");
            ShowGameLevel5Scene = Game.Content.Load<Texture2D>("ShowGameLevel5Scene");
            ShowGameLevel6Scene = Game.Content.Load<Texture2D>("ShowGameLevel6Scene");
            ShowGameLevel7Scene = Game.Content.Load<Texture2D>("ShowGameLevel7Scene");
            ShowGameMainMenuScene = Game.Content.Load<Texture2D>("ShowGameMainMenuScene");
            ShowGameOverScene = Game.Content.Load<Texture2D>("ShowGameOverScene");
            Game.Content.RootDirectory = "Content";*/
        }

        public void LoadContentTexturyPrzyciskow()
        {

            using (var stream = TitleContainer.OpenStream("TexturyPrzyciskow/Button.png"))
            {
                Button = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyPrzyciskow/Next.png"))
            {
                Next = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyPrzyciskow/Back.png"))
            {
                Back = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyPrzyciskow/Exit.png"))
            {
                Exit = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyPrzyciskow/Opcje.png"))
            {
                Opcje = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyPrzyciskow/Return.png"))
            {
                Return = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyPrzyciskow/Start.png"))
            {
                Start = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TexturyPrzyciskow/Menu.png"))
            {
                Menu = Texture2D.FromStream(this.GraphicsDevice, stream);
            }

            /*
            Game.Content.RootDirectory = "Content/TexturyPrzyciskow";
            Button = Game.Content.Load<Texture2D>("Button"); // Podstawowa Textura Przycisku
            Next = Game.Content.Load<Texture2D>("Next");
            Back = Game.Content.Load<Texture2D>("Back");
            Exit = Game.Content.Load<Texture2D>("Exit");
            Opcje = Game.Content.Load<Texture2D>("Opcje");
            Return = Game.Content.Load<Texture2D>("Return");
            Start = Game.Content.Load<Texture2D>("Start");
            Menu = Game.Content.Load<Texture2D>("Menu");
            Game.Content.RootDirectory = "Content";*/
        }
        public void LoadContentTexturyFonts()
        {
            Game.Content.RootDirectory = "Content/Fonts";
            Font.FontArial = Game.Content.Load<SpriteFont>("Font");
            Game.Content.RootDirectory = "Content";
        }
        public void LoadContentTexturyObiektow()
        {
            // Sprawdz czy plik istnieje i czy jest do niego dostep. z Assets/
            //using (var stream = TitleContainer.OpenStream("TextutyObiektow/charactersheet.png"))
            //{
            //    characterSheetTexture = Texture2D.FromStream(this.GraphicsDevice, stream);
            //}
            //using (var stream = TitleContainer.OpenStream("TextutyObiektow/charactersheet2.png"))
            //{
            //    characterSheetTexture2 = Texture2D.FromStream(this.GraphicsDevice, stream);
            //}
            //using (var stream = TitleContainer.OpenStream("TextutyObiektow/TexturaGracz.png"))
            //{
            //    TexturaGracz = Texture2D.FromStream(this.GraphicsDevice, stream);
            //}
            using (var stream = TitleContainer.OpenStream("TextutyObiektow/TexturaObiektu.png"))
            {
                TexturaObiektu = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TextutyObiektow/TexturaPrzedmiotu1.jpg"))
            {
                TexturaPrzedmiotu1 = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TextutyObiektow/TexturaPrzeciwnik.png"))
            {
                TexturaPrzeciwnik = Texture2D.FromStream(this.GraphicsDevice, stream);
            }
            using (var stream = TitleContainer.OpenStream("TextutyObiektow/TexturaPocisk.png"))
            {
                TexturaPocisk = Texture2D.FromStream(this.GraphicsDevice, stream);
            }

            //Gdyby trzeba bylo to w Content utworz katalog TexturyObiektow taki jak w Assets
            //Game.Content.RootDirectory = "Content/TextutyObiektow";
            //TexturaGracz = Game.Content.Load<Texture2D>("TexturaGracz");
            //TexturaObiektu = Game.Content.Load<Texture2D>("TexturaObiektu");
            //TexturaPrzedmiotu1 = Game.Content.Load<Texture2D>("TexturaPrzedmiotu1");
            //TexturaPrzeciwnik = Game.Content.Load<Texture2D>("TexturaPrzeciwnik");
            //TexturaPocisk = Game.Content.Load<Texture2D>("TexturaPocisk");
            //TexturaGracz = Game.Content.Load<Texture2D>("TexturaGracz");
            //Game.Content.RootDirectory = "Content";
        }

    }
}