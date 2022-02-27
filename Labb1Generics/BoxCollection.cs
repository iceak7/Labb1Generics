using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1Generics
{
    public class BoxCollection : ICollection<Box>
    {
        public int Count { get { return Boxes.Count; } }

        public bool IsReadOnly { get { return false; } }

        private List<Box> Boxes;

        public BoxCollection()
        {
            Boxes = new List<Box>();
        }

        public void Add(Box item)
        {
            if (!Contains(item))
            {
                Boxes.Add(item);
            }
            else
            {
                Console.WriteLine("\nBoxen finns redan.");
            }
        }

        public void Clear()
        {
            Boxes.Clear();
        }

        public bool Contains(Box item)
        {
            bool contains = false;

            foreach (Box b in Boxes)
            {
                if (b.Equals(item))
                {
                    contains = true;
                }
            }
            return contains;
        }

        public bool Contains(BoxSameVolume sameVolumeComprarer, Box item)
        {
            bool sameValueResult = false;
            foreach (Box box in Boxes)
            {
                if (sameVolumeComprarer.Equals(item, box))
                {
                    sameValueResult = true;
                }
            }

            return sameValueResult;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            if (array == null)
            {
                throw new ArgumentNullException("The array cannot be null.");
            }
            if (arrayIndex < 0)
            {
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            }
            if (Count > array.Length - arrayIndex + 1)
            {
                Console.WriteLine("The destination array has fewer elements than the collection.");
            }
            for (int i = 0; i < Boxes.Count; i++)
            {
                array[i + arrayIndex] = Boxes[i];
            }
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false;
            for (int i = 0; i < Boxes.Count; i++)
            {
                Box currentBox = Boxes[i];
                if(new BoxSameDimensions().Equals(item, currentBox))
                {
                    Boxes.RemoveAt(i);
                    result = true;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public Box this[int index]
        {
            get { return (Box)Boxes[index]; }
            set { Boxes[index] = value; }
        }
    }
}
