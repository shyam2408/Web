using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeAdmissionProgram;

public class Operations
{
    //create a list to store all students, departments and admissions
    public static List<StudentDetails> students = [];
    public static List<DepartmentDetails> departments = [];
    public static List<AdmissionDetails> admissions = [];
    //creat currentLoggedInStudent to access the user every where in the program
    public static StudentDetails currentLoggedInStudent;

    public static void DefaultData()
    {
        //add the default values of students given to the list
        StudentDetails student1 = new("Ravi E", "Ettapparajan", GenderDetails.Male, new DateTime(1999, 11, 16), "9870893412", "ravi@gmail.com", 92, 98, 91);
        StudentDetails student2 = new("Baskaran S", "Sethurajan", GenderDetails.Male, new DateTime(1999, 11, 17), "3245760098", "boss@gmail.com", 91, 97, 90);
        students.AddRange([student1, student2]);

        //add the default values of departments given to the list
        DepartmentDetails department1 = new("EEE", 29);
        DepartmentDetails department2 = new("CSE", 29);
        DepartmentDetails department3 = new("MECH", 30);
        DepartmentDetails department4 = new("ECE", 30);
        DepartmentDetails department5 = new("AE", 25);
        departments.AddRange([department1, department2, department3, department4, department5]);

        //add the default values of admissions given to the list
        AdmissionDetails admission1 = new("SF3001", "DID101", new DateTime(2024, 05, 11), AdmissionStatus.Booked);
        AdmissionDetails admission2 = new("SF3002", "DID102", new DateTime(2024, 05, 12), AdmissionStatus.Cancelled);
        admissions.AddRange([admission1, admission2]);

    }

    public static void MainMenu()
    {
        while (true)
        {
            //display main menu options
            Console.WriteLine("\n***** Main Menu *****");
            Console.WriteLine("Select: \n1. Registeration\n2. Login\n3. Exit");
            switch (Convert.ToInt32(Console.ReadLine()))//get the option inside the switch
            {
                case 1:
                    {
                        //call register method to register user
                        Register();
                        break;
                    }
                case 2:
                    {
                        //call login method to login user
                        Login();
                        break;
                    }
                case 3:
                    {
                        //exit application
                        Console.WriteLine("Exiting the application.");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice.Try again.");
                        break;
                    }
            }
        }
    }

    public static void Register()
    {
        //get all student details for registeration
        Console.WriteLine("\n***** User Registeration *****");
        Console.WriteLine("Enter Name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Father Name");
        string fatherName = Console.ReadLine();
        Console.WriteLine("Enter gender ");
        GenderDetails gender = Enum.Parse<GenderDetails>(Console.ReadLine(), true);
        Console.WriteLine("Enter Mobile Number");
        string mobileNumber = Console.ReadLine();
        Console.WriteLine("Enter EmailID");
        string emailID = Console.ReadLine();
        Console.WriteLine("Enter Physics");
        int physics = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Chemistry");
        int chemistry = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Maths");
        int maths = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter D.O.B");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        //get the details of the student and add the details to an object, add the object to students list
        StudentDetails student = new(name, fatherName, gender, dob, mobileNumber, emailID, physics, chemistry, maths);
        students.Add(student);
        Console.WriteLine($"Registration Successfull.{student.StudentID}");
    }

    public static void Login()
    {
        Console.WriteLine("\n***** User Login *****");
        //get the user id to login
        Console.WriteLine($"Enter your Reagistration ID:");
        string studentID = Console.ReadLine().ToUpper();
        //if student found, set found as true and show Sub Menu
        var student = students.FirstOrDefault(s => s.StudentID == studentID);
        if (student != null)
        {
            Console.WriteLine($"Login successful! {student.Name}");
            //set currentLoggedInCustomer
            currentLoggedInStudent = student;
            SubMenu();
        }
        else
        {
            //if user not found display invalid user
            Console.WriteLine("Invalid User ID");
        }
    }

    public static void SubMenu()
    {
        while (true)
        {
            //display the sub menu options to user
            Console.WriteLine("\n***** Main Menu *****");
            Console.WriteLine("Select Option: \n1. Check Eligibility\n2. Show Details\n3. Take Admission\n4. Cancel Admission\n5. Show Admission History\n6. Exit");
            switch (Convert.ToInt32(Console.ReadLine()))//get the option
            {
                case 1:
                    {
                        //check for eligibility of the student 
                        CheckEligibility();
                        break;
                    }
                case 2:
                    {
                        //show details of the student
                        ShowDetails();
                        break;
                    }
                case 3:
                    {
                        //call method to add admission
                        TakeAdmission();
                        break;
                    }
                case 4:
                    {
                        //call method to cancel the admission
                        CancelAdmission();
                        break;
                    }
                case 5:
                    {
                        //call method to display admission history
                        ShowAdmissionHistory();
                        break;
                    }
                case 6:
                    {
                        //exit submenu
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice.Try again.");
                        break;
                    }
            }
        }
    }

