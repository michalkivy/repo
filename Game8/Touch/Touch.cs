using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System.Diagnostics;

namespace Game8.Touch
{
    class Touch
    {
        public TouchCollection touchCollection;// kolekcja mniejsc kliknięc; // tablica dotkniec
        public TouchLocation dotLocate { get; set; } // ostatnia lokalizacja dotkniecia

        public static Touch dotyk = new Touch();

        public Touch()
        {
            GetTouchCollection();

        }
        public TouchCollection GetTouchCollection()
        {
            return touchCollection = TouchPanel.GetState();
        }

        public TouchLocation GetTouchLocation()
        {
            touchCollection = GetTouchCollection();
            if (touchCollection.Count != 0)
            {
                return dotLocate = touchCollection[touchCollection.Count-1];
            }
            else
            {
                return dotLocate;
            }
        }

        public void Update(ref GameTime gameTime)
        {
            GetTouchCollection();
        }

        public void  WypiszTabliceDotkniec()
        {
            foreach (TouchLocation dotLocate in touchCollection)
            {
                Debug.WriteLine("#########TouchLocation#########");
                Debug.WriteLine("dotyk.Id: " + dotLocate.Id);
                Debug.WriteLine("dotyk.Position.X: " + dotLocate.Position.X);
                Debug.WriteLine("dotyk.Position.Y: " + dotLocate.Position.Y);
                Debug.WriteLine("#########TouchLocation#########");
            }

        }
    }
}