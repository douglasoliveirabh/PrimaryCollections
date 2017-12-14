using System;

namespace PrimaryCollections
{
    public class Stack
    {
        private Node _top;

        public int Lenght { get; private set; }


        public Stack()
        {
            this._top = null;
        }

        public void Push(object item)
        {
            var newNode = new Node(item);

            if (_top != null)
                newNode.Next = _top;

            _top = newNode;
            Lenght += 1;
        }

        public object Pop()
        {
            var returnObj = _top;

            if (returnObj != null)
            {
                Lenght -= 1;

                if (returnObj.Next != null)
                    _top = returnObj.Next;
            }

            return returnObj == null ? returnObj : returnObj.Data;
        }

    }
}
