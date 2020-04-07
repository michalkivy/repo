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
    class ShowGameScene : Scena
    {
        public static Gracz gracz;
        public int FTP = 0;

        public List<Pocisk> Pociski = new List<Pocisk>();

        public List<ObiektSpadajacy> Obiekty1 = new List<ObiektSpadajacy>();

        public ShowGameScene(GraphicsDevice graphicsDevice) : base (graphicsDevice)
        {
            PunktyPoziomu = Poziomy.ShowGameScenePunktyMax;

            background.UstawTlo(ref Texture.ShowGameLevel1Scene);
            
            IsScenaPoziomy = true;

            Active = false;
            gracz = new Gracz(graphicsDevice);
        }
        /*
        public ShowGameScene(ref GraphicsDevice graphicsDevice)
        {
            PunktyPoziomu = Poziomy.ShowGameScenePunktyMax;

            background.UstawTlo(ref Texture.ShowGameLevel1Scene);

            IsScenaPoziomy = true;

            Active = false;
            gracz = new Gracz(graphicsDevice);
        }*/

        override public void Update(ref GameTime gameTime)
        {
            Dzialanie();

            RysujColidujObiekty(Obiekty1, ref gameTime);

            AkcjaPoziomu();
            
            gracz.Update(ref gameTime);

            Strzelaj();

            foreach (Pocisk poci in Pociski)
                poci.Update(ref gameTime);
        }

        public void Dzialanie()
        {
            FTP++;
            if (FTP == 400)
            {
                CreatorPrzedmiotu(new Przedmiot(ref Texture.TexturaPrzedmiotu1), ref Obiekty1);
            }
            if (FTP == 790)
            {
                CreatorPrzedmiotu(new Przeciwnik(ref Texture.TexturaPrzeciwnik), ref Obiekty1);
                FTP = 0;
            }



        }

        /// <summary>Class <c>DodawaniePoziomu</c> Dodaje Poziom do Tablicy Scen ktora mozna potem otwierac w zaleznosci od GameState
        /// jaką scene schesz dodać do nastepnego poziomu. </summary>
        ///<param name="JakaScena"> Scena - Klasa sceny np: ShowGameLevel4Scene</param>
        public Scena DodajScenePoziomu(Scena JakaScena)
        {
            Sceny.Add(JakaScena);
            return JakaScena;
        }

        public void AkcjaPoziomu()
        {
            Active = true;

            
            if ( ( (gracz.PunktyGracza >= Scena.ScenyPoziomow[IndexSzukanejScenyPoziomy].PunktyPoziomu && gracz.PunktyGracza <= Scena.ScenyPoziomow[IndexSzukanejScenyPoziomy+1].PunktyPoziomu)   ) && (IsScenaPoziomy == true))
            {
                IndexSzukanejScenyPoziomy++;
                Flaga.SprawdzIUstawFlageNaTrue(ScenyPoziomow[GameState.FindFlaga(ScenyPoziomow[IndexSzukanejScenyPoziomy].nazwa)].GetFlagaScenyPoziomow().nazwaEnumSceny );
            }
            if (gracz.PktZycia <= 0)
            {
                Active = false;
                Restart();
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch);

            foreach (ObiektSpadajacy przed in Obiekty1)
                przed.Draw(spriteBatch);

            foreach (Pocisk poci in Pociski)
                poci.Draw(spriteBatch);


            ScenyPoziomow[ScenyPoziomow.FindIndex(x => x.nazwa.Contains("ShowGameInterfejsScene"))].Draw(spriteBatch);

            gracz.Draw(spriteBatch);
        }

        public void Restart()
        {
            Flaga.SprawdzIUstawFlageNaTrue(EnumFlagaSceny.ShowGameOverScene);
            gracz.Restart();
        }

        /// <summary>Class <c>CreatorPrzedmiotu</c> tworzenie obiektu w TablicyObiektow
        /// jaki obiekt chcerz utworzyć. /Przedmiot /Wrog. I do jakiej TablicyObiektów</summary>
        ///
        public void CreatorPrzedmiotu(ObiektSpadajacy JakiObjekt, ref List<ObiektSpadajacy> TablicaObiektow)
        {
            TablicaObiektow.Add(JakiObjekt);
        }

        /// <summary>Class <c>RysujColidujObiekty</c> 
        /// Funkcja Rysuje Obiekty (tak jak one same w sobie sie zachowywuja) od góry do dołu Zawiera.Update dla kazdego obiektu z Listy Obiektów, którą podamy do funkcji jako: Obiekty</summary>
        ///
        public void RysujColidujObiekty(List<ObiektSpadajacy> Obiekty,ref GameTime gametime)
        {
            for (int i = 0; i < Obiekty.Count; i++)
            {
                Obiekty[i].Update(ref gametime);
                if (gracz.Collider(Obiekty[i]))
                {
                    if (Obiekty[i].GetType() == new Przeciwnik().GetType()  )
                    {
                        gracz.PktZycia = gracz.PktZycia - 1;
                        Obiekty.Remove(Obiekty[i]);
                    }
                    else if( (Obiekty[i].GetType() == new Przedmiot().GetType())  )
                    {
                        gracz.PunktyGracza += 2;
                        Obiekty.Remove(Obiekty[i]);
                    }
                }
                else
                {
                    if (Obiekty[i].ColliderEkran() == false)
                    {
                        if (Obiekty[i].GetType() == new Przeciwnik().GetType())
                        {
                            Obiekty.Remove(Obiekty[i]);
                        }
                        else if (Obiekty[i].GetType() == new Przedmiot().GetType())
                        {
                            gracz.PktZycia = gracz.PktZycia - 1;
                            Obiekty.Remove(Obiekty[i]);
                        }
                    }
                }

            }
        }


        public void Strzelaj()
        {
                    
                    TouchCollection touchCollection = TouchPanel.GetState();

            if( (touchCollection.Count > 0) && (touchCollection[0].State == TouchLocationState.Pressed) )
                {


                foreach (TouchLocation tl in touchCollection)
                {
                    if ((tl.State == TouchLocationState.Pressed)
                              || (tl.State == TouchLocationState.Released)
                              || (tl.State == TouchLocationState.Invalid)
                              )
                    {
                        Debug.WriteLine(TouchPanel.GetState());
                        Debug.WriteLine(tl);
                        Debug.WriteLine("tl.State: " + tl.State);
                        Pocisk pocisk = new Pocisk(ref gracz.position);
                        Pociski.Add(pocisk);

                    }



                }
            }

            //TouchCollection touchCollection = TouchPanel.GetState(); //gdzie użytkownik dotyka ekranu. 
            //touch Collection jest 0 gdy uzytkownik nie dotyka ekranu
            //TouchPanelState tps = TouchPanel.GetState();
            //if ( (touchCollection.Count > 0)
            //    && (touchCollection[0].State == TouchLocationState.Moved)
            //    )
           // {
            //    Pocisk pocisk = new Pocisk(ref gracz.position);
           //     Pociski.Add(pocisk);
           // }


        }

        public void CreatorPocisku(ObiektGracza JakiObjekt, ref List<ObiektGracza> TablicaObiektow)
        {
            TablicaObiektow.Add(JakiObjekt);
        }


    }


}