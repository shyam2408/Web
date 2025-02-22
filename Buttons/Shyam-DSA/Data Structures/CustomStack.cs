using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CustomStack
{
    public class Stack<Type>
    {
        private int _capacity;
        private int _top;
        public int Capacity { get{return _capacity;} }
        public int Count { get{return _top+1;} }

        private Type[] _array;

        public Stack()
        {
            _top=-1;
            _capacity=4;
            _array= new Type[_capacity];
        }
        public Stack(int size)
        {
            _top=-1;
            _capacity=size;
            _array= new Type[_capacity];
        }
        public void Push(Type value)
        {
            if (_top+1==_capacity)
            {
                GrowSize();
            }
            _array[_top+1]=value;
            _top++;
        }
        void GrowSize()
        {
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_top;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public Type peek()
        {
            if (_top==-1)
            {
                return default(Type);
            }
            else
            {
                return _array[_top];
            }
        }
        public Type Pop()
        {
            if (_top==-1)
            {
                return default(Type);
            }
            else
            {
                _top--;
                return _array[_top];
            }
        }
    }
}