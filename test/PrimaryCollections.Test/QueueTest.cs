using System;
using PrimaryCollections;
using Xunit;

namespace PrimaryCollections.Test
{
    public class QueueTest
    {
        private Queue myTestQueue;
        private dynamic person1;
        private dynamic person2;
        private dynamic person3;

        public QueueTest(){
            myTestQueue = new Queue();
            this.person1 = new { Name = "Douglas"};
            this.person2 = new { Name = "Rafael"};
            this.person3 = new { Name = "Fred"};
        }

        [Fact]
        public void Queued_Object_Should_Be_Equals_Dequeued_Object()
        {                        
            myTestQueue.Enqueue(person1); 
            dynamic dequeuedObject = myTestQueue.Dequeue();
            Assert.True(person1.Name == dequeuedObject.Name);
        }

        [Fact]
        public void Last_Queued_Object_Should_Be_Equals_Last_Dequeued_Object(){
           
            myTestQueue.Enqueue(person1); 
            myTestQueue.Enqueue(person2); 
            myTestQueue.Enqueue(person3); 

            dynamic dequeuedObj1 = myTestQueue.Dequeue();
            dynamic dequeuedObj2 = myTestQueue.Dequeue();
            dynamic dequeuedObj3 = myTestQueue.Dequeue();

            Assert.True(person1.Name == dequeuedObj1.Name);
            Assert.True(person2.Name == dequeuedObj2.Name);
            Assert.True(person3.Name == dequeuedObj3.Name);
        }

        [Fact]
        public void Stack_Lenght_Should_Be_Equals_Quantity_Of_Push_Objects(){
            
            myTestQueue.Enqueue(person1); 
            myTestQueue.Enqueue(person2); 
            myTestQueue.Enqueue(person3); 

            Assert.True(myTestQueue.Lenght == 3);                        
        }
        

    }
}