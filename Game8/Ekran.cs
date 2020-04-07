using Microsoft.Xna.Framework;

namespace Game8
{
    class Ekran
    {
        public static int SzerEkranu;
        public static int WysEkranu;

        public static Rectangle rectEkran;

        public Ekran(int width, int height)
        {
            SzerEkranu = width; 
            WysEkranu = height;

            rectEkran = new Rectangle(0, 0, SzerEkranu, WysEkranu);
        }
        public int GetEkranWidth()
        {
            return SzerEkranu;
        }
        public int GetEkranHeight()
        {
            return WysEkranu;
        }
        public void SetEkranWidth(int width)
        {
            SzerEkranu = width;
        }
        public void SetEkranHeight(int height)
        {
            WysEkranu = height;
        }
    }
}
