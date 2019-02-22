using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursemo {
    public partial class Form1 : Form {

        private bool bChanging = false;
        private bool isDelayed = false;

        public Form1() {
            InitializeComponent();
            LoadLists();
        }

        private void LoadLists() {
            StudentsLstBox.Items.Clear();
            StudentCoursesLstBox.Items.Clear();
            CoursesLstBox.Items.Clear();
            TermTxtBox.Clear();
            ClassTypeTxtBox.Clear();
            DaysTxtBox.Clear();
            TimesTxtBox.Clear();
            NumWaitlistTxtBox.Clear();
            StudentsEnrolledLstBox.Items.Clear();
            CourseWaitlistLstBox.Items.Clear();
            ClassSizeTxtBox.Clear();
            StudentWaitlistLstBox.Items.Clear();


            Business b = new Business();
            IReadOnlyList<Student> students = b.GetAllStudents();

            foreach (Student s in students) {
                StudentsLstBox.Items.Add(s);
            }

            IReadOnlyList<Course> courses = b.GetAllCourses();

            foreach(Course c in courses) {
                CoursesLstBox.Items.Add(c);
            }
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e) {
            LoadLists();
        }

        private void StudentsLstBox_SelectedIndexChanged(object sender, EventArgs e) {
            Business b = new Business();

            Student currStudent = (Student)StudentsLstBox.SelectedItem;
            IReadOnlyList<Course> courses = currStudent.GetStudentCourses();

            StudentCoursesLstBox.Items.Clear();
            foreach (Course c in courses) {
                StudentCoursesLstBox.Items.Add(c);
            }

            StudentWaitlistLstBox.Items.Clear();

            IReadOnlyList<Course> waitlist = currStudent.GetWaitlistedCourses();
            foreach(Course c in waitlist) {
                StudentWaitlistLstBox.Items.Add(c);
            }
        }

        private void CoursesLstBox_SelectedIndexChanged(object sender, EventArgs e) {
            Business b = new Business();

            Course selectedCourse = (Course)CoursesLstBox.SelectedItem;
            IReadOnlyList<Student> studentsEnrolled = selectedCourse.GetStudentsEnrolled();

            StudentsEnrolledLstBox.Items.Clear();
            foreach(Student s in studentsEnrolled) {
                StudentsEnrolledLstBox.Items.Add(s);
            }

            TermTxtBox.Text = String.Format(@"{0} {1}", selectedCourse.Semester, selectedCourse.Year);
            ClassTypeTxtBox.Text = selectedCourse.ClassType;
            DaysTxtBox.Text = selectedCourse.Day;
            TimesTxtBox.Text = selectedCourse.ClassTime;
            ClassSizeTxtBox.Text = selectedCourse.Size.ToString();


            IReadOnlyList<Student> waitlisted = selectedCourse.GetWaitlistedStudents();
            CourseWaitlistLstBox.Items.Clear();
            NumWaitlistTxtBox.Text = waitlisted.Count().ToString();

            foreach (Student s in waitlisted) {
                CourseWaitlistLstBox.Items.Add(s);
            }
        }

        private void resetDatabaseToolStripMenuItem_Click(object sender, EventArgs e) {
            Business.ResetDatabase();
            LoadLists();
        }

        private void EnrollBtn_Click(object sender, EventArgs e) {
            Delay();
            Business b = new Business();

            if(StudentsLstBox.SelectedIndex == -1) {
                MessageBox.Show("Please select a Student");
                return;
            }
            
            if(CoursesLstBox.SelectedIndex == -1) {
                MessageBox.Show("Please select a Course");
                return;

            }

            Student s = (Student)StudentsLstBox.SelectedItem;
            Course c = (Course)CoursesLstBox.SelectedItem;

            if (s.IsEnrolled(c)) {
                MessageBox.Show(String.Format(@"{0} {1} is already enrolled in {2}", s.FirstName, s.LastName, c.CRN));
                LoadLists();
                return;
            }


            if (c.IsFull()) {
                if (b.AddToWaitlist(s, c)) {
                    MessageBox.Show(String.Format(@"Class {0} is full. You have been added to the waitlist", c.CRN));
                } else {
                    MessageBox.Show("Something went wrong. Please Try again");
                }
            } else {
                if (b.EnrollStudent(s, c)) {
                    MessageBox.Show("Success!");
                } else {
                    MessageBox.Show("Something went wrong. Please Try again");
                }
            }

            LoadLists();

        }

        private void DropBtn_Click(object sender, EventArgs e) {
            Delay();

            Business b = new Business();

            if(StudentsLstBox.SelectedIndex == -1) {
                MessageBox.Show("Please select a Student");
                LoadLists();
                return;
            }

            if (StudentCoursesLstBox.SelectedIndex == -1 && StudentWaitlistLstBox.SelectedIndex == -1) {
                MessageBox.Show("Please select a course");
                return;
            }

            Student s = (Student)StudentsLstBox.SelectedItem;
            Course c = null;

            if (StudentCoursesLstBox.SelectedIndex != -1) {
                c = (Course)StudentCoursesLstBox.SelectedItem;

                if (!s.IsEnrolled(c)) {
                    MessageBox.Show("The student is currently not enrolled in course " + c.CRN + ".");
                    LoadLists();
                    return;
                }

                if (b.DropStudent(s, c, out Student Enrolled)) {
                    if (Enrolled == null) {
                        MessageBox.Show(String.Format(@"Student {0} has been dropped", s.NetID));
                    } else {
                        MessageBox.Show(String.Format(@"Student {0} has been dropped. Student {1} has been removed from the waitlist and added tot he class.", s.NetID, Enrolled.NetID));
                    }
                } else {
                    MessageBox.Show("Something went wrong. Please try again");
                }

            } else if(StudentWaitlistLstBox.SelectedIndex != -1) {
                c = (Course)StudentWaitlistLstBox.SelectedItem;

                if (!s.IsEnrolled(c)) {
                    MessageBox.Show("The student is currently not enrolled in course " + c.CRN + ".");
                    LoadLists();
                    return;
                }

                if(b.RemoveFromWaitlist(s, c)) {
                    MessageBox.Show(String.Format(@"Student {0} has been removed from the waitlist", s.NetID));
                }
            }

            LoadLists();

        }

        private void StudentCoursesLstBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (bChanging)
                return;
            bChanging = true;
            StudentWaitlistLstBox.ClearSelected();
            bChanging = false;
        }

        private void StudentWaitlistLstBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (bChanging)
                return;
            bChanging = true;
            StudentCoursesLstBox.ClearSelected();
            bChanging = false;
        }

        private void SwapBtn_Click(object sender, EventArgs e) {
            CoursemoSwap f2 = new CoursemoSwap();
            f2.ShowDialog();
            LoadLists();
        }

        private void DelayChkBox_CheckedChanged(object sender, EventArgs e) {
            isDelayed = DelayChkBox.Checked;
        }

        public void Delay() {
            if (isDelayed) {
                int timeInMS;

                if(System.Int32.TryParse(this.txtTimeInMS.Text, out timeInMS) == true) {
                    //Do nothing
                } else {
                    timeInMS = 0;
                }

                Delay(timeInMS);   
            }
        }

        public static void Delay(int MS) {
            System.Threading.Thread.Sleep(MS);
        }
    }
}
