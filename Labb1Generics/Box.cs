using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1Generics
{
    public class Box : IEquatable<Box>
    {

        public Box(int h, int l, int b)
        {
            this.height = h;
            this.length = l;
            this.width = b;
        }
        public int height { get; set; }
        public int length { get; set; }
        public int width { get; set; }


        public bool Equals(Box other)
        {
            if (new BoxSameDimensions().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
