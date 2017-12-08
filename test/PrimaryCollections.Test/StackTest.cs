using System;
using PrimaryCollections;
using Xunit;

namespace PrimaryCollections.Test
{
    public class StackTest
    {
        private Stack myTestStack;
        private dynamic person1;
        private dynamic person2;
        private dynamic person3;

        public StackTest()
        {
            this.myTestStack = new Stack();
            this.person1 = new { Name = "Douglas"};
            this.person2 = new { Name = "Rafael"};
            this.person3 = new { Name = "Fred"};
        }

        [Fact]
        public void Pushed_Object_Should_Be_Equals_Popped_Object()
        {                        
            myTestStack.Push(person1); 
            dynamic poppedObject = myTestStack.Pop();
            Assert.True(person1.Name == poppedObject.Name);
        }

        [Fact]
        public void Last_Pushed_Object_Should_Be_Equals_First_Popped_Object(){
                         
            myTestStack.Push(person1); 
            myTestStack.Push(person2); 
            myTestStack.Push(person3); 

            dynamic poppedObj1 = myTestStack.Pop();
            dynamic poppedObj2 = myTestStack.Pop();
            dynamic poppedObj3 = myTestStack.Pop();

            Assert.True(person1.Name == poppedObj3.Name);
            Assert.True(person2.Name == poppedObj2.Name);
            Assert.True(person3.Name == poppedObj1.Name);                       
        }

        [Fact]
        public void Stack_Lenght_Should_Be_Equals_Quantity_Of_Push_Objects(){

            myTestStack.Push(person1); 
            myTestStack.Push(person2); 
            myTestStack.Push(person3); 

            Assert.True(myTestStack.Lenght == 3);                         
        }
    }
}
