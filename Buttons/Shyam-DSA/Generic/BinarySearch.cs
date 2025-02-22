using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Threading.Tasks;

using SyncCET;

namespace CollegeAdmissionList
{
    public class SearchUtility<Type>
    {

        public static int BinarySearch(CustomList<Type> list,string key,string propertyName,out Type element)
        {
            element =default(Type);
            int left=0, right=list.Count-1;
            while(left<=right)
            {
                int middle=left+(right-left)/2;
                //get the property value of the specified property name
                //object middleValue=GetPropertyValue1(list[middle],propertyName);
                object middleValue=list[middle].GetType().GetProperty(propertyName).GetValue(list[middle],null);
                if(middleValue!=null)
                {
                    int comparisionResult=middleValue.ToString().CompareTo(key);
                    if(comparisionResult==0)
                    {
                        element=list[middle];
                        return middle;
                    }
                    if(comparisionResult<0)
                    {
                        left=middle+1;
                    }
                    else
                    {
                        right=middle-1;
                    }
                }
            }
            return -1;
        }

       
    }
}
