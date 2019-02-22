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
    public partial class CoursemoSwap : Form {

        private bool isDelayed;

        public CoursemoSwap() {
            InitializeComponent();
            LoadLists();
        }

        private void LoadLists() {
            StudentsLstBox1.Items.Clear();
            StudentsLstBox2.Items.Clear();
            StudentCoursesLstBox1.Items.Clear();
            StudentCoursesLstBox2.Items.Clear();

            Business b = new Business();
            IReadOnlyList<Student> students = b.GetAllStudents();

            foreach(Student s in students) {
                StudentsLstBox1.Items.Add(s);
                StudentsLstBox2.Items.Add(s);
            }

        }


        private void StudentsLstBox1_SelectedIndexChanged(object sender, EventArgs e) {
            StudentCoursesLstBox1.Items.Clear();

            Business b = new Business();
            Student s = (Student)StudentsLstBox1.SelectedItem;

            IReadOnlyList<Course> courses = s.GetStudentCourses();

            foreach(Course c in courses) {
                StudentCoursesLstBox1.Items.Add(c);
            }

        }

        private void StudentsLstBox2_SelectedIndexChanged(object sender, EventArgs e) {
            StudentCoursesLstBox2.Items.Clear();

            Business b = new Business();
            Student s = (Student)StudentsLstBox2.SelectedItem;

            IReadOnlyList<Course> courses = s.GetStudentCourses();

            foreach (Course c in courses) {
                StudentCoursesLstBox2.Items.Add(c);
            }
        }

        private void SwapBtn_Click(object sender, EventArgs e) {
            Delay();

            if (StudentsLstBox1.SelectedIndex == -1 || StudentsLstBox2.SelectedIndex == -1) {
                MessageBox.Show("Please select a student");
                return;
            }

            if (StudentCoursesLstBox1.SelectedIndex == -1 || StudentCoursesLstBox2.SelectedIndex == -1) {
                MessageBox.Show("Please select a course");
                return;
            }

            Student s1 = (Student)StudentsLstBox1.SelectedItem;
            Student s2 = (Student)StudentsLstBox2.SelectedItem;

            Course c1 = (Course)StudentCoursesLstBox1.SelectedItem;
            Course c2 = (Course)StudentCoursesLstBox2.SelectedItem;


            if(s1.IsEnrolled(c2) || s2.IsEnrolled(c1)) {
                MessageBox.Show("Student is already enrolled in the class");
                return;
            }


            Business b = new Business();

            if (s1.Equals(s2)) {
                MessageBox.Show("The Students cannot be the same");
                return;
            }

            if (c1.Equals(c2)) {
                MessageBox.Show("The Course CRNs cannot be the same");
                return;
            }

            if (b.SwapCourses(s1, c1, s2, c2)) {
                MessageBox.Show("Success!");
            } else {
                MessageBox.Show("Something went wrong. Please Try again");
                return;
            }

            this.Dispose();
        }

        private void DelayChkBox_CheckedChanged(object sender, EventArgs e) {
            isDelayed = DelayChkBox.Checked;
        }

        public void Delay() {
            if (isDelayed) {
                int timeInMS;

                if (System.Int32.TryParse(this.txtTimeInMS.Text, out timeInMS) == true) {
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
