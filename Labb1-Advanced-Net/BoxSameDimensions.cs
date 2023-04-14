using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Advanced_Net
{
    internal class BoxSameDimensions : IEqualityComparer<Box>
    {
        public bool Equals(Box? x, Box? y)
        {
            if (x == null || y == null)
            {
                Console.WriteLine($"Error: {x} or {y} is null!");
                return false;

            }

            if (x.Height == y.Height && x.Width == y.Width && x.Length == y.Length)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("#");
                Console.ResetColor();
                Console.WriteLine(" Error from BoxSameDimensions: Dimensions are the same, cannot add box.");
                Console.WriteLine("------");
                return true;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Box obj)
        {
            throw new NotImplementedException();
        }
    }
}
