
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game8
{
    class Background
    {

        public int Width { get; set; } //szerokosc Obrazka worek
        public int Height { get; set; } //wysokosc Obrazka worek

        private Rectangle rectBackground { get; set; }

        public Texture2D BackgroundTexture { get; set; }

        public Background()
        {
            Width = Ekran.SzerEkranu;
            Height = Ekran.WysEkranu;
            rectBackground = new Rectangle(0, 0, Ekran.SzerEkranu, Ekran.WysEkranu);
        }
        public Background(ref Texture2D jakietlo)
        {
            Width = Ekran.SzerEkranu;
            Height = Ekran.WysEkranu;
            rectBackground = new Rectangle(0, 0, Ekran.SzerEkranu, Ekran.WysEkranu);
            BackgroundTexture = jakietlo;
        }

        public void UstawTlo(ref Texture2D jakietlo)
        {

            BackgroundTexture = jakietlo;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            //BackgroundTexture = Content.Load<Texture2D>("background");
            
            spriteBatch.Draw(BackgroundTexture, rectBackground, Color.White);
            

        }
    }
}