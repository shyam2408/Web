using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncLibrary
{
    public  class SearchUtility<Type>
    {
        public static int BinarySearch(CustomList<Type> list,string key,string propertyName,out Type element)
        {
            //returning default value of that type
            element=default(Type);
            //initizializing left and right variable
            int left=0, right=list.Count-1;
            //starting condition
            while(left<=right)
            {
                //finding middle value
                int mid=left+(right-left)/2;
                //finding middle of the object in the list
                object midllevalue=list[mid].GetType().GetProperty(propertyName).GetValue(list[mid],null);

                //condition for checking list not null or null object
                if(midllevalue!=null)
                {
                    int comparision=midllevalue.ToString().CompareTo(key);
                    if(comparision==0)
                    {
                        element=list[mid];
                        return mid;
                    }
                    else if(comparision>0)
                    {
                        right=mid-1;//checking in the left part
                    }
                    else
                    {
                        left=mid +1;//checking in the right part
                    }
                }
            }
            return -1;
        }

        
    }
}