using System;
using PrimaryCollections;
using Xunit;

namespace PrimaryCollections.Test
{
    public class MyStackTest
    {
        private MyStack myTestStack;

        public MyStackTest()
        {
            this.myTestStack = new MyStack();
        }

        [Fact]
        public void Pushed_Object_Should_Be_Equals_Popped_Object()
        {            
            dynamic paciente = new { Name = "Douglas"};
            myTestStack.Push(paciente); 
            dynamic objPoped = myTestStack.Pop();
            Assert.True(paciente.Name == objPoped.Name);
        }

        [Fact]
        public void Last_Pushed_Object_Should_Be_Equals_First_Popped_Object(){
             
            dynamic paciente = new { Name = "Douglas"};
            dynamic paciente2 = new { Name = "Rafael"};
            dynamic paciente3 = new { Name = "Fred"};

            myTestStack.Push(paciente); 
            myTestStack.Push(paciente2); 
            myTestStack.Push(paciente3); 

            dynamic objPopped = myTestStack.Pop();
            dynamic objPopped2 = myTestStack.Pop();
            dynamic objPopped3 = myTestStack.Pop();

            Assert.True(paciente.Name == objPopped3.Name);
            Assert.True(paciente2.Name == objPopped2.Name);
            Assert.True(paciente3.Name == objPopped.Name);                       
        }

        [Fact]
        public void Stack_Lenght_Should_Be_Equals_Quantity_Of_Push_Objects(){
            dynamic paciente = new { Name = "Douglas"};
            dynamic paciente2 = new { Name = "Rafael"};
            dynamic paciente3 = new { Name = "Fred"};

            myTestStack.Push(paciente); 
            myTestStack.Push(paciente2); 
            myTestStack.Push(paciente3); 

             Assert.True(myTestStack.Lenght == 3);            
             Assert.False(myTestStack.Lenght != 3);
        }
    }
}
