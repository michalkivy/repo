using System;
using Microsoft.Xna.Framework;

namespace Game8
{
    public class AnimationFrame
    {
        public Rectangle SourceRectangle { get; set; } // Definiuje obszar, Texture2D który będzie wyświetlany AnimationFrameprzez. Ta wartość jest mierzona w pikselach, a w lewym górnym rogu (0, 0).
        public TimeSpan Duration { get; set; } //kreśla, jak długo AnimationFrame jest wyświetlany, gdy jest używany Animationw.
    }
}