
using System;

namespace CollegeAdministration;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo person=new PersonalInfo("vijay","ajith","24/08/2002","123456","male","vijay@gmail.com");
        System.Console.WriteLine(person.DisplayPersonalInfo());
        TeacherInfo teacher=new TeacherInfo("danush","simbu","28/08/2002","97865434","male","simbu@gmail.com","VISCOM","Maths","B.Tech","14");
        System.Console.WriteLine(teacher.DisplayTeacherInfo());
        StudentInfo student=new StudentInfo("shyam","edison","24/08/2002","98763e42","male","shyam@gamil.com","B.Tech","CSE","8th");
        System.Console.WriteLine(student.DisplayStudentInfo());
        PrincipalInfo principal=new PrincipalInfo("Rajini","Kamal","19/10/1992","234567","male","raajin@gmail.com","CSE",15,"19/10/2000");
        System.Console.WriteLine(principal.DisplayPricipal());
    }
}

