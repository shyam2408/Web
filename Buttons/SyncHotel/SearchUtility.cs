using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncHotel
{
    public class SearchUtility<Type>
    {
        public static int BinarySearch(CustomList<Type> list, string key, string propertyName, out Type element)
        {
            element = default(Type);

            int left= 0 , right = list.Count -1 ;

            while(left <= right)
            {
                int mid = (left +  right) / 2 ;

                object middleValue = list[mid].GetType().GetProperty(propertyName).GetValue(list[mid]);

                int result  = middleValue.ToString().CompareTo(key);

                if(result == 0 )
                {
                    element = list[mid];
                    return mid;
                }
                if(result < 0 )
                { 
                    left = mid+1;
                }
                else
                {
                    right = mid -1;
                }
            }
            return -1;
        }
    }
}