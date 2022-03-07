using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zensar.casestudy.day1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public Student()
        {
        }
        public Student(int Id, string Name, string DateOfBirth)
        {
            this.Id = Id;
            this.Name = Name;
            this.DateOfBirth = DateOfBirth;
        }
    }
    class Course
    {
        public int CID { get; set; }
        public string CName { get; set; }
        public string Duration { get; set; }
        public int Fees { get; set; }
        public Course()
        {
        }
        public Course(int CID, string CName, string Duration, int Fees)
        {
            this.CID = CID;
            this.CName = CName;
            this.Duration = Duration;
            this.Fees = Fees;
        }
    }
    class Info
    {
        public void display(Student s1)
        {
            Console.WriteLine("Student Details :");
            Console.WriteLine("Student ID:" + s1.Id);
            Console.WriteLine("Student Name:" + s1.Name);
            Console.WriteLine("Student DOB:" + s1.DateOfBirth);
            Console.WriteLine();
        }
        public void Display(Course c)
        {
            Console.WriteLine("Course Details: \n");
            Console.WriteLine("Course ID: " + c.CID);
            Console.WriteLine("Course Name: " + c.CName);
            Console.WriteLine("Course Duration: " + c.Duration);
            Console.WriteLine("Course Fees: " + c.Fees);
            Console.WriteLine();
        }
    }
    class Enroll
    {
        private Student student { get; set; }
        private Course course { get; set; }
        private DateTime enrollmentDate { get; set; }
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrollmentDate;
        }
    }

    abstract class UserInterface
    {
        public abstract void showFirstScreen();
        public abstract void showStudentScreen();
        public abstract void showAdminScreen();
        public abstract void showAllStudentsScreen();
        public abstract void showStudentRegistrationScreen();
        public abstract void introduceNewCourseScreen();
        public abstract void showAllCoursesScreen();
    }

    class App
    {
        public static void Scenario_1()
        {
            Console.WriteLine("----------------Student Class Scenario1------------------");
            Info info = new Info();
            Student st = new Student(1, "Akhil", "08-08-1997");
            info.display(st);
            Student st1 = new Student(2, "Bhanu", "15-09-1990");
            info.display(st1);
            Student st2 = new Student(3, "Chaithu", "25-04-1998");
            info.display(st2);
        }
        public static void Scenario_2()
        {
            Console.WriteLine("------------------Student Class Scenario 2---------------");
            Student[] Stud = new Student[3];
            Info info1 = new Info();
            Stud[0] = new Student(4, "Gopi", "01-04-1999");
            Stud[1] = new Student(5, "Naveen", "05-08-1997");
            Stud[2] = new Student(6, "shiva", "21-05-1998");
            for (int i = 0; i < Stud.Length; i++)
            {



                info1.display(Stud[i]);
                Console.WriteLine();
            }
        }
        public static void Scenario_3()
        {
            Console.WriteLine("---------------Student Class Scenario 3-----------------");
            Console.WriteLine("Enter n Value to insert student details");
            int n = Convert.ToInt32(Console.ReadLine());
            Student[] std = new Student[n];
            for (int i = 0; i < std.Length; i++)
            {
                Console.WriteLine("Enter Student ID: ");
                int ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name of the Student: ");
                string Name = Console.ReadLine();
                Console.WriteLine("Enter Student Date of Birth:");
                string DOB = Console.ReadLine();
                Student s1 = new Student(ID, Name, DOB);
                std[i] = s1;
            }
            foreach (var r in std)
            {
                Console.WriteLine("\nStudent ID:{0}\nStudent Name:{1}\nStudent DOB:{2}\n", r.Id, r.Name, r.DateOfBirth);
            }
        }
        public static void CScenario_1()
        {
            Info info = new Info();
            Console.WriteLine("----------------Course Class Scenario1------------------");
            Course c1 = new Course(200, "MSSQL", "2 Months", 4000);
            info.Display(c1);
            Course c2 = new Course(201, "Java", "6 Months", 30000);
            info.Display(c2);
            Course c3 = new Course(202, "PowerBI", "1 Month", 12000);
            info.Display(c3);
        }
        public static void CScenario_2()
        {
            Console.WriteLine("-----------------Course Class Scenario 2---------------");
            Course[] c = new Course[3];
            Info info = new Info();
            c[0] = new Course(203, "DevOps", "6 Months", 16500);
            c[1] = new Course(204, "AWS", "2 Months", 8000);
            c[2] = new Course(205, "Azure", "1 Months", 12500);
            for (int i = 0; i < c.Length; i++)
            {
                info.Display(c[i]);
                Console.WriteLine();
            }
        }
        public static void CScenario_3()
        {
            Console.WriteLine("---------------Course Class Scenario 3-----------------");
            Console.WriteLine("Enter n Value to insert student details");
            int n = Convert.ToInt32(Console.ReadLine());
            Course[] c1 = new Course[n];
            for (int i = 0; i < c1.Length; i++)
            {
                Console.WriteLine("Enter Course ID: ");
                int CID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name : ");
                string CName = Console.ReadLine();
                Console.WriteLine("Enter Course Duration :");
                string Duration = Console.ReadLine();
                Console.WriteLine("Enter Course Fees :");
                int Fees = Convert.ToInt32(Console.ReadLine());
                Course c = new Course(CID, CName, Duration, Fees);
                c1[i] = c;
            }
            foreach (var r in c1)
            {
                Console.WriteLine("\nCourse ID:{0}\nCourse Name:{1}\nCourse Duration:{2}\nCourse Fees:{3}", r.CID, r.CName, r.Duration, r.Fees);
            }
        }
        static void Main(string[] args)
        {
            Scenario_1();
            Scenario_2();
            Scenario_3();
            CScenario_1();
            CScenario_2();
            CScenario_3();
            Institute_Details IU = new Institute_Details();
            IU.showFirstScreen();
            Console.ReadLine();
            Console.ReadLine();





        }
    }
}