using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ListDataStructures
{
    public partial class CustomList<Type>
    {
        private int _count;
        private int _capacity;
        public int Count { get { return _count; } }
        public int Capacity { get { return _capacity; } }
        private Type[] _array;
        public Type this[int index]
        {
            get => _array[index];
            set { _array[index] = value; }
        }
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }
        public void Add(Type value)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count] = value;
            _count++;
        }
        void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < _count + elements._count; k++)
            {
                temp[i] = elements[k];
                k++;
            }
            _array = temp;
            _count = _count + elements.Count;
        }
        public bool Contain(Type value)
        {
            bool temp=false;
            foreach(Type data in _array)
            {
                if(data.Equals(value))
                {
                    temp=true;
                    break;
                }
            }
            return temp;
        }
        public int IndexOf(Type value)
        {
            int index=-1;
            for(int i=0; i<_count;i++)
            {
                if (value.Equals(_array[i]))
                {
                    index=i;
                }
            }
            return index;
        }
        public void Insert(int position,Type value)
        {
            _capacity=_capacity+1+4;
            Type [] temp =new Type[_capacity];
            for(int i=0;i<_count+1;i++)
            {
                if (i<position)
                {
                    temp[i]=_array[i];
                }
                else if(i==position)
                {
                    temp[i]=_array[i];
                }
                else
                {
                    temp[i]=_array[i-1];
                }
            }
            _count++;
            _array=temp;
        }
        public void RemoveAt(int position)
        {
            for(int i=0;i<_count-1;i++)
            {
                if(i>=position)
                {
                    _array[i]=_array[i+1];
                }
            }
            _count--;
        }
        public bool Remove(Type element)
        {
            int position=IndexOf(element);
            if(position>0)
            {
                RemoveAt(position);
                return true;
            }
            return false;
        }
        public void Reverse()
        {
            Type [] temp =new Type[_capacity];
            int j=0;
            for(int i=_count-1;i>=0;i--)
            {
                temp[j]=_array[i];
                j++;
            }
            _array=temp;
        }
        public void InsertRange(int position,CustomList<Type> elements)
        {
            _capacity=_count+elements.Count+4;
            Type [] temp =new Type[_capacity];
            for(int i=0;i<position;i++)
            {
                temp[i]=_array[i];
            }
            int j=0;
            for(j=position;j<position+elements.Count;j++)
            {
                temp[j]=elements[j];
                j++;
            }
            int k=0;
            for(k=position+elements.Count;k<_count+elements.Count;k++)
            {
                temp[k]=_array[k];
                k++;
            }
            _array=temp;
            _count=_count+elements.Count;
        }
        public void sort()
        {
            for(int i=0;i<_count-1;i++)
            {
                for(int j=0;j<_count-1;j++)
                {
                    if(IsGreater(_array[j],_array[j+1]))
                    {
                        Type temp=_array[j+1];
                        _array[j+1]=_array[j];
                        _array[j]=temp;
                    }
                }
            }
        }
        public bool IsGreater(Type value,Type value1)
        {
            int result=Comparer<Type>.Default.Compare(value,value1);
            //value is greater =1,value is les =1,equla=0
            if(result>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}