using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionProgram
{
    /// <summary>
    /// Enum AdmissionStatus of student contains- Select, Booked, Cancelled <see cref="AdmissionStatus"/> used to create data type for user's Admission Status
    /// </summary>
    public enum AdmissionStatus
    {
        Select, Booked, Cancelled
    }
    public class AdmissionDetails
    {
        /// <summary>
        /// Field s_admissionID is used for auto increment Admission instance
        /// </summary>
        private static int s_admissionID=1001;

        /// <summary>
        /// Property AdmissionID used to provide Admission ID for an instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public string AdmissionID{get;set;}

        /// <summary>
        /// Property StudentID used to provide Student ID for an instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public string StudentID{get;set;}

        /// <summary>
        /// Property DepartmentID used to provide Department ID for an instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public string DepartmentID{get;set;}

        /// <summary>
        /// Property AdmissionDate used to provide Admission Date for an instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public DateTime AdmissionDate{get;set;}

        /// <summary>
        /// Property AdmissionStatus used to provide Admission Status for an instance of <see cref="AdmissionDetails"/>
        /// </summary>
        public AdmissionStatus AdmissionStatus{get;set;}

        /// <summary>
        /// Used to initialize properties using parameter values for an instance of <see cref="AdmissionDetails"/>
        /// </summary>
        /// <param name="studentID">Parameter studentID is a string , it is used to assign values to property StudentID</param>
        /// <param name="departementID">Parameter departmentName is a string , it is used to assign values to property DepartmentName</param>
        /// <param name="admissionDate">Parameter admissionDate is a date , it is used to assign values to property AdmissionDate</param>
        /// <param name="admissionStatus">Parameter admissionStatus is a enum AdmissionStatus<see cref="AdmissionStatus"/></param>
        public AdmissionDetails(string studentID, string departementID, DateTime admissionDate, AdmissionStatus admissionStatus)
        {
            AdmissionID=$"AID{++s_admissionID}";
            StudentID=studentID;
            DepartmentID=departementID;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;
        }

    }
}