using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionProgram
{
    /// <summary>
    /// Enum GenderDetails of student contains- Select, Male, Female, Transgender <see cref="GenderDetails"/> used to create data type for user's Gender
    /// </summary>
    public enum GenderDetails
    {
        Select, Male, Female, Transgender
    }
    public class StudentDetails
    {
        //Auto increment
        /// <summary>
        /// Field s_studentID is used for auto increment all student instance
        /// </summary>
        private static int s_studentID=3000;

        /// <summary>
        /// Property StudentID used to provide user ID for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public string StudentID{get;set;}

        /// <summary>
        /// Property Name used to provide name for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public string Name{get;set;}

        /// <summary>
        /// Property FatherNAme used to provide father name for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public string FatherName{get;set;}

        /// <summary>
        /// Property Gender used to provide gender for an instance of <see cref="GenderDetails"/>
        /// </summary>
        public GenderDetails Gender{get;set;}

        /// <summary>
        /// Property MobileNumber used to provide mobile number for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public string MobileNumber{get;set;}

        /// <summary>
        /// Property EmailID used to provide email ID for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public string EmailID{get;set;}

        /// <summary>
        /// Property DateTime used to provide date for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public DateTime DOB{get;set;}

        /// <summary>
        /// Property Physics used to provide physics mark for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public int Physics{get;set;}

        /// <summary>
        /// Property Chemistry used to provide chemistry mark for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public int Chemistry{get;set;}

        /// <summary>
        /// Property Maths used to provide maths mark for an instance of <see cref="StudentDatails"/>
        /// </summary>
        public int Maths{get;set;}

        
        /// <summary>
        /// Used to initialize properties using parameter values for an instance of <see cref="StudentDetails"/>
        /// </summary>
        /// <param name="name">Parameter name is a string , it is used to assign values to property Name</param>
        /// <param name="fatherName">Parameter fatherName is a string , it is used to assign values to property FatherName</param>
        /// <param name="gender">Parameter gender is a enum GenderDetails<see cref="GenderDetails"/></param>
        /// <param name="dob">Parameter dob is a date , it is used to assign values to property DOB</param>
        /// <param name="mobileNumber">Parameter mobileNumber is a string , it is used to assign values to property mobileNumber</param>
        /// <param name="emailId">Parameter emailId is a string , it is used to assign values to property emailId</param>
        /// <param name="physics">Parameter physics is a int , it is used to assign values to property Physics</param>
        /// <param name="chemistry">Parameter chemistry is a int , it is used to assign values to property Chemistry</param>
        /// <param name="maths">Parameter maths is a int , it is used to assign values to property Maths</param>
        public StudentDetails(string name, string fatherName, GenderDetails gender, DateTime dob,string mobileNumber,string emailId, int physics, int chemistry, int maths)
        {
            StudentID =$"SF{++s_studentID}";
            Name=name;
            FatherName=fatherName;
            Gender= gender;
            DOB = dob;
            MobileNumber=mobileNumber;
            EmailID=emailId;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
        
        /// <summary>
        /// Total() method is used to calculate the total marks of the instance
        /// </summary>
        /// <returns>This method returns sum of physics, chemistry and maths marks in int datatype.</returns>
        public int Total()
        {
            return Physics+Chemistry+Maths;
        }

        /// <summary>
        /// Average() method is used to calculate the average marks of the instance utilizing Total()
        /// </summary>
        /// <returns>This method returns the average of physics, chemistry and maths marks in double datatype.</returns>
        public double Average()
        {
           return Total()/3.0;
        }

        /// <summary>
        /// IsEligible() method is used to check if the marks physics, chemistry and maths average is greater than 75 
        /// </summary>
        /// <returns>Returns true if eligible and false if not eligible</returns>
        public bool IsEligible()
        {
            if(Average()>=75){
                return true;
            }
            return false;
        }
    }
}