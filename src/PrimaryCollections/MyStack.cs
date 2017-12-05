using System;

namespace PrimaryCollections
{
    public class MyStack
    {
        private Node Top;

        public int Lenght
        {
            get { 
                var lenght = 0;

                if(Top != null){
                    var actualNode = Top;
                    do{                    
                        lenght ++;
                        actualNode = actualNode.Next;
                    }while(actualNode != null);
                }
                
                return lenght;
            }            
        }
        
        public MyStack(){
            this.Top = null;
        }

        public void Push(object item){            
            var newNode = new Node(item);

            if(Top == null){
                Top = newNode;
                return;
            }
            else{
                newNode.Next = Top;
                Top = newNode;                
            }                                        
        }

        public object Pop(){            
            var returnObj = Top;

            if(returnObj == null)
                return null;
            else if(returnObj.Next != null){                
                Top = returnObj.Next;
            }
                    
            return returnObj.Data;            
        }        

    }
}
