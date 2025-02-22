using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Queue
{
    public class CustomQueue<Type>:IEnumerable,IEnumerator
    {
        private int _head;
        private int _tail;
        private int _capacity;
        private int _count;
        public int Count { get{return _count;} }
        private Type[] _array;
        public CustomQueue()
        {
            _head=0;
            _tail=0;
            _capacity=4;
            _count=0;
            _array=new Type[_capacity];
        }
        public CustomQueue(int size)
        {
            _head=0;
            _tail=0;
            _capacity=size;
            _count=0;
            _array=new Type[_capacity];
        }
        public void Enqueue(Type value)
        {
            if (_tail==_capacity)
            {
                GrowSize();
            }
            _array[_tail]=value;
            _tail++;
            _count++;
        }
        void GrowSize()
        {
            _capacity*=2;
            Type[] temp=new Type[_capacity];
            for (int i=_head;i<_tail;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public Type Peek()
        {
            if (_head==_tail)
            {
                return default(Type);
            }
            else
            {
                return _array[_head]; 
            }
        }
        public Type Dequeue()
        {
            if (_tail==_head)
            {
                return default(Type);
            }
            else
            {
                _head++;
                _count--;
                return _array[_head-1];
            }
        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position=_head-1;
            return (IEnumerator) this;//returning type of this array
        }
        public bool MoveNext()
        {
            if(position<_tail-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position=_head-1;
        }
        public object Current{get {return _array[position];}}
    }
}