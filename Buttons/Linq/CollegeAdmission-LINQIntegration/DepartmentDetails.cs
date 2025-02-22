using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionProgram
{
    public class DepartmentDetails
    {
        /// <summary>
        /// Field s_departmentID is used for auto increment all department instance
        /// </summary>
        private static int s_departmentID=101;

        /// <summary>
        /// Property DepartmentID used to provide user ID for an instance of <see cref="DepartmentDetails"/>
        /// </summary>
        public string DepartmentID{get;set;}

        /// <summary>
        /// Property DepartmentName used to provide department name for an instance of <see cref="DepartmentDetails"/>
        /// </summary>
        public string DepartmentName{get;set;}

        /// <summary>
        /// Property NumberOfSeats used to provide number of seats for an instance of <see cref="DepartmentDetails"/>
        /// </summary>
        public int NumberOfSeats{get;set;}

        /// <summary>
        /// Used to initialize properties using parameter values for an instance of <see cref="DepartmentDetails"/>
        /// </summary>
        /// <param name="departmentName">Parameter departmentName is a string , it is used to assign values to property DepartmentName</param>
        /// <param name="numberOfSeats">Parameter numberOfSeats is a int , it is used to assign values to property NumberOfSeats</param> <summary>
        public DepartmentDetails(string departmentName, int numberOfSeats)
        {
            DepartmentID=$"DID{++s_departmentID}";
            DepartmentName=departmentName;
            NumberOfSeats=numberOfSeats;
        }
    }
}