    public static void CheckEligibility()
    {
        //using the class method IsEligible to check eligibility of the student
        Console.WriteLine(currentLoggedInStudent.IsEligible() ? "You are eligible for admission." : "You are not eligible.");
    }

    public static void ShowDetails()
    {
        //Show all details of the student
        Console.WriteLine($"StudentID:{currentLoggedInStudent.StudentID}\nName:{currentLoggedInStudent.Name}\nFather Name:{currentLoggedInStudent.FatherName}\nGender:{currentLoggedInStudent.Gender}\nDOB:{currentLoggedInStudent.DOB:dd/MM/yyyy}\nMobile Number:{currentLoggedInStudent.MobileNumber}\nEmail:{currentLoggedInStudent.EmailID}\nPhysics:{currentLoggedInStudent.Physics}\nChemistry:{currentLoggedInStudent.Chemistry}\nMaths:{currentLoggedInStudent.Maths}");
    }

    public static void TakeAdmission()
    {
        Console.WriteLine("Take Admission");
        //show department details
        Console.WriteLine("Department Details:");
        departments.ForEach(dep => Console.WriteLine($"| {dep.DepartmentID,-15} |  {dep.DepartmentName,-15} | {dep.NumberOfSeats,-15} |"));
        //get the department id
        Console.WriteLine("Give department id :");
        string departementID = Console.ReadLine().ToUpper();
        //traverse and check department id is valid or not
        var department = departments.FirstOrDefault(dep => dep.DepartmentID == departementID);
        if (department != null)
        {
            //if valid check seat availability in department
            if (department.NumberOfSeats > 0)
            {
                //if seats available check student is eligible or not
                if (currentLoggedInStudent.IsEligible())
                {
                    //if he took admission then show alresdy tok admission
                    //if not taken admission then reduce department seat
                    var addmisionTaken = admissions
                    .Any(a => a.StudentID == currentLoggedInStudent.StudentID && a.AdmissionStatus == AdmissionStatus.Booked);
                    if (addmisionTaken)
                    {
                        Console.WriteLine("You already taken admission");
                    }
                    else
                    {
                        //decrement number of seats by 1
                        department.NumberOfSeats--;
                        AdmissionDetails admission = new(currentLoggedInStudent.StudentID, department.DepartmentID, DateTime.Now, AdmissionStatus.Booked);
                        admissions.Add(admission);
                        //create admission object then add to admissions list
                        //show admission taken successfully
                        Console.WriteLine($"Admission Successful. Your admission ID:{admission.AdmissionID}");

                    }
                }
                else { Console.WriteLine("You are not eligible for taking admission."); }
            }
            else { Console.WriteLine("All seats are filled already!."); }
        }
        else { Console.WriteLine("Department ID is invalid."); }
    }

    public static void CancelAdmission()
    {
        Console.WriteLine("Cancel Admission");
        Console.WriteLine("Are you sure want to cancel your admission");
        if (Console.ReadLine().Equals("YES", StringComparison.CurrentCultureIgnoreCase))
        {
            //traverse and find the current login students admission entry whose status is booked
            var addmisionToCancel = admissions
            .FirstOrDefault(a => a.StudentID.Equals(currentLoggedInStudent.StudentID) && a.AdmissionStatus.Equals(AdmissionStatus.Booked));
            if (addmisionToCancel != null)
            {
                //if found return seat to department
                var departmentToUpdate = departments.FirstOrDefault(d => d.NumberOfSeats >= 0);

                if (departmentToUpdate != null)
                {
                    departmentToUpdate.NumberOfSeats++;
                    //change admission status to cancelled
                    addmisionToCancel.AdmissionStatus = AdmissionStatus.Cancelled;
                    Console.WriteLine("Cancelled admission successfully.");
                }
            }
            else { Console.WriteLine("No admission history found"); }
        }
    }

    public static void ShowAdmissionHistory()
    {
        Console.WriteLine("Admission History:");
        //traverse list of admissions taken by user
        //if there no admission details then show no admission history found
        var studentAdmissions = admissions.Where(a => a.StudentID == currentLoggedInStudent.StudentID).ToList();
        if (studentAdmissions.Any())
        {
            studentAdmissions.ForEach(admissionData =>
            Console.WriteLine($"| {admissionData.AdmissionID,-15} |  {admissionData.StudentID,-15} | {admissionData.DepartmentID,-15} | {admissionData.AdmissionDate.ToString("dd/MM/yyyy"),-15} | {admissionData.AdmissionStatus,-15} |")
            );
        }
        else { Console.WriteLine("No admission history found"); }
    }
}
