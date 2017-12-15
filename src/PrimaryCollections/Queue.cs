using System;

namespace PrimaryCollections
{
    public class Queue
    {
        private Node _first;
        private Node _last;

        public int Lenght { get; private set; }

        public void Enqueue(object item, int weight)
        {
            var newNode = new Node(item, weight);

            if (_last == null)
            {
                _last = newNode;
                _first = _last;
            }
            else if (_last.Weight >= newNode.Weight)
            {
                _last.Next = newNode;
                _last = _last.Next;
            }
            else if(_first.Weight <= newNode.Weight){

                newNode.Next = _first;
                _first = newNode;                                
            }
            else
            {
                var aux = _first;
                while (aux.Next != null && aux.Next.Weight >= newNode.Weight)                                
                    aux = aux.Next;                

                newNode.Next = aux.Next;
                aux.Next = newNode;                            
            }

            Lenght += 1;
        }

        public void Enqueue(object item)
        {
            var newNode = new Node(item);

            if (_last == null)
            {
                _last = newNode;
                _first = _last;
            }
            else
            {
                _last.Next = newNode;
                _last = _last.Next;
            }

            Lenght += 1;
        }

        public object Dequeue()
        {
            var returnObj = _first;

            if (returnObj != null)
            {
                _first = _first.Next;
                returnObj.Next = null;
                Lenght -= 1;
            }

            return returnObj == null ? returnObj : returnObj.Data;
        }

    }
}