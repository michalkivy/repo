using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game8
{
    class PrzyciskiScen : Przycisk
    {
        public static List<Przycisk> PrzyciskiScenyL = new List<Przycisk>();    //0
        public static List<Przycisk> PrzyciskiMenu = new List<Przycisk>();      //1
        public static List<Przycisk> PrzyciskiGameOver = new List<Przycisk>();  //2
        public static List<Przycisk> PrzyciskiUstawienia = new List<Przycisk>();//3

        public int IndexSzukanegoPrzyciskuScenyL;
        public int IndexSzukanegoPrzyciskuMenu;
        public int IndexSzukanegoPrzyciskuGameOver;
        public int IndexSzukanegoPrzyciskuUstawienia;

        public static bool _IsPrzyciskiScenyL;
        public static bool _IsPrzyciskiMenu;
        public static bool _IsPrzyciskiGameOver;
        public static bool _IsPrzyciskiUstawienia;

        public static bool IsPrzyciskiScenyL { get { return _IsPrzyciskiScenyL; } set { if (value == true) _IsPrzyciskiScenyL = value; _IsPrzyciskiMenu = false; _IsPrzyciskiGameOver = false; _IsPrzyciskiUstawienia = false; } }
        public static bool IsPrzyciskiMenu { get { return _IsPrzyciskiMenu; } set { if (value == true) _IsPrzyciskiScenyL = false; _IsPrzyciskiMenu = value; _IsPrzyciskiGameOver = false; _IsPrzyciskiUstawienia = false; } }
        public static bool IsPrzyciskiGameOver { get { return _IsPrzyciskiGameOver; } set { if (value == true) _IsPrzyciskiScenyL = false; _IsPrzyciskiMenu = false; _IsPrzyciskiGameOver = value; _IsPrzyciskiUstawienia = false; } }
        public static bool IsPrzyciskiUstawienia { get { return _IsPrzyciskiUstawienia; } set { if (value == true) _IsPrzyciskiScenyL = false; _IsPrzyciskiMenu = false; _IsPrzyciskiGameOver = false; _IsPrzyciskiUstawienia = value; } }

        public bool viweMenuPrzyciski;

        public PrzyciskiScen()
        {
            //
        }

        public PrzyciskiScen(Vector2 miejscePrzycisku, ref Texture2D texture, NazwaPrzyciskuEnum nazwaEnum)
        {
            //nazwaMenuPrzyciskow = NazwaMenuPrzyciskowEnum.PrzyciskiSceny;
            //nazwaManuPrzyciskowS = NazwaMenuPrzyciskowEnum.PrzyciskiSceny.ToString();
        }
        
        public override void Update(ref GameTime gameTime)
        {
            base.Update(ref gameTime);
            
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
        /// <summary>
        /// Funkcja zwroci Index Przycisku z Listy szukanej ktora zawiera podany Enum do funkcji ze wszystkich tablic /FlagiSceny, FlagiPoziomy
        /// </summary>
        /// <param name="nazwaPrzyciskuEnum">nazwaPrzyciskuEnum -typu emum ktorej chcemy znalesc Index .</param>
        public int FindIndexPrzyciskEnum(NazwaPrzyciskuEnum nazwaPrzyciskuEnum)
        {
            if ((PrzyciskiScenyL.FindIndex(x => x.nazwaEnumPrzycisku == nazwaPrzyciskuEnum) != -1))
            {
                IsPrzyciskiScenyL = true;
                return IndexSzukanegoPrzyciskuScenyL = PrzyciskiScenyL.FindIndex(x => x.nazwaEnumPrzycisku == nazwaPrzyciskuEnum);
            }
            else if ((PrzyciskiMenu.FindIndex(x => x.nazwaEnumPrzycisku == nazwaPrzyciskuEnum) != -1))
            {
                IsPrzyciskiMenu = true;
                return IndexSzukanegoPrzyciskuMenu = PrzyciskiMenu.FindIndex(x => x.nazwaEnumPrzycisku == nazwaPrzyciskuEnum);
            }
            else if ((PrzyciskiGameOver.FindIndex(x => x.nazwaEnumPrzycisku == nazwaPrzyciskuEnum) != -1))
            {
                _IsPrzyciskiGameOver = true;
                return IndexSzukanegoPrzyciskuGameOver = PrzyciskiGameOver.FindIndex(x => x.nazwaEnumPrzycisku == nazwaPrzyciskuEnum);
            }
            else if ((PrzyciskiUstawienia.FindIndex(x => x.nazwaEnumPrzycisku == nazwaPrzyciskuEnum) != -1))
            {
                _IsPrzyciskiUstawienia = true;
                return IndexSzukanegoPrzyciskuUstawienia = PrzyciskiUstawienia.FindIndex(x => x.nazwaEnumPrzycisku == nazwaPrzyciskuEnum);
            }
            return -1;
        }
    }
}