
using System;


namespace PrimaryCollections
{
    public class Node {
        public Node Next { get; set; }              
        public object Data { get; private set; }

        public int Weight { get;  private set; }

        public Node(object data)
        {
            this.Data = data;
            this.Weight = 0;
        }        

        public Node(object data, int weight) : this(data) 
        {                        
            this.Weight = weight;
        }        

    }
}