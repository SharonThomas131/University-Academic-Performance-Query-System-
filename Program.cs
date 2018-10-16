/*************************************************************
 * Name: Sharon Thomas (Z1833666)
 *       Sudheeshna Devarapalli (Z1840147)
 * Course: CSCI 504
 * Assignment#: 03
 * Due date: 10/11/2018 11:59 pm
 *************************************************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thomas_Assign3
{
    public enum Acadyear { Freshman, Sophomore, Junior, Senior, PostBacc };             //declaring an enum to store the various years of college

    /* 
     * ClassName: Student
     * Summary: Stores all the details pertaining to one student
     */
    public class Student : IComparable
    {
        //attributes of student class
        readonly uint zid;
        String fname, lname, major;
        Acadyear acdyear;
        float gpa;
        ushort crhours;

        //setting properties for the attributes
        public Acadyear Acdyear
        {
            get { return acdyear; }
            set { acdyear = value; }
        }

        public uint Zid
        {
            get { return zid; }  //since ZID is a readonly variable it cant be set a value
        }

        public String FName
        {
            get { return fname; }
            set { fname = value; }
        }

        public String LName
        {
            get { return lname; }
            set { lname = value; }
        }

        public String Major
        {
            get { return major; }
            set { major = value; }
        }

        public float GPA
        {
            get { return gpa; }
            set                 //only is gpa lies between 0 and 4
            {
                if (value >= 0 && value <= 4)
                    gpa = value;
                else
                    throw new Exception("Invalid GPA. (GPA should be within a range of 0 to 4");
            }
        }

        public ushort Crhours
        {
            get { return crhours; }
            set                 //only if the credit hours lies between 0 and 18
            {
                if (value >= 0 && value <= 18)
                    crhours = value;
                else
                    throw new Exception("Invalid credit hours. (credit hours should be within a range of 0 to 18");
            }
        }

        //Default constructor
        public Student()
        {
            fname = "";
            lname = "";
            major = "";
            gpa = 0F;
            Crhours = 0;
        }

        //Parameterized Constructor to intiliaze the values
        public Student(uint zid, String FName, String LName, String Major, Acadyear ayear, float Gpa)
        {
            if (zid >= 1000000)
                this.zid = zid;
            else
                throw new Exception("Invalid ZID");
            fname = FName;
            lname = LName;
            major = Major;
            acdyear = ayear;
            gpa = Gpa;
        }

        /*
         * MethodName: CompareTo
         * Parameters: Object
         * ReturnType: int
         * Summary: CompareTo method to compare the current instance Zid to the Zid of object passed
         *          and sorts the collection based on the zid.
         */
        public int CompareTo(object obj)
        {
            Student Temp = (Student)obj;
            if (this.Zid < Temp.Zid)
                return -1;
            else if (this.Zid == Temp.Zid)
                return 0;
            else
                return 1;

        }

        /*
         * MethodName: ToString()
         * ReturnType: string
         * Summary: Prints the attributes of the object as a string in the specified format.
         */
        public override string ToString()
        {
            Program obj = new Program();
            return "z" + obj.Temp.ToString().PadRight(6, ' ') + " --    " + FName.PadLeft(12, ' ') + ", " + LName.PadRight(10, ' ') + "[" + Acdyear.ToString().PadRight(10, ' ') + "]  " + "(" + Major.PadRight(15, ' ') + ")  " + "  | " + String.Format("{0:0.000}", GPA) + " |";
        }
    }

    /* 
     * ClassName: Course
     * Summary: Stores all the details about the courses available
     */
    public class Course : IComparable
    {
        //attributes of Course class
        uint cnum;
        String deptcode, section;
        ushort chours, max_enrollment, stu_enrolled_count;
        List<int> stu_enrolled = new List<int>();     //list to store all the zids of newly enrolling students

        //Properties for the attributes
        public List<int> Stuenrolled
        {
            get { return stu_enrolled; }
            set { stu_enrolled = value; }
        }

        public String Deptcode
        {
            get { return deptcode; }
            set
            {
                int ch = 0;
                if (value.Length == 4)                          //department code should have 4 characters.
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        if (char.IsUpper(value[i]))
                        {
                            ch++;
                        }
                    }
                }
                if (ch == 4 || value.Length==3  )
                    deptcode = value;

            }
        }

        public String Section
        {
            get { return section; }
            set                         //section should have a minimum of 4 characters to be set
            {
                if (value.Length == 4)
                    section = value;
                else
                    section = "";
            }
        }

        public uint Cnum
        {
            get { return cnum; }
            set
            {
                if (value >= 100 && value <= 499)
                    cnum = value;
                else
                    cnum = 0;
            }
        }

        public ushort Stuenrolledcount
        {
            get { return stu_enrolled_count; }
            set { stu_enrolled_count = value; }
        }

        public ushort Chours
        {
            get { return chours; }
            set                             //the credits for each course should not be greater than 6
            {
                if (value >= 0 && value <= 6)
                    chours = value;
                else
                    chours = 0;
            }
        }

        public ushort Maxenrollment
        {
            get { return max_enrollment; }
            set { max_enrollment = value; }
        }
        //Default constructor
        public Course()
        {
            cnum = 0;
            deptcode = "";
            section = "";
            chours = 0;
            stu_enrolled_count = 0;
            max_enrollment = 0;
        }


        //Parameterized Constructor to intilalize the values of attributes for Course class
        public Course(String deptCode, uint courseNum, String sectionNum, ushort creditHours, ushort capacity)
        {
            deptcode = deptCode;
            cnum = courseNum;
            section = sectionNum;
            chours = creditHours;
            max_enrollment = capacity;
            //allocate the students array-HOW?
            stu_enrolled_count = 0;
        }

        /*
         * MethodName: CompareTo
         * Parameters: Object
         * ReturnType: int
         * Summary: CompareTo method here does a 2 layer sorting, initially with the department being sorted,
         *          and then within each department it sorts the course numbers.
         */
        public int CompareTo(object obj)
        {
            Course Temp = (Course)obj;

            if (String.Compare(this.Deptcode, Temp.Deptcode) == 0)
            {
                return String.Compare(this.Cnum.ToString(), Temp.Cnum.ToString());
            }

            return String.Compare(this.Deptcode, Temp.Deptcode);
        }
        /*
       * MethodName: ToString()
       * ReturnType: string
       * Summary: Prints the attributes of the object as a string in the specified format.
       */
        public override string ToString()
        {
            return this.Deptcode.ToString() + "  " + Cnum + "-" + Section + "   (" + Stuenrolledcount + "/" + Maxenrollment + ")";
        }
    }

    /* 
     * ClassName: Course
     * Summary: Stores all the details about the courses available
     */
    public class Grades : IComparable
    {
        //attributes of Grade class
        readonly uint zid;
        String major,grade;
        uint cnum;

        //setting properties for the attributes

        public uint Zid
        {
            get { return zid; }  //since ZID is a readonly variable it cant be set a value
        }

        public String Major
        {
            get { return major; }
            set { major = value; }
        }

        public String Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public uint Cnum
        {
            get { return cnum; }
            set
            {
                if (value >= 100 && value <= 499)
                    cnum = value;
                else
                    cnum = 0;
            }
        }

        //Default constructor
        public Grades()
        {
            major = "";
            grade = "";
            cnum = 0;
        }

        //Parameterized Constructor to intiliaze the values
        public Grades(uint zid, String Major, uint Cnum, String Grade)
        {
            if (zid >= 1000000)
                this.zid = zid;
            else
                throw new Exception("Invalid ZID");
            major = Major;
            cnum = Cnum;
            grade = Grade;
        }

        /*
         * MethodName: CompareTo
         * Parameters: Object
         * ReturnType: int
         * Summary: CompareTo method here does a 2 layer sorting, initially with the department being sorted,
         *          and then within each department it sorts the course numbers.
         */
        public int CompareTo(object obj)
        {
            Grades Temp = (Grades)obj;

            if (String.Compare(this.Major, Temp.Major) == 0)
            {
                return String.Compare(this.Cnum.ToString(), Temp.Cnum.ToString());
            }

            return String.Compare(this.Major, Temp.Major);
        }

        /*
         * MethodName: ToString()
         * ReturnType: string
         * Summary: Prints the attributes of the object as a string in the specified format.
         */
        public override string ToString()
        {
            Program obj = new Program();
            return "z" + obj.Temp.ToString()+ "   |   " + Major+ "-" + Cnum +"  |  "+ Grade;
        }

        public bool Equals(Grades x, Grades y)
        {
            if (x.zid == y.zid &&
                        x.major.ToLower() == y.major.ToLower() && x.cnum == y.cnum)
                return true;

            return false;
        }

        public int GetHashCode(Student obj)
        {
            return obj.GetHashCode();
        }
    }

    //class to allow duplicates into a dictionary of key type string and value type int
    public class ListWithDuplicates : List<KeyValuePair<string, int>>
    {
        public void Add(string key, int value)
        {
            var element = new KeyValuePair<string, int>(key, value);
            this.Add(element);
        }
    }

    //class to allow duplicates into a dictionary of key type string and value type float to store percentage of students
    public class ListWithDup : List<KeyValuePair<string, float>>
    {
        public void Combine(string key, float value)
        {
            var element = new KeyValuePair<string, float>(key, value);
            this.Add(element);
        }
    }
    public class Program      
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static List<Student> newStudents = new List<Student>();
        public static List<Course> newCourses = new List<Course>();
        public static List<string> majors = new List<string>();
        public static List<Grades> newGrades = new List<Grades>();
        Student s = new Student();
        Course c = new Course();
        public static uint temp = 0;
        public static String Option = "This is an option";

        //Properties of the collection used to store the data read from the file.
        public List<Student> NewStudents
        {
            get { return newStudents; }
        }

        public List<Course> NewCourses
        {
            get { return newCourses; }
        }

        public List<string> Majors
        {
            get { return majors; }
        }

        public List<Grades> NewGrades
        {
            get { return newGrades; }
        }

        public uint Temp
        {
            get { return temp; }
            set { temp = value; }
        }

        [STAThread]
        static void Main()
        {
            Student s = new Student();
            Course c = new Course();
            String Path = Directory.GetCurrentDirectory();              //getting the path of the project folder
            if (File.Exists(Path + "\\2188_a3_input01.txt"))
            {
                if (File.Exists(Path + "\\2188_a3_input02.txt"))
                {
                    if (File.Exists(Path + "\\2188_a3_input03.txt"))
                    {
                        if (File.Exists(Path + "\\2188_a3_input04.txt"))
                        {
                            using (StreamReader SR = new StreamReader(Path + "\\2188_a3_input01.txt"))        //reading the contents of Student input file.
                            {
                                int index = 0;
                                Char delimiter = ',';
                                Student students = new Student();

                                String S = SR.ReadLine();
                                while (S != null)                   //parsing the file until end of file is reached.
                                {
                                    index++;
                                    String[] sub = S.Split(delimiter);
                                    temp = Convert.ToUInt32(sub[0]);
                                    students.FName = sub[1];
                                    students.LName = sub[2];
                                    students.Major = sub[3];
                                    students.GPA = float.Parse(sub[5]);
                                    //reading every line of file with the student details and adding it to the collection.
                                    newStudents.Add(new Student(Convert.ToUInt32(sub[0]), students.FName, students.LName, students.Major, (Acadyear)Enum.Parse(typeof(Acadyear), sub[4]), students.GPA));         // Adds the new values to logins list
                                    students = new Student();
                                    S = SR.ReadLine();
                                }
                            }

                            using (StreamReader SR = new StreamReader(Path + "\\2188_a3_input02.txt"))        ////reading the contents of Course input file.
                            {
                                int index = 0;
                                Char delimiter = ',';
                                Course courses = new Course();
                                String S = SR.ReadLine();
                                while (S != null)               //parsing the file until end of file is reached.
                                {
                                    index++;
                                    String[] sub = S.Split(delimiter);
                                    courses.Deptcode = sub[0];
                                    courses.Cnum = Convert.ToUInt16(sub[1]);
                                    courses.Section = sub[2];
                                    courses.Chours = Convert.ToUInt16(sub[3]);
                                    courses.Maxenrollment = Convert.ToUInt16(sub[4]);
                                    //reading every line of file with the course details and adding it to the collection.
                                    newCourses.Add(new Course(courses.Deptcode, courses.Cnum, courses.Section, courses.Chours, courses.Maxenrollment));
                                    courses = new Course();
                                    S = SR.ReadLine();
                                }
                            }

                            using (StreamReader SR = new StreamReader(Path + "\\2188_a3_input03.txt"))        ////reading the contents of Majors input file.
                            {
                                String[] maj = File.ReadAllLines(Path + "\\2188_a3_input03.txt");
                                majors.AddRange(maj);
                            }

                            using (StreamReader SR = new StreamReader(Path + "\\2188_a3_input04.txt"))        //reading the contents of Student input file.
                            {
                                int index = 0;
                                Char delimiter = ',';
                                Grades grades = new Grades();
                                String S = SR.ReadLine();
                                while (S != null)                   //parsing the file until end of file is reached.
                                {
                                    index++;
                                    String[] sub = S.Split(delimiter);
                                    temp = Convert.ToUInt32(sub[0]);
                                    grades.Major = sub[1];
                                    grades.Cnum = Convert.ToUInt32(sub[2]);
                                    grades.Grade= sub[3];
                                    //reading every line of file with the student's grade details and adding it to the collection.
                                    newGrades.Add(new Grades(Convert.ToUInt32(sub[0]), grades.Major,grades.Cnum,grades.Grade));         // Adds the new values to grades list
                                    grades = new Grades();
                                    S = SR.ReadLine();
                                }
                                newGrades.Sort();
                            }
                        }
                        else
                            Console.WriteLine("File with student grades does not exist");
                    }
                    else
                        Console.WriteLine("List of Majors file not available");
                }
                else
                    Console.WriteLine("Course file does not exist");
            }
            else
                Console.WriteLine("Student file does not exist");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formNIUPerformanceSystem());
        }
    }
}

