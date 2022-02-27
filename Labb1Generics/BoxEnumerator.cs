using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Labb1Generics
{
    public class BoxEnumerator : IEnumerator<Box>
    {

        private BoxCollection Boxes;
        private int currentIndex;
        private Box currentBox;

        public BoxEnumerator(BoxCollection boxes)
        {
            this.Boxes = boxes;
            this.currentIndex = -1;
            this.currentBox = default(Box);
        }
        public Box Current 
        {
            get
            {
                return currentBox;
            }
        }

        object IEnumerator.Current { get { return Current; } }

        public int Count 
        {
            get
            {
                return Boxes.Count;
            }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (++currentIndex >= Boxes.Count)
            {
                return false;
            }
            else
            {
                currentBox = Boxes[currentIndex];
                return true;               
            }
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
