using Game8.Sceny;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace Game8
{
    class Przycisk
    {
        public enum NazwaMenuPrzyciskowEnum { PrzyciskiSceny, PrzyciskiMenu, PrzyciskiGameOver, PrzyciskiUstawienia}

        public enum NazwaPrzyciskuEnum { Start, Menu, Exit, Pauze, Back, Next, Return, Opcje, Wyniki, Opis }

        public static List<Przycisk>[] PrzyciskiAll = new List<Przycisk>[] //Tablica przyciskow
        {};

        private int X;
        private int Y;
        public int Width { get; set; }
        public int Height { get; set; }
        public Texture2D texturaPrzycisku { get; set; }

        public String nazwaPrzyciskuS;
        public String nazwaManuPrzyciskowS;

        public NazwaMenuPrzyciskowEnum nazwaMenuPrzyciskow { get; set; }
        public NazwaPrzyciskuEnum nazwaEnumPrzycisku { get; set; }

        public Vector2 positionMenu { get; set; }
        public Vector2 positionPrzycisku { get; set; }

        public Rectangle rectPrzycisku;

        public Przycisk()
        {
            //
        }

        public Przycisk(Vector2 miejscePrzycisku, ref Texture2D texture, NazwaPrzyciskuEnum nazwaEnum)
        {
            //Debug.WriteLine("Konstuktor");
            nazwaEnumPrzycisku = nazwaEnum;
            this.nazwaPrzyciskuS = nazwaEnum.ToString();
            texturaPrzycisku = texture;
            //nazwaMenuPrzyciskow = nazwaMenuDoKtoregoMaNalezec;

            positionPrzycisku = miejscePrzycisku;

            Width = texture.Width;
            Height = texture.Height;

            X = (int)positionPrzycisku.X;
            Y = (int)positionPrzycisku.Y;

            rectPrzycisku = new Rectangle((int)positionPrzycisku.X - Width/2 , (int)positionPrzycisku.Y , Width, Height);
        }

        public Przycisk(Vector2 miejscePrzycisku, ref Texture2D texture, NazwaPrzyciskuEnum nazwaEnum,NazwaMenuPrzyciskowEnum nazwaMenuDoKtoregoMaNalezec)
        {
            //Debug.WriteLine("Konstuktor");
            nazwaEnumPrzycisku = nazwaEnum;
            this.nazwaPrzyciskuS = nazwaEnum.ToString();
            texturaPrzycisku = texture;
            nazwaMenuPrzyciskow = nazwaMenuDoKtoregoMaNalezec;

            positionPrzycisku = miejscePrzycisku;

            Width = texture.Width;
            Height = texture.Height;

            X = (int)positionPrzycisku.X;
            Y = (int)positionPrzycisku.Y;

            rectPrzycisku = new Rectangle((int)positionPrzycisku.X - Width / 2, (int)positionPrzycisku.Y, Width, Height);
        }

        public NazwaPrzyciskuEnum EnumNazwaPrzycisku()
        {
            return nazwaEnumPrzycisku;
        }
        public NazwaMenuPrzyciskowEnum EnumNazwaMenuPrzyciskowEnum()
        {
            return nazwaMenuPrzyciskow;
        }
        public String GetNazwaPrzyciskuS()
        {
            return nazwaPrzyciskuS;
        }
        public String GetNazwaManuPrzyciskowS()
        {
            return nazwaManuPrzyciskowS;
        }
        public Rectangle GetRect()
        {
            return rectPrzycisku;
        }
        public Vector2 GetPositionPrzycisku()
        {
            return positionPrzycisku;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texturaPrzycisku, rectPrzycisku, Color.White);
        }

        /// <summary>Class <c></c> Akcja Przycisku.
        /// Podaj przycisk ktory chcesz aby wykonała sie jego akcja</summary>
        public virtual void Update(ref GameTime gameTime)
        {
            ClickButton();
        }

        /// <summary>Class <c>ClickButton</c> Akcja Przycisku. Param: Przycisk ,jaki chcesz sprawdzic
        /// Podaj przycisk ktory chcesz aby wykonała sie jego akcja</summary>
        ///
        public void ClickButton()
        {

            Vector2 pozycjaDotyku = new Vector2(); //Metoda zwraca informacje o statusie
            Vector2 pozycjaOstatniegoDotkniecia = new Vector2();

            TouchCollection touchCollection = TouchPanel.GetState(); //gdzie użytkownik dotyka ekranu. 
            //touch Collection jest 0 gdy uzytkownik nie dotyka ekranu

            //Vector2 positionDotyk = new Vector2(Touch.Touch.dotyk.GetTouchLocation().Position.X, Touch.Touch.dotyk.GetTouchLocation().Position.Y);


            if ((touchCollection.Count > 0) && (touchCollection[0].State == TouchLocationState.Pressed))
            {
                Debug.WriteLine("@@@#@#@#@#@ Akcja przycisku START @@@#@#@#@#@");
                Debug.WriteLine("(int)touchCollection[0].Position.X:" + (int)touchCollection[0].Position.X);
                Debug.WriteLine("(int)touchCollection[0].Position.Y:" + (int)touchCollection[0].Position.Y);

                Rectangle rectDotyk = new Rectangle((int)touchCollection[0].Position.X, (int)touchCollection[0].Position.Y,  5, 5);
                Debug.WriteLine("Pozycja rectDotyk.Location.X:" + rectDotyk.Location.X);
                Debug.WriteLine("Pozycja rectDotyk.Location.Y:" + rectDotyk.Location.Y);

                Debug.WriteLine("@@@#@#@#@#@ Akcja przycisku END @@@#@#@#@#@");

                if (rectDotyk.Intersects(rectPrzycisku))
                {
                    switch (nazwaEnumPrzycisku)
                    {
                        case NazwaPrzyciskuEnum.Start:
                            Flaga.SprawdzIUstawFlageNaTrue(EnumFlagaSceny.ShowGameLevel1Scene);
                            break;
                        case NazwaPrzyciskuEnum.Exit:
                            //Przeskok do poprzedniego indexu tablicy PRzyciski
                            break;
                        case NazwaPrzyciskuEnum.Pauze:
                            //Przeskok do poprzedniego indexu tablicy PRzyciski
                            break;
                        case NazwaPrzyciskuEnum.Next:

                            break;
                        case NazwaPrzyciskuEnum.Back:
                            // do somethink
                            break;
                        case NazwaPrzyciskuEnum.Opcje:
                            //Przeskok do poprzedniego indexu tablicy PRzyciski
                            break;
                        case NazwaPrzyciskuEnum.Opis:
                            //Przeskok do poprzedniego indexu tablicy PRzyciski
                            break;
                        case NazwaPrzyciskuEnum.Wyniki:
                            //Przeskok do poprzedniego indexu tablicy PRzyciski
                            break;
                        case NazwaPrzyciskuEnum.Return:
                            //Przeskok do poprzedniego indexu tablicy PRzyciski
                            break;
                        case NazwaPrzyciskuEnum.Menu:
                            Debug.WriteLine("nazwaEnumPrzycisku: +" + nazwaEnumPrzycisku);
                            Flaga.SprawdzIUstawFlageNaTrue(EnumFlagaSceny.ShowGameMainMenuScene);
                            break;
                        default:
                            break;
                    }
                }
                else
                {

                }
            }
            /*
            for (int i = 0; i < touchCollection.Count; i++)
            {
                Debug.WriteLine("################## Kolekcja dotknieci START ################# touchCollection.Count" + touchCollection.Count);
                Debug.WriteLine("TouchCollection["+i+"].State: " + touchCollection[i].State);
                Debug.WriteLine("TouchCollection[" + i + "].Id: " + touchCollection[i].Id);
                Debug.WriteLine("TouchCollection[" + i + "].Pressure: " + touchCollection[i].Pressure);
                Debug.WriteLine("TouchPanel[" + i + "].GetState(): " + TouchPanel.GetState());
                //Debug.WriteLine("TouchPanel[" + i + "].ReadGesture(): " + TouchPanel.ReadGesture());
                Debug.WriteLine("TouchPanel[" + i + "].ReadGesture(): " + TouchPanel.DisplayHeight);
                
                Debug.WriteLine("PozycjaDotyku                 X: " + pozycjaDotyku.X + " Y: "+ pozycjaDotyku.Y );
                Debug.WriteLine("################## Kolekcja dotknieci END #################");
            }*/

        }

        public int FindIndexTablicyMenu(NazwaMenuPrzyciskowEnum nazwaEnumMenu)
        {
            for(int i = 0; i < PrzyciskiAll.Length; i++)
            {
                PrzyciskiAll[i].FindIndex(x => x.nazwaMenuPrzyciskow == nazwaEnumMenu);
            }

            return 1;
        }

        static public void SprawdzPrzycisk()
        {
            Debug.WriteLine("@@@@@@@@@@@@@@@@@@@  PRZYCISK START  @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
            Debug.WriteLine("@@@@@@@@@@@@@@@@@@@  PRZYCISK END   @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");

        }
    }
}