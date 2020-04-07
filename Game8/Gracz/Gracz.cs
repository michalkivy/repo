using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Diagnostics;
using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework.Input.Touch;

namespace Game8
{
    class Gracz
    {
        public ParametryGracza paramGracza;
        private int Width { get; set; } //szerokosc Obrazka worek
        private int Height { get; set; } //wysokosc Obrazka worek
        private float X; // pozycja X
        private float Y; // pozycha Y
        public int PktZycia { get; set; }
        public int PunktyGracza { get; set; }
        private string nazwaGracza { get; set; }

        Animation walkDown;
        Animation walkUp;
        Animation walkLeft;
        Animation walkRight;

        Animation standDown;
        Animation standUp;
        Animation standLeft;
        Animation standRight;

        Animation currentAnimation;

        //public List<Pocisk> Pociski = new List<Pocisk>();

        public static Texture2D texture;
        public Vector2 position;

        public int predkosc { get; set; }

        private Rectangle rectGracz { get; set; }

        public Gracz(GraphicsDevice graphicsDevice)
        {
            /*
            if (texture == null)
            {
                using (var stream = TitleContainer.OpenStream("TextutyObiektow/charactersheet2.png"))
                {
                    texture = Texture2D.FromStream(graphicsDevice, stream);
                }
            }*/

            if (texture == null)
            {
                using (var stream = TitleContainer.OpenStream("TextutyObiektow/TexturaGraczAnimacja2.png"))
                {
                    texture = Texture2D.FromStream(graphicsDevice, stream);
                }
            }


           walkDown = new Animation();
            walkDown.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkDown.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkDown.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkDown.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));

