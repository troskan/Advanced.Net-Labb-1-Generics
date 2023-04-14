using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Advanced_Net
{
    internal class BoxCollection : ICollection<Box>
    {
        private List<Box> boxes;
        public BoxCollection()
        {
            boxes = new List<Box>();
        }

        public int Count => boxes.Count;

        public bool IsReadOnly => false;

        public void Display()
        {
            Console.WriteLine("------------------------------");

            Console.WriteLine("Current boxes inside collection:");
            foreach (var i in boxes)
            {
                Console.WriteLine($"{i}");
            }
            Console.WriteLine("------------------------------");
        }
        public void Add(Box box)
        {
            
                if (boxes.Contains(box, new BoxSameDimensions()))
                {
                }
                
                if (boxes.Contains(box, new BoxSameVol()))
                {
                }

                else
                {
                    boxes.Add(box);
                }
        }

        public void Clear()
        {
            
        }

        public bool Contains(Box item)
        {

            foreach (var box in boxes)
            {
                if(box == item)
                {
                    return true;
                }
               
            }
            return false;
        }
        public bool Contains (Box box, EqualityComparer<Box> comparer)
        {
            foreach (var item in boxes)
            {
                if (comparer.Equals(item, box))
                {
                    return true;
                }
            }
                return false;

        }


        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            int counter = 0;
            foreach (var i in boxes)
            {
                if (item.Width == i.Width && item.Height == i.Height && item.Length == i.Length)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("#");
                    Console.ResetColor();
                    Console.WriteLine($" Success: {i} has been removed!");
                    boxes.RemoveAt(counter);
                    counter++;

                    return true;
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("#");
            Console.ResetColor();
            Console.WriteLine(" Error: Item to remove not found.");
            return false;
        }
        public string BoxExist(Box box)
        {
            if (boxes.Contains(box, new BoxSameDimensions()) || boxes.Contains(box, new BoxSameVol()))
            {
                return "The collection does contain your input!";
            }
            return "The collection does not contain your input!";
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return boxes.GetEnumerator();
        }
       
        //Nested class
        private class BoxEnumerator : IEnumerator<Box>
        {
            private readonly List<Box> _boxes;
            private int _currentIndex = -1;
            public Box Current => _boxes[_currentIndex];
            public BoxEnumerator(BoxCollection boxCollection)
            {
                _boxes = boxCollection.boxes;
            }

            object IEnumerator.Current => Current;

            public void Dispose()
            {
             
            }

            public bool MoveNext()
            {
                _currentIndex++;
                return _currentIndex < _boxes.Count;
            }

            public void Reset()
            {
                _currentIndex = -1;
            }

        }
    }
}
