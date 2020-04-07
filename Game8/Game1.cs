using Microsoft.Xna.Framework; //ostatnie
using Microsoft.Xna.Framework.Graphics;
using System.Text;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using Game8.Sceny;
using Game8.Touch;


namespace Game8
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public static int dot;
        public static float delta;

        public Rectangle recPrzyciskStart;
        Texture textury;

        //Gracz gracz;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Assets";
            graphics.IsFullScreen = true;
            Ekran.SzerEkranu = graphics.PreferredBackBufferHeight;
            Ekran.WysEkranu = graphics.PreferredBackBufferWidth;
            Ekran.rectEkran = new Rectangle(0, -Ekran.WysEkranu, Ekran.SzerEkranu, Ekran.WysEkranu * 2);
            graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
            //GameState.FlagiSceny[1].IsShowGameMainMenuScene = true;
            textury = new Texture(this);
            Scena.IsScenaGry = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            //gracz = new Gracz(this.GraphicsDevice);

            base.Initialize();
            //Scena.ScenyPoziomow.Add(new ShowGameScene());
            Scena.ScenyPoziomow.Add(new ShowGameLevel1Scene(this.GraphicsDevice));
            Scena.ScenyPoziomow.Add(new ShowGameLevel2Scene(this.GraphicsDevice));
            Scena.ScenyPoziomow.Add(new ShowGameLevel3Scene(this.GraphicsDevice));
            Scena.ScenyPoziomow.Add(new ShowGameLevel4Scene(this.GraphicsDevice));
            Scena.ScenyPoziomow.Add(new ShowGameLevel5Scene(this.GraphicsDevice));
            Scena.ScenyPoziomow.Add(new ShowGameLevel6Scene(this.GraphicsDevice));
            Scena.ScenyPoziomow.Add(new ShowGameLevel7Scene(this.GraphicsDevice));
            Scena.ScenyPoziomow.Add(new ShowGameInterfejsScene(this.GraphicsDevice));
            Scena.Sceny.Add(new ShowGameMainMenuScene(this.GraphicsDevice));
            Scena.Sceny.Add(new ShowGameOverScene(this.GraphicsDevice));
            Flaga._IsShowGameMainMenuScene = true;
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);


                textury.LoadContentTexturyObiektow();
                textury.LoadContentTexturyScen();
                textury.LoadContentTexturyPrzyciskow();
                textury.LoadContentTexturyFonts();
            //

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            //Create a new spriteBatch which can by used do draw textures
            spriteBatch = new SpriteBatch(GraphicsDevice);
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            //Touch.Touch.dotyk.Update(ref gameTime);
            if (Scena.IsScenaGry == true)
            {
                for (int i = 0; i <= Scena.Sceny.Count - 1; i++)
                {
                    Scena.IndexSzukanejSceny = FindScena(Scena.Sceny[i].getShowScene());
                    if ((Scena.IndexSzukanejSceny != -1) && (Scena.IsScenaGry == true))
                    {
                        Scena.Sceny[Scena.IndexSzukanejSceny].Update(ref gameTime);
                    }
                    else
                    {
                        //zabespieczenie trzeba zrobic, jesli nie znajdzie w Scenach to co ma zrobic
                        //Scena.Sceny[Scena.Sceny.Count - 1].Update(ref delta);
                    }
                }
            }
            else if (Scena.IsScenaPoziomy == true)
            {
                for (int sp = 0; sp <= Scena.ScenyPoziomow.Count - 1; sp++)
                {
                    Scena.IndexSzukanejScenyPoziomy = FindScenaPoziomow(Scena.ScenyPoziomow[sp].getShowScene());
 
                    if (Scena.IndexSzukanejScenyPoziomy != -1 && (Scena.IsScenaPoziomy == true))
                    {

                        Scena.ScenyPoziomow[Scena.IndexSzukanejScenyPoziomy].Update(ref gameTime);
                    }
                    else
                    {
                        //zabespieczenie trzeba zrobic, jesli nie znajdzie w Scenach to co ma zrobic
                        //Scena.Sceny[Scena.Sceny.Count - 1].Update(ref delta);
                    }
                }
            }
            else
            {
                //Scena.Sceny[Scena.Sceny.Count - 1].Update(ref delta);
            }
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            base.Draw(gameTime);

            if (Scena.IsScenaGry == true)
            {
                for (int i = 0; i <= Scena.Sceny.Count - 1; i++)
                {
                    Scena.IndexSzukanejSceny = FindScena(Scena.Sceny[i].getShowScene());

                    if ((Scena.IndexSzukanejSceny != -1) && (Scena.IsScenaGry == true))
                    {
                        spriteBatch.Begin();
                        Scena.Sceny[Scena.IndexSzukanejSceny].Draw(spriteBatch);
                        spriteBatch.End();
                    }
                    else
                    {

                    }
                }
            }
            else if(Scena.IsScenaPoziomy == true)
            {
                for (int sp = 0; sp <= Scena.ScenyPoziomow.Count - 1; sp++)
                {
                    Scena.IndexSzukanejScenyPoziomy = FindScenaPoziomow(Scena.ScenyPoziomow[sp].getShowScene());

                    if ((Scena.IndexSzukanejScenyPoziomy != -1) && (Scena.IsScenaPoziomy == true))
                    {
                        spriteBatch.Begin();
                        Scena.ScenyPoziomow[Scena.IndexSzukanejScenyPoziomy].Draw(spriteBatch);
                        spriteBatch.End();
                    }
                    else
                    {
                        //zabespieczenie trzeba zrobic, jesli nie znajdzie w Scenach to co ma zrobic
                        //Scena.Sceny[Scena.Sceny.Count - 1].Update(ref delta);
                    }
                }
            }
            else //START GRY
            {
                /*spriteBatch.Begin();
                Scena.Sceny[Scena.Sceny.Count].Draw();
                spriteBatch.End();*/
            }

        }

        /// <summary>
        /// Funkcja zwroci Index Sceny ktora zawiera podan¹ nazwe Sceny
        /// </summary>
        /// <param name="nazwaSceny">Nazwa Sceny - string /zazwyczaj taka jak nazwa klasy .</param>
        public int FindScena(string nazwaSceny)
        {
            int findScena;
            if ((Scena.Sceny.FindIndex(x => x.nazwa.Contains(nazwaSceny)) != -1))
            {
                Scena.IsScenaGry = true;
                Scena.IndexSzukanejScenyPoziomy = -1;
                return findScena = Scena.Sceny.FindIndex(x => x.nazwa.Contains(nazwaSceny));
            }
            return -1;
        }
        public int FindScenaPoziomow(string nazwaSceny)
        {
            int findScena; 
            if (Scena.ScenyPoziomow.FindIndex(x => x.nazwa.Contains(nazwaSceny)) != -1)
            {
                Scena.IsScenaPoziomy = true;
                Scena.IndexSzukanejSceny = -1;
                return findScena = Scena.ScenyPoziomow.FindIndex(x => x.nazwa.Contains(nazwaSceny));
            }

            return -1;
        }
        static public void DebugScenyFlagi()
        {
            WypiszSceny();
            WypiszScenyPoziomy();
        }
        static public void WypiszSceny()
        {
            Debug.WriteLine("################## GameState.Sceny.Sceny START ####################");
            Debug.Write("GameState.Sceny.Count: " + Scena.Sceny.Count);
            for (int i = 0; i < Scena.Sceny.Count; i++)
            {
                Debug.WriteLine("[" + i + "]Sceny.Sceny[" + i + "].Name: " + Scena.Sceny[i].nazwa + " GameState.Sceny[" + i + "].GetType(): " + Scena.Sceny[i].GetType() + " GameState.Sceny[" + i + "].Active(): " + Scena.Sceny[i].Active + " GameState.Sceny[" + i + "].getShowScene(): " + Scena.Sceny[i].getShowScene());
            }
            Debug.WriteLine("################## Sceny.Sceny END ####################");
        }
        static public void WypiszScenyPoziomy()
        {
            Debug.WriteLine("################## GameState.ScenyPoziomow START ####################");
            Debug.Write("GameState.ScenyPoziomow.Count: " + Scena.ScenyPoziomow.Count);
            for (int i = 0; i <= Scena.ScenyPoziomow.Count -1; i++)
            {
                Debug.WriteLine("[" + i + "]GameState.ScenyPoziomow[" + i + "].Name: " + Scena.ScenyPoziomow[i].nazwa + " GameState.Sceny[" + i + "].GetType(): " + Scena.ScenyPoziomow[i].GetType() + " GameState.Sceny[" + i + "].Active(): " + Scena.ScenyPoziomow[i].Active + " GameState.Sceny[" + i + "].getShowScene(): " + Scena.ScenyPoziomow[i].getShowScene());
            }
            Debug.WriteLine("################## GameState.ScenyPoziomow END ####################");
        }
        static public void PokazStatusyFlag()
        {
            Debug.WriteLine("########### Flaga_ START ############## ");
            Debug.WriteLine("_IsFlaga " + Flaga._IsFlaga);                  //0
            Debug.WriteLine("_IsShowGameMainMenuScene " + Flaga._IsShowGameMainMenuScene);  //1
            Debug.WriteLine("_IsShowGameScene " + Flaga._IsShowGameScene);        //2
            Debug.WriteLine("_IsShowGameLevel1Scene " + Flaga._IsShowGameLevel1Scene);    //3
            Debug.WriteLine("_IsShowGameLevel2Scene " + Flaga._IsShowGameLevel2Scene);     //4 
            Debug.WriteLine("_IsShowGameLevel3Scene " + Flaga._IsShowGameLevel3Scene);     //5
            Debug.WriteLine("_IsShowGameLevel4Scene " + Flaga._IsShowGameLevel4Scene); //6
            Debug.WriteLine("_IsShowGameLevel5Scene " + Flaga._IsShowGameLevel5Scene);     //7
            Debug.WriteLine("_IsShowGameLevel6Scene " + Flaga._IsShowGameLevel6Scene);     //8
            Debug.WriteLine("_IsShowGameLevel7Scene " + Flaga._IsShowGameLevel7Scene);    //9
            Debug.WriteLine("_IsShowGameOverScene " + Flaga._IsShowGameOverScene);      //10
            Debug.WriteLine("_IsShowOpisScene " + Flaga._IsShowOpisScene);         //11
            Debug.WriteLine("_IsShowWynikiScene " + Flaga._IsShowWynikiScene);         //12
            Debug.WriteLine("_IsShowGameInterfejsScene " + Flaga._IsShowGameInterfejsScene); //13
            Debug.WriteLine("########### Flaga_ END ############## ");
        }


        public void DebugScen()
        {
            Debug.WriteLine("Scena.IsScenaGry: " + Scena.IsScenaGry);
            Debug.WriteLine("Scena.IsScenaPoziomy: " + Scena.IsScenaPoziomy);
            Debug.WriteLine("IndexSzukanejSceny " + Scena.IndexSzukanejSceny);
            Debug.WriteLine("IndexSzukanejScenyPoziomy " + Scena.IndexSzukanejScenyPoziomy);

        }




        static public void LapWyjatek()
        {

            try
            {
                using (var stream = TitleContainer.OpenStream("charactersheet.png"))
                {
                    //Texture.characterSheetTexture = Texture2D.FromStream(GraphicsDevice, stream);

                }
            }
            catch (FileNotFoundException ex)
            {
                Debug.WriteLine("ex.FileName: " + ex.FileName);
                Debug.WriteLine("ex.FusionLog: " + ex.FusionLog);
                Debug.WriteLine("ex.Message: " + ex.Message);
                Debug.WriteLine("ex.HelpLink: " + ex.HelpLink);
                Debug.WriteLine("ex.GetType: " + ex.GetType().ToString());
                Debug.WriteLine("ex.Source: " + ex.Source);
                Debug.WriteLine("ex.StackTrace: " + ex.StackTrace);
                Debug.WriteLine("ex.TargetSite: " + ex.TargetSite);
                Debug.WriteLine("ex.InnerException: " + ex.InnerException);
                Debug.WriteLine("ex.Data: " + ex.Data);
                // Code to handle the exception goes here.
                // Only catch exceptions that you know how to handle.
                // Never catch base class System.Exception without
                // rethrowing it at the end of the catch block.
            }

        }
    }


}
