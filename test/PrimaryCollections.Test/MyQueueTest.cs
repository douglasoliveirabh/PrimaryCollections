using System;
using PrimaryCollections;
using Xunit;

namespace PrimaryCollections.Test
{
    public class MyQueueTest
    {
        private MyQueue myTestQueue;

        public MyQueueTest(){
            myTestQueue = new MyQueue();
        }

        [Fact]
        public void Queued_Object_Should_Be_Equals_Dequeued_Object()
        {            
            dynamic paciente = new { Name = "Douglas"};
            myTestQueue.Enqueue(paciente); 
            dynamic objDequeued = myTestQueue.Dequeue();
            Assert.True(paciente.Name == objDequeued.Name);
        }

        [Fact]
        public void Last_Queued_Object_Should_Be_Equals_Last_Dequeued_Object(){

            dynamic person1 = new { Name = "Douglas"};
            dynamic person2 = new { Name = "Rafael"};
            dynamic person3 = new { Name = "Fred"};

            myTestQueue.Enqueue(person1); 
            myTestQueue.Enqueue(person2); 
            myTestQueue.Enqueue(person3); 

            dynamic objDequeued1 = myTestQueue.Dequeue();
            dynamic objDequeued2 = myTestQueue.Dequeue();
            dynamic objDequeued3 = myTestQueue.Dequeue();

            Assert.True(person1.Name == objDequeued1.Name);
            Assert.True(person2.Name == objDequeued2.Name);
            Assert.True(person3.Name == objDequeued3.Name); 

        }

        [Fact]
        public void Stack_Lenght_Should_Be_Equals_Quantity_Of_Push_Objects(){
            dynamic person1 = new { Name = "Douglas"};
            dynamic person2 = new { Name = "Rafael"};
            dynamic person3 = new { Name = "Fred"};

            myTestQueue.Enqueue(person1); 
            myTestQueue.Enqueue(person2); 
            myTestQueue.Enqueue(person3); 

             Assert.True(myTestQueue.Lenght == 3);            
             Assert.False(myTestQueue.Lenght != 3);
        }
        

    }
}