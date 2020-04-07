using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Game8
{
    class Punkt
    {
        private readonly int wartosc;

        public Punkt()
        {
            wartosc = 1;
        }

        public Punkt(int wartosc)
        {
            this.wartosc = wartosc;
        }

        public Punkt(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(denominator));
            }
            wartosc = numerator;
        }

        public static Punkt operator +(Punkt a) => a;
        public static Punkt operator -(Punkt a) => new Punkt(-a.wartosc);

        public static Punkt operator +(Punkt a, Punkt b)
            => new Punkt(a.wartosc + b.wartosc);

        public static Punkt operator -(Punkt a, Punkt b)
            => a + (-b);

        public static Punkt operator *(Punkt a, Punkt b)
            => new Punkt(a.wartosc * b.wartosc);

        public static Punkt operator /(Punkt a, Punkt b)
        {
            if (b.wartosc == 0)
            {
                throw new DivideByZeroException();
            }
            return new Punkt(a.wartosc / b.wartosc);
        }

        public override string ToString() => $"{wartosc}";
    }
}