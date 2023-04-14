using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Advanced_Net
{
    public class Box : IEquatable<Box>
    {
        public Box(int h, int l, int w)
        {
            this.Height = h;
            this.Length = l;
            this.Width = w;
        }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public override string ToString()
        {
            return $"Height: {Height}cm, Width: {Width}cm, Length: {Length}cm";
        }


        public bool Equals(Box other)
        {
            //if (new BoxSameDimensions().Equals(this, other))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            return false;
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
