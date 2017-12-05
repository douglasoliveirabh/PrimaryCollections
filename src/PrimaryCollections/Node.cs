
using System;


namespace PrimaryCollections
{
    public class Node {
        public Node Next { get; set; }              
        public object Data { get; private set; }

        public Node(object data)
        {
            this.Data = data;
        }        

    }
}