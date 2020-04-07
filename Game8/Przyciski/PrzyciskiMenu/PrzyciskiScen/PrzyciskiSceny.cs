
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Game8
{
    class PrzyciskiSceny : PrzyciskiScen
    {
        public bool viweMenuPrzyciski;

        public static Przycisk PrzyciskStart;
        public static Przycisk PrzyciskOpis;
        public static Przycisk PrzyciskWyniki;
        public static Przycisk PrzyciskExit;

        public PrzyciskiSceny()
        {
            //nazwaMenuPrzyciskow = NazwaMenuPrzyciskowEnum.PrzyciskiSceny;
            //nazwaManuPrzyciskowS = NazwaMenuPrzyciskowEnum.PrzyciskiSceny.ToString();
        }

        public PrzyciskiSceny(Vector2 miejscePrzycisku, ref Texture2D texture, NazwaPrzyciskuEnum nazwaEnum)
        {
            /*
            nazwaEnumPrzycisku = nazwaEnum;
            this.nazwaPrzyciskuS = nazwaEnum.ToString();
            texturaPrzycisku = texture;

            positionPrzycisku = miejscePrzycisku;

            Width = texture.Width;
            Height = texture.Height;

            rectPrzycisku = new Rectangle((int)positionPrzycisku.X, (int)positionPrzycisku.Y, Texture.Przycisk.Width, Texture.Przycisk.Height);
            */
        }
    }
}