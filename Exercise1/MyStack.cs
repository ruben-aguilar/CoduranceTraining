using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    internal class MyStack
    {
        private List<object> stackedObjects;

        public MyStack()
        {
            this.stackedObjects = new List<object>();
        }

        public object pop()
        {
            if (!stackedObjects.Any()) throw new EmptyException();

            var popedObject = stackedObjects.Last();
            stackedObjects.Remove(popedObject);

            return popedObject;
        }

        public void push(object objectToStore)
        {
            this.stackedObjects.Add(objectToStore);
        }
    }

    class EmptyException : Exception
    {

    }
}