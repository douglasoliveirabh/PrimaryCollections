using System;

namespace PrimaryCollections
{
    public class Queue
    {        
        private Node First;
        private Node Last;

        public Queue()
        {
            this.First = null;
            this.Last = null;
        }

        public int Lenght
        {
            get { 
                var lenght = 0;

                if(First != null){
                    var actualNode = First;
                    do{                    
                        lenght ++;
                        actualNode = actualNode.Next;
                    }while(actualNode != null);
                }
                
                return lenght;
            }            
        }

        public void Enqueue(object item){
            var newNode = new Node(item);

            if(Last == null)
                First = newNode;
            else
                Last.Next = newNode;

            Last = newNode;       
        }

        public object Dequeue(){
            var returnObj = First;

            if(returnObj == null)
                return null;
            else {                
                First = First.Next;
                returnObj.Next = null;
            }
                    
            return returnObj.Data;
        }

    }
}