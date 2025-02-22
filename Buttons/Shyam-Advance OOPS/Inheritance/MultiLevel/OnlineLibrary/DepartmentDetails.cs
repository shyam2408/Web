using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class DepartmentDetails
    {
        private static int s_departmentID = 0;
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string Degree { get; set; }
        public DepartmentDetails() { }
        public DepartmentDetails(string departmentName, string degree)
        {
            DepartmentID = ++s_departmentID;
            DepartmentName = departmentName;
            Degree = degree;
        }
        public DepartmentDetails(int departmentID, string departmentName, string degree)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
            Degree = degree;
        }
        public string DisplayDepartmentDetails()
        {
            return $"DepartmentID :{DepartmentID}\nDepartment Name :{DepartmentName}\nDegree :{Degree}";
        }

    }
}