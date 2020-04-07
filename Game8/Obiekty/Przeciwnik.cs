using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Game8
{
    class Przeciwnik : ObiektSpadajacy
    {

        private Punkt punkty;

        public Przeciwnik()
        {
            //
        }

        public Przeciwnik(ref Texture2D texture)
        {
            nazna = "Przeciwnik";
            punkty = new Punkt(5);

            obrazek = texture;

            Width = texture.Width;
            Height = texture.Height;

            predkoscX = 0;
            predkoscY = randX.Next(50, 200);

            X = randX.Next(0, Ekran.SzerEkranu - Width); // poczatek generowanie przedmiotu od X do X szerokosci ekranu
            Y = randY.Next(100, 500);
            Y = -Y;

            position = new Vector2(X, Y); // przypisanie

            rectObiekt = new Rectangle((int)position.X, (int)position.Y, Width, Height); 

        }

        public Punkt GetPunkty()
        {
            return punkty;
        }
    }
}