            walkUp = new Animation();
            walkUp.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkUp.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkUp.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkUp.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));

            walkLeft = new Animation();
            walkLeft.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkLeft.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkLeft.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkLeft.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));

            walkRight = new Animation();
            walkRight.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkRight.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkRight.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));
            walkRight.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));

            // Standing animations only have a single frame of animation:
            standDown = new Animation();
            standDown.AddFrame(new Rectangle(0, 0, 250, 250), TimeSpan.FromSeconds(1.5));

            standUp = new Animation();
            standUp.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));

            standLeft = new Animation();
            standLeft.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));

            standRight = new Animation();
            standRight.AddFrame(new Rectangle(250, 0, 250, 250), TimeSpan.FromSeconds(1.5));



            Width = texture.Width;
            Height = texture.Height;

            paramGracza = new ParametryGracza();

            PktZycia = paramGracza.PktZycia;
            PunktyGracza = paramGracza.PunktyGracza;

            X = Ekran.SzerEkranu / 2; //poczatkowe X
            Y = Ekran.WysEkranu - 500; // poczatkowe Y

            predkosc = 15;
            position = new Vector2(X, Y);

            rectGracz = new Rectangle((int)X, (int)Y, 100, 100);
        }
        //poruszanie prawo lewo gora
        public void MoveL()
        {
            if (X >= 0 && X <= Ekran.SzerEkranu - Width)
            {
                X = X - predkosc;
                position.X = X;
            }
            if (X < 0)
            {
                X = 1;
                position.X = X;
            }
        }

        public void MoveR()
        {
            if (X >= 0 && X <= Ekran.SzerEkranu - Width)
            {
                X = X + predkosc;
                position.X = X;
            }
            if (X > Ekran.SzerEkranu - Width)
            {
                X = Ekran.SzerEkranu - Width;
                position.X = X;
            }
        }

        public void MoveU()
        {
            if (Y >= 0 && Y <= Ekran.WysEkranu - Height)
            {
                Y = Y + predkosc;
                position.Y = Y;
            }
            if (Y > Ekran.WysEkranu - Height)
            {
                Y = Ekran.WysEkranu - Height;
                position.Y = Y;
            }
        }

        public void MoveD()
        {
            if (Y >= 0 && Y <= Ekran.WysEkranu - Height)
            {
                Y = Y - predkosc;
                position.Y = Y;
            }
            if (Y < 0)
            {
                Y = 1;
                position.Y = Y;
            }
        }
        public void Restart()
        {
            PktZycia = paramGracza.PktZycia;
            PunktyGracza = paramGracza.PunktyGracza;
        }

        public void Update(ref GameTime gameTime)
        {
            var velocity = GetDesiredVelocityFromInput();

            //TouchCollection touchCollection = TouchPanel.GetState(); //gdzie użytkownik dotyka ekranu. 
                                                                     //touch Collection jest 0 gdy uzytkownik nie dotyka ekranu

            

            this.X += velocity.X * (float)gameTime.ElapsedGameTime.TotalSeconds;
            //this.Y += velocity.Y * (float)gameTime.ElapsedGameTime.TotalSeconds;

            position.X = this.X;
            position.Y = this.Y;


            /*
            if (
                (touchCollection.Count > 0)
                && (touchCollection[0].State != TouchLocationState.Moved) 
                )
            {
                Debug.WriteLine("Strzelaj");
                Pocisk pocisk = new Pocisk(ref position);
                Pociski.Add(pocisk);
            }

            foreach (Pocisk poci in Pociski)
                poci.Update(ref gameTime);
                */


            if (velocity != Vector2.Zero)
            {
                bool movingHorizontally = Math.Abs(velocity.X) > Math.Abs(velocity.Y);
                if (movingHorizontally)
                {
                    if (velocity.X > 0)
                    {
                        currentAnimation = walkRight;
                    }
                    else
                    {
                        currentAnimation = walkLeft;
                    }
                }
                else
                {
                    if (velocity.Y > 0)
                    {
                        currentAnimation = walkDown;
                    }
                    else
                    {
                        currentAnimation = walkUp;
                    }
                }
            }
            else
            {
                // If the character was walking, we can set the standing animation
                // according to the walking animation that is playing:
                if (currentAnimation == walkRight)
                {
                    currentAnimation = standRight;
                }
                else if (currentAnimation == walkLeft)
                {
                    currentAnimation = standLeft;
                }
                else if (currentAnimation == walkUp)
                {
                    currentAnimation = standUp;
                }
                else if (currentAnimation == walkDown)
                {
                    currentAnimation = standDown;
                }
                else if (currentAnimation == null)
                {
                    currentAnimation = standDown;
                }

                // if none of the above code hit then the character
                // is already standing, so no need to change the animation.
            }

            currentAnimation.Update(ref gameTime);


            //Quaternion quat = new Quaternion(0, 0, 0, 0);
            //Vector2.Transform(ref velocity, ref quat, out position);


            //jesli pozsitionDotyk nie jest na rectGracza to nie rob nic
            // jesli positionDotyk jest na rectGracz to przesun w kierunku positionDotykKoniec.

            //jesli jest dotkniecie krotkie na rectGracz to strzel pociskiem.
            /**/
            //Rectangle rectDotyk = new Rectangle((int)Touch.Touch.dotyk.GetTouchLocation().Position.X, (int)Touch.Touch.dotyk.GetTouchLocation().Position.Y, 5, 5);
            //Vector2 positionDotyk = new Vector2((int)Touch.Touch.dotyk.GetTouchLocation().Position.X, (int)Touch.Touch.dotyk.GetTouchLocation().Position.Y);

            //Quaternion quat = new Quaternion(0, 0, 0, 0);
            //Vector2.Transform(ref positionDotyk, ref quat, out position);
            //this.X = positionDotyk.X ;
            //this.Y = positionDotyk.Y ;

            /*
            if (rectGracz.Intersects(rectDotyk))
            {
                Quaternion quat = new Quaternion(0, 0, 0, 0);
                Vector2.Transform(ref positionDotyk, ref quat, out position);
                position.X = position.X - (Width / 2);
                position.Y = position.Y - (Height / 2);
            }*/
            //ZmienPozycje((int)Game1.mscaDotkniete[Game1.mscaDotkniete.Count - 1].Position.X, (int)Game1.mscaDotkniete[Game1.mscaDotkniete.Count - 1].Position.Y);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Vector2 topLeftOfSprite = new Vector2(this.X, this.Y);
            Color tintColor = Color.White;
            Rectangle sourceRectangle = new Rectangle();
            sourceRectangle = currentAnimation.CurrentRectangle;

            try
            {
                sourceRectangle = currentAnimation.CurrentRectangle;
            }
            catch 
            {
                //System.NullReferenceException: Object reference not set to an instance of an object.

            }

            rectGracz = new Rectangle((int)topLeftOfSprite.X, (int)topLeftOfSprite.Y, 250, 250);

            spriteBatch.Draw(texture, topLeftOfSprite, sourceRectangle, Color.White);
            //spriteBatch.Draw(texture, rectGracz, sourceRectangle, Color.White);
            //spriteBatch.Draw(texture, rectGracz, Color.White);

            //foreach (Pocisk poci in Pociski)
            //    poci.Draw(spriteBatch);


        }
        public void DodajPunkty(int a)
        {
            PunktyGracza += a;
        }
        public void OdejmyjZycie(int a)
        {
            PktZycia -= a;
        }
        public void OdejmyjZycie(int Sila, int moc)
        {
            PktZycia -= Sila * moc;
        }
        public Vector2 GetPosiotion()
        {
            return position;
        }

        virtual public bool Collider(ObiektSpadajacy obiekt)
        {
            if (rectGracz.Intersects(obiekt.rectObiekt))
            {
                return true;
            }

            return false;
        }

        Vector2 GetDesiredVelocityFromInput()
        {
            Vector2 desiredVelocity = new Vector2(); //Metoda zwraca informacje o statusie

            TouchCollection touchCollection = TouchPanel.GetState(); //gdzie użytkownik dotyka ekranu. 
            //touch Collection jest 0 gdy uzytkownik nie dotyka ekranu
            if (touchCollection.Count > 0)
            {
                //Jeśli użytkownik dotyka ekranu, zmienimy znak w kierunku pierwszego dotknięcia, innymi słowy, TouchLocation pod indeksem 0.Początkowo ustawimy pożądaną prędkość tak, aby była równa różnicy między lokalizacją znaku a pierwszą lokalizacją dotknięcia:
                desiredVelocity.X = touchCollection[0].Position.X - this.X;
                desiredVelocity.Y = touchCollection[0].Position.Y - this.Y;

                if (desiredVelocity.X != 0 || desiredVelocity.Y != 0) //Instrukcja sprawdza, czy prędkość jest różna od zera 
                {
                    desiredVelocity.Normalize();
                    const float desiredSpeed = 120;//szybkosc
                    desiredVelocity *= desiredSpeed;
                }
            }

            return desiredVelocity;
        }

        public void Strzelaj()
        {
            //Vector2 desiredVelocity = new Vector2(); //Metoda zwraca informacje o statusie

            TouchCollection touchCollection = TouchPanel.GetState(); //gdzie użytkownik dotyka ekranu. 
                                                                     //touch Collection jest 0 gdy uzytkownik nie dotyka ekranu

            //if ((touchCollection.Count > 0) && (touchCollection[0].State == TouchLocationState.Pressed))
            //{
             //   Debug.WriteLine("Strzelaj");
            //    Pocisk pocisk = new Pocisk();
            //    Pociski.Add(pocisk);
            //}

        }
    }
}
