using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public partial class CustomList<Type>
    {
        //fields 
        private int _count;

        private int _capacity;
        private Type[] _array;

        //properties

        public int Count { get {return _count;} set{_count = value;} }

        public int Capacity { get{return _capacity ;} set{_capacity = value;} }
        
        //inderex
        public Type this[int index]
        {
            get{return _array[index];}
            set{_array[index] = value;}
        }
       
        //constructor
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count = 0 ;
            _capacity = size;
            _array = new Type[_capacity];
        }
        
        //Methods
        public void Add(Type element)
        {
            if(_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = element ;
            _count++;
        }

        private void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for(int i=0;i <_count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;

            Type[] temp = new Type[_capacity];
            for(int i = 0 ; i <_count ; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0  ;
            for(int i = _count ; i < _count +elements.Count ; i++)
            {
                temp[i] = elements[k] ;
                k++;
            }

            _array = temp;
            _count += elements.Count;
        }

        public bool Contains(Type element)
        {
            for(int i = 0  ; i< _count ;i++)
            {
                if(_array[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(Type element)
        {
            for(int i = 0  ; i< _count ;i++)
            {
                if(_array[i].Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int position,Type element)
        {
            

            for(int i = position; i< _count -1; i++)
            {
                _array[i] = _array[i-1];
            }     
        }

        public void Remove(Type element)
        {
            int position = IndexOf(element);
            RemoveAt(position , element);
        }
    }
}