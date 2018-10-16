using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thomas_Assign3
{
    public partial class formNIUPerformanceSystem : Form
    {
        public formNIUPerformanceSystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /*
         * EventName: Grade_Click
         * Summary: Prints the entire course and grades detail of the requested student in the specified format.
         */
        private void Grade_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
            cmbThreshGrade.SelectedIndex = -1;
            tbThreshCour.Clear();
            cmbFMajor.SelectedIndex = -1;
            tbFailCour.Clear();
            textBox3.Clear();
            nudPercent.Value = 0;
            cmbPassGrade.SelectedIndex = -1;
            Program p = new Program();
            int valid = 0;
            string status = "true";
            List<Grades> temp = new List<Grades>();
            string id = tbZid.Text;
            if (id.Length != 0 && (id.Length == 8 || id.Length == 7))
            {
                string c = id.Substring(0, 1);
                if (c == "z" || c == "Z")                   //if the zid is entered without omitting the Z character.
                {
                    id = id.Substring(1, id.Length - 1);
                }
            }
            else
                status = "false";
            if (status == "true")
            {
                foreach (Grades g in p.NewGrades)      //first of all check if the zid entered is valid or not - Validating the input
                {
                    if (g.Zid == Convert.ToUInt32(id))
                        valid = 1;
                    else
                        continue;
                }
                if (valid == 1)
                {                     //LINQ Query to print the grade details of only the requested ZID
                    rtbResults.AppendText("Single Student Grade Report (" + id + ")" + "\n---------------------------------------\n");
                    var st_grades = from g in p.NewGrades.Where(g => g.Zid == Convert.ToUInt32(id)).ToList<Grades>()   //lambda expression to filter results
                                    select g;

                    foreach (Grades g in st_grades)      //add the query result into another list.
                    {
                        temp.Add(g);
                        //rtbResults.AppendText("z" + g.Zid.ToString().PadRight(8, ' ') + "| " + g.Major + "-" + g.Cnum.ToString().PadRight(5, ' ') + "| " + g.Grade + "\n");
                    }
                    for (int i = 0; i < temp.Count; i++) //print the result list
                    {
                        if (i + 1 != temp.Count) 
                        {
                            if (temp[i].Major == temp[i + 1].Major && temp[i].Cnum == temp[i + 1].Cnum)  //swap the two rows if the dept code and cnum are identical
                            {
                                rtbResults.AppendText("z" + temp[i + 1].Zid.ToString().PadRight(8, ' ') + "| " + temp[i + 1].Major + "-" + temp[i + 1].Cnum.ToString().PadRight(5, ' ') + "| " + temp[i + 1].Grade + "\n");
                                rtbResults.AppendText("z" + temp[i].Zid.ToString().PadRight(8, ' ') + "| " + temp[i].Major + "-" + temp[i].Cnum.ToString().PadRight(5, ' ') + "| " + temp[i].Grade + "\n");
                                i++;
                            }
                            else  //else just print that row
                                rtbResults.AppendText("z" + temp[i].Zid.ToString().PadRight(8, ' ') + "| " + temp[i].Major + "-" + temp[i].Cnum.ToString().PadRight(5, ' ') + "| " + temp[i].Grade + "\n");
                        } 
                    }
                    //to print the last row of result list
                    rtbResults.AppendText("z" + temp[temp.Count-1].Zid.ToString().PadRight(8, ' ') + "| " + temp[temp.Count - 1].Major + "-" + temp[temp.Count - 1].Cnum.ToString().PadRight(5, ' ') + "| " + temp[temp.Count - 1].Grade + "\n");
                    rtbResults.AppendText("\n###END RESULTS###");
                }
                else
                    MessageBox.Show("Please enter a valid Student ID");
            }
            else
                MessageBox.Show("Please enter a Z<ID> or <ID> with ID being no less than 7 digits");
            
        }

        /*
         * EventName: btnStFailed_Click
         * Summary: Prints the details of the students who failed in the requested course, but only those belonging to major mentioned.
         */
        private void btnStFailed_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
            tbZid.Clear();
            cmbThreshGrade.SelectedIndex = -1;
            tbThreshCour.Clear();
            textBox3.Clear();
            nudPercent.Value = 0;
            cmbPassGrade.SelectedIndex = -1;
            string major = cmbFMajor.Text;                  //accepting the inputs
            string course = tbFailCour.Text.ToUpper();
            Program p = new Program();
            List<Grades> zids = new List<Grades>();
            string status = "true";
            int count = 0,ccount=0;
            string[] c = new string[0];
                                        //validating the input
            if (course.Contains(' '))
            {
                c = course.Split(' ');
                if (cmbFMajor.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Major");
                    status = "false";
                }
            }
            else if (course.Contains('-'))
            {
                c = course.Split('-');
                if (cmbFMajor.SelectedIndex==-1)
                {
                    MessageBox.Show("Please select a Major");
                    status = "false";
                }
            }
            else
            {
                MessageBox.Show("Please enter the course name in CourseName <space> CourseNumber format");
                status = "false";
            }
            
            if (status == "true")               //proceed only if the coursenumber entered is in correct format.
            {
                string cname = c[0];
                string cnum = c[1];
                for (int k = 0; k < p.NewCourses.Count; k++)
                {
                    
                    if (p.NewCourses[k].Deptcode==cname && p.NewCourses[k].Cnum == Convert.ToUInt32(cnum))
                        ccount = k;
                    else
                        continue;
                }
                if (ccount == 0 || ccount > p.NewCourses.Count)
                {
                    MessageBox.Show("Unfortunately, there is no such course.");
                }
                else
                {
                    rtbResults.AppendText("Fail Report of Majors (" + major + ") in " + cname + " " + cnum + "\n------------------------------------------\n");
                    //LINQ query to calculate the number of failures for the requested course.
                    var result = from g in p.NewGrades.Where(g => g.Major == cname && g.Cnum == Convert.ToUInt32(cnum) && g.Grade == "F") select g;
                    foreach (var r in result)
                        zids.Add(r);

                    //filtering the input from the result query
                    for (int i = 0; i < p.NewStudents.Count; i++)
                    {
                        foreach (var z in zids)
                        {
                            if (z.Zid == p.NewStudents[i].Zid && p.NewStudents[i].Major == major)
                            {
                                rtbResults.AppendText("z" + z.Zid.ToString().PadRight(8, ' ') + "| " + z.Major + "-" + z.Cnum.ToString().PadRight(5, ' ') + "| " + z.Grade + "\n");
                                count++;
                            }
                            else
                                continue;
                        }
                    }
                    //if there are no students of selected major who failed in the course 
                    if (count == 0)
                        rtbResults.AppendText("\nThere are no failures in " + course + " belonging to " + major + "\n");
                    rtbResults.AppendText("\n###END RESULTS###");
                    
                }
            }
        }

        /*
         * EventName: btnGradeReportCour_Click
         * Summary: Prints the Grade report for one course.
         */
        private void btnGradeReportCour_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
            tbZid.Clear();
            cmbThreshGrade.SelectedIndex = -1;
            tbThreshCour.Clear();
            cmbFMajor.SelectedIndex = -1;
            tbFailCour.Clear();
            nudPercent.Value = 0;
            cmbPassGrade.SelectedIndex = -1;
            string course = textBox3.Text.ToUpper();
            Program p = new Program();
            string status = "true";
            string[] c = new string[0];
            //validating the input
            if (course.Contains(' '))
                c = course.Split(' ');
            else if (course.Contains('-'))
                c = course.Split('-');
            else
            {
                MessageBox.Show("Please enter the course name in CourseName <space> CourseNumber format");
                status = "false";
            }
            if (status == "true")
            {
                string dept = c[0];
                int ccount = -1, cnum = 0;
                cnum = Convert.ToInt32(c[1]);
                for (int k = 0; k < p.NewCourses.Count; k++)            //check if the course entered is an existing valid course or not
                {
                    if (p.NewCourses[k].Deptcode == dept.ToUpper() && p.NewCourses[k].Cnum == Convert.ToUInt32(cnum))
                        ccount = k;
                    else
                        continue;
                }
                if (ccount < 0 || ccount > p.NewCourses.Count)
                {
                    MessageBox.Show("Unfortunately, there is no such course \n\n\n");
                }
                else
                {
                    rtbResults.AppendText("Grade Report (" + dept + " " + cnum + ")" + "\n------------------------------\n");
                    var stFailed = from f in p.NewGrades.Where(f => f.Major == dept && f.Cnum == cnum)         //LINQ query to fetch the grade details of the course requested
                                   orderby f.Zid
                                   select f;
                    foreach (Grades g in stFailed)              //printing the result query
                        rtbResults.AppendText("z" + g.Zid.ToString().PadRight(8, ' ') + "| " + g.Major + "-" + g.Cnum.ToString().PadRight(5, ' ') + "| " + g.Grade + "\n");
                    rtbResults.AppendText("\n###END RESULTS###");
                }
            }
        }

        /*
         * EventName: btnThreshold_Click
         * Summary: Prints the Grade report of the requested course, with threshold above or below the Grade selected.
         */
        private void btnThreshold_Click(object sender, EventArgs e)      //change the query
        {
            rtbResults.Clear();
            tbZid.Clear();
            cmbFMajor.SelectedIndex = -1;
            tbFailCour.Clear();
            textBox3.Clear();
            nudPercent.Value = 0;
            cmbPassGrade.SelectedIndex = -1;
            Program p = new Program();
            string grade = cmbThreshGrade.Text.ToUpper();
            string course = tbThreshCour.Text.ToUpper();
            string status = "true";
            int ccount = 0, nor = 0; ;
            string[] c = new string[0];
            //validating the input
            if(!rbTless.Checked && !rbTGreater.Checked && course.Length==0 && grade.Length==0)
            {
                MessageBox.Show("Please select a Threshold, and provide a Grade and course to proceed");
                status = "false";
            }
            if (status == "true")
            {
                if (course.Contains(' '))
                    c = course.Split(' ');
                else if (course.Contains('-'))
                    c = course.Split('-');
                else
                {
                    MessageBox.Show("Please enter the course name in CourseName <space> CourseNumber format");
                    status = "false";
                }
                if (cmbThreshGrade.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Grade");
                    status = "false";
                }
            }
            int index = 0;
            List<string> dis_grades = new List<string>();
            List<string> thresh_grades = new List<string>();   
            dis_grades.AddRange(new string[] { "A", "A-", "B+", "B", "B-", "C++", "C", "C-", "D", "F" });  //list of grades available
            if (status == "true")
            {
                string dept = c[0];
                uint cnum = Convert.ToUInt32(c[1]);
                                                                        //check if the course entered is valid or not
                for (int k = 0; k < p.NewCourses.Count; k++)
                {
                    if (p.NewCourses[k].Deptcode == dept.ToUpper() && p.NewCourses[k].Cnum == Convert.ToUInt32(cnum))
                        ccount = k;
                    else
                        continue;
                }
                if (ccount <= 0 || ccount > p.NewCourses.Count)
                {
                    MessageBox.Show("Unfortunately, there is no such course \n\n\n");
                }
                else
                {
                    if (rbTless.Checked)            //if threshold-Less than is selected
                    {

                        index = dis_grades.FindIndex(a => a==grade);               //query to find the grade which the user wants.
                        //select new { Name=i, Ind=index };
                        for (int i = index; i < dis_grades.Count; i++)
                            thresh_grades.Add(dis_grades[i]);                               //consider all the grades less than the requested grade
                        var result = from g in p.NewGrades orderby g.Zid select g;          //query to select all the rows. 
                        rtbResults.AppendText("Grade Threshold Report for (" + dept + " " + cnum + ")" + "\n------------------------------\n");
                        foreach (var res in result)
                        {
                            if (thresh_grades.Contains(res.Grade) && res.Major == dept && res.Cnum == cnum)    //print only the matching criteria rows from the query result
                            {
                                nor++;
                                rtbResults.AppendText("z" + res.Zid.ToString().PadRight(8, ' ') + "| " + res.Major + "-" + res.Cnum.ToString().PadRight(5, ' ') + "| " + res.Grade + "\n");
                            }
                            
                        }
                        if (nor == 0)
                            rtbResults.AppendText("No students matching this criteria");
                        rtbResults.AppendText("\n###END RESULTS###");
                    }
                    else if (rbTGreater.Checked)        //if threshold-Greater than is selected
                    {
                        index = dis_grades.FindIndex(a => a==grade);           //query to find the grade which the user wants.
                        for (int i = index; i >= 0; i--)
                            thresh_grades.Add(dis_grades[i]);                           //consider all the grades more than the requested grade
                        var result = from g in p.NewGrades orderby g.Zid select g;      //query to select all the rows.
                        rtbResults.AppendText("Grade Threshold Report for (" + dept + " " + cnum + ")" + "\n------------------------------\n");
                        foreach (var res in result)
                        {
                            if (thresh_grades.Contains(res.Grade) && res.Major == dept && res.Cnum == cnum)     //print only the matching criteria rows from the query result
                            {
                                rtbResults.AppendText("z" + res.Zid.ToString().PadRight(8, ' ') + "| " + res.Major + "-" + res.Cnum.ToString().PadRight(5, ' ') + "| " + res.Grade + "\n");
                                nor++;
                            }

                            }
                        if (nor == 0)
                            rtbResults.AppendText("No students matching this criteria\n");
                        rtbResults.AppendText("\n###END RESULTS###");
                    }
                    else
                    {
                        MessageBox.Show("Please select one of the threshold's (from the radio buttons)");
                    }
                }
            }
        }

        /*
         * EventName: btnFailResults_Click
         * Summary: Prints the Fail report of the requested course, with threshold above or below the percentage given.
         */
        private void btnFailResults_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
            tbZid.Clear();
            cmbThreshGrade.SelectedIndex = -1;
            tbThreshCour.Clear();
            cmbFMajor.SelectedIndex = -1;
            tbFailCour.Clear();
            textBox3.Clear();
            cmbPassGrade.SelectedIndex = -1;
            Program p = new Program();
            var failStudents = new ListWithDuplicates();    //store percentage of failures in each course   
            var totalStudents = new ListWithDuplicates();
            var percentages = new ListWithDup();
            var output = new ListWithDup();

            List<string> coursename = new List<string>();
            List<string> distinct_cour = new List<string>();
            int percent = Convert.ToInt32(nudPercent.Value);
            List<string> gr = new List<string>();
            for (int i = 0; i < p.NewGrades.Count; i++)
            {
                string c = p.NewGrades[i].Major + "-" + p.NewGrades[i].Cnum;
                coursename.Add(c);
            }
            distinct_cour = coursename.Distinct().ToList();

            var result = from g in p.NewGrades orderby g.Major, g.Cnum select g;
            var groupedresult = from s in result
                                group s by new { s.Major, s.Cnum };
            
            var fStudents = from g in groupedresult                         //counting the number of failures for each course
                                select new { Course = g.Key, totalcount = g.Count(S=>S.Grade=="F") };
            
            foreach(var i in fStudents)
            {
                failStudents.Add(i.Course.ToString(), i.totalcount);
            }
            
            var tStudents = from g in groupedresult
                                select new { Course=g.Key,totalcount = g.Count() };
            foreach (var j in tStudents)
            {
                totalStudents.Add(j.Course.ToString(), j.totalcount);
            }
            
            for(int i=0;i<failStudents.Count;i++)
            {
               
                int fcount = failStudents[i].Value;
                int tcount = totalStudents[i].Value;
                float percentage = ((float)fcount / (float)tcount)*100;
                percentages.Combine(failStudents[i].Key, (float)Math.Round(percentage,2));
                string res = "Out of " + tcount + " enrolled in " + distinct_cour[i] + ", " + fcount + " failed ("+ (float)Math.Round(percentage, 2)+"% )";
                output.Combine(res, (float)Math.Round(percentage, 2));
            }
            
            if (rbFLess.Checked)
            {
                int nor = 0;
                rtbResults.AppendText("Fail Percentage (<= "+percent+"%) Report for Classes."+ "\n-----------------------------------------------\n");
                for (int i=0;i<output.Count;i++)
                {
                    if (output[i].Value <= (float)percent && output[i].Value != 0)
                    {
                        rtbResults.AppendText(output[i].Key + "\n\n");
                        nor++;
                    }
                }
                if (nor == 0)
                    rtbResults.AppendText("No courses matched the query criteria.");
                else
                    rtbResults.AppendText("\n###END RESULTS###");
            }
            else if(rbFGreater.Checked)
            {
                int nor = 0;
                rtbResults.AppendText("Fail Percentage (>= " + percent + "%) Report for Classes." + "\n-----------------------------------------------\n");
                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].Value >= (float)percent && output[i].Value != 0)
                    {
                        nor++;
                        rtbResults.AppendText(output[i].Key + "\n\n");
                    }
                }
                if (nor == 0)
                    rtbResults.AppendText("No courses matched the query criteria");
                else
                    rtbResults.AppendText("\n###END RESULTS###");
            }
            else
            {
                MessageBox.Show("Please select one of the threshold's (from the radio buttons)");
            }
        }
        /*
         * EventName: btnFailResults_Click
         * Summary: Prints the Pass report of the requested course, with threshold above or below the grade selected.
         */
        private void btnPassReport_Click(object sender, EventArgs e)
        {
            rtbResults.Clear();
            tbZid.Clear();
            cmbThreshGrade.SelectedIndex = -1;
            tbThreshCour.Clear();
            cmbFMajor.SelectedIndex = -1;
            tbFailCour.Clear();
            textBox3.Clear();
            nudPercent.Value = 0;
            Program p = new Program();
            string grade = cmbPassGrade.Text.ToUpper();
            var passStudents = new ListWithDuplicates();    //store percentage of passed students in each course   
            var totalStudents = new ListWithDuplicates();
            var percentages = new ListWithDup();
            var output = new ListWithDup();
            int index = 0;
            List<Grades> passGrades = new List<Grades>();
            List<string> dis_grades = new List<string>();
            List<string> thresh_grades = new List<string>();
            dis_grades.AddRange(new string[] { "A", "A-", "B+", "B", "B-", "C++", "C", "C-", "D"});
            List<string> coursename = new List<string>();
            List<string> distinct_cour = new List<string>();
            int percent = Convert.ToInt32(nudPercent.Value);
            List<string> gr = new List<string>();
            for (int i = 0; i < p.NewGrades.Count; i++)
            {
                string c = p.NewGrades[i].Major + "-" + p.NewGrades[i].Cnum;
                coursename.Add(c);
            }
            distinct_cour = coursename.Distinct().ToList();

            
            if (rbPLess.Checked)
            {
                index = dis_grades.FindIndex(a => a==grade);               //query to find the grade which the user wants.
                for (int i = index; i < dis_grades.Count; i++)
                {
                    thresh_grades.Add(dis_grades[i]);                               //consider all the grades less than the requested grade
                    
                }
                var result = from g in p.NewGrades orderby g.Major, g.Cnum select g;
                var groupedresult = from s in result
                                    group s by new { s.Major, s.Cnum };
                var pStudents = from g in groupedresult                         //counting the number of failures for each course
                                select new { Course = g.Key, totalcount = g.Count(S => thresh_grades.Contains(S.Grade)) };
                foreach (var i in pStudents)
                {
                    passStudents.Add(i.Course.ToString(), i.totalcount);
                }
                var tStudents = from g in groupedresult
                                select new { Course = g.Key, totalcount = g.Count() };
                foreach (var j in tStudents)
                {
                    totalStudents.Add(j.Course.ToString(), j.totalcount);
                }

                for (int i = 0; i < passStudents.Count; i++)
                {

                    int pcount = passStudents[i].Value;
                    int tcount = totalStudents[i].Value;
                    float percentage = ((float)pcount / (float)tcount) * 100;
                    percentages.Combine(passStudents[i].Key, (float)Math.Round(percentage, 2));
                    string res = "Out of " + tcount + " enrolled in " + distinct_cour[i] + ", " + pcount + " passed at or below this threshold (" + (float)Math.Round(percentage, 2) + "% )";
                    output.Combine(res, (float)Math.Round(percentage, 2));
                }
                
                int nor = 0;
                rtbResults.AppendText("Fail Percentage (<= " + grade + ") Report for Classes." + "\n-----------------------------------------------\n");
                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].Value != 0)
                    {
                        rtbResults.AppendText(output[i].Key + "\n\n");
                        nor++;
                    }
                }
                if (nor == 0)
                    rtbResults.AppendText("No courses matched the query criteria.");
                else
                    rtbResults.AppendText("\n###END RESULTS###");
            }
            else if (rbPGreater.Checked)
            {
                index = dis_grades.FindIndex(a => a==grade);               //query to find the grade which the user wants.
                for (int i = index; i >=0; i--)
                {
                    thresh_grades.Add(dis_grades[i]);                               //consider all the grades greater than the requested grade
                }
                
                var result = from g in p.NewGrades orderby g.Major, g.Cnum select g;
                var groupedresult = from s in result
                                    group s by new { s.Major, s.Cnum };
                var pStudents = from g in groupedresult                         //counting the number of passedstudents for each course
                                select new { Course = g.Key, totalcount = g.Count(S => thresh_grades.Contains(S.Grade)) };

                foreach (var i in pStudents)
                {
                    passStudents.Add(i.Course.ToString(), i.totalcount);
                }
                var tStudents = from g in groupedresult
                                select new { Course = g.Key, totalcount = g.Count() };
                foreach (var j in tStudents)
                {
                    totalStudents.Add(j.Course.ToString(), j.totalcount);
                }

                
                for (int i = 0; i < passStudents.Count; i++)
                {

                    int pcount = passStudents[i].Value;
                    int tcount = totalStudents[i].Value;
                    float percentage = ((float)pcount / (float)tcount) * 100;
                    percentages.Combine(passStudents[i].Key, (float)Math.Round(percentage, 2));
                    string res = "Out of " + tcount + " enrolled in " + distinct_cour[i] + ", " + pcount + " passed at or above this threshold (" + (float)Math.Round(percentage, 2) + "% )";
                    output.Combine(res, (float)Math.Round(percentage, 2));
                }
                
                int nor = 0;
                rtbResults.AppendText("Fail Percentage (>= " + grade + ") Report for Classes." + "\n-----------------------------------------------\n");
                for (int i = 0; i < output.Count; i++)
                {
                    if (output[i].Value != 0)
                    {
                        rtbResults.AppendText(output[i].Key + "\n\n");
                        nor++;
                    }
                }
                if (nor == 0)
                    rtbResults.AppendText("No courses matched the query criteria");
                else
                    rtbResults.AppendText("\n###END RESULTS###");


            }
            else
                MessageBox.Show("Please select one of the threshold's (from the radio buttons)");
        }

        
    }
}
