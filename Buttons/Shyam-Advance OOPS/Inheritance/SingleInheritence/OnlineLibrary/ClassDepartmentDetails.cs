using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class ClassDepartmentDetails
    {
        /*DepartmentID, DepartmentName, Degree*/
        private static int s_departmentID=0;
        public int DepartmentID { get; set; }

        public string DepartmentName { get; set; }
        public string Degree { get; set; }
        public ClassDepartmentDetails(){}
        public ClassDepartmentDetails(string departmentName,string degree)
        {
            DepartmentID=++s_departmentID;
            DepartmentName=departmentName;
            Degree=degree;
        }
        public ClassDepartmentDetails(int departmentID,string departmentName,string degree)
        {
            DepartmentID=departmentID;
            DepartmentName=departmentName;
            Degree=degree;
        }
        public string DisplayClassDetails()
        {
            return $"DepartmentID :{DepartmentID}\nDepartment Name :{DepartmentName}\nDegree :{Degree}";
        }
    }
}