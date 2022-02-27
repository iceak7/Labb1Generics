using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Labb1Generics
{
    public class BoxSameVolume : EqualityComparer<Box>
    {
        public override bool Equals([AllowNull] Box x, [AllowNull] Box y)
        {
            if ((x.width * x.length * x.height) == (y.width * y.length * y.height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode([DisallowNull] Box obj)
        {
            return obj.GetHashCode();
        }
    }
}
