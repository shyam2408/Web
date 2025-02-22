using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections;

namespace SyncCET
{
    public class CustDictionary<TKey,TValue> : IEnumerable, IEnumerator
    {
        private int _count;
        private int _capacity;
        public int Count{ get{return _count;} }
        private KeyValue<TKey,TValue>[] _array;
        public TValue this[TKey key]
        {
            get
            {
                TValue value = default(TValue);
                LinearSearch(key, out value);
                return value;
            }
            set
            {
                int position = BinarySearch(key, out TValue value2);
                if(position > -1)
                {
                    _array[position].Value = value;
                }
            }
        }
        public int BinarySearch(TKey key, out TValue value1)
        {
            value1 = default(TValue);
             int left = 0, right = _array.Length-1;
            while(left <= right)
            {
                int middle = left + (right-left)/2;
                int result = Comparer<TKey>.Default.Compare(_array[middle].Key,key);
               if(result==0)
               {
                    value1 = _array[middle].Value;
                    return middle;

               }
               else if(result<0)
               {
                 left =middle+1;
               }
               else
               {
                 right=middle-1;
               }
                
            }
            return -1;
        }
        public CustDictionary()
        {
            _count = 0;
            _capacity = 4;
            _array = new KeyValue<TKey, TValue>[_capacity];
        }

        public CustDictionary(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new KeyValue<TKey, TValue>[_capacity];
        }

        public void Add(TKey key, TValue value)
        {
            if(_count == _capacity)
            {
                GrowSize();
            }
            int position = LinearSearch(key, out TValue value2);                //to find duplicate keys
            if(position == -1)
            {
                KeyValue<TKey,TValue>  data = new KeyValue<TKey, TValue>();
                data.Key = key;
                data.Value = value;
                _array[_count] = data;
                _count++;
            }
        }

        void GrowSize()
        {
            _capacity*=2;
            KeyValue<TKey,TValue>[] temp = new KeyValue<TKey,TValue>[_capacity];
            for(int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }

        int LinearSearch(TKey key, out TValue value)
        {
            int position = -1;
            value = default(TValue);
            for(int i=0; i<_count; i++)
            {
                if(key.Equals(_array[i].Key))
                {
                    position = i;
                    value = _array[i].Value;
                }
            }
            return position;
        }

        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator) this;
        }

        public bool MoveNext()
        {
            if(position < _count-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current { get{return _array[position];} }
    }
}