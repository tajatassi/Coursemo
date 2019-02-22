using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Transactions;
using System.Linq;
using System.Data.SqlClient;

namespace Coursemo {
    public class Business {

        public Business() {

        }

        public IReadOnlyList<Student> GetAllStudents() {
            List<Student> students = new List<Student>();

            using (var db = new CoursemoDataContext()) {

                var query = from s in db.Students
                            orderby s.LastName, s.FirstName
                            select s;

                foreach (Student s in query) {
                    students.Add(s);
                }

            }

            return students;

        }

        public IReadOnlyList<Course> GetAllCourses() {
            List<Course> courses = new List<Course>();

            using (var db = new CoursemoDataContext()) {
                var query = from c in db.Courses
                            orderby c.DepartmentAbbreviation ascending, c.CourseNumber ascending, c.CRN ascending
                            select c;

                foreach (Course c in query) {
                    courses.Add(c);
                }
            }

            return courses;
        }

        public static void ResetDatabase() {
            int counter = 0;

            while (counter < 3) {
                using (var db = new CoursemoDataContext()) {
                    try {
                        using (var scope = new TransactionScope()) {

                            var resetQuery = from classes in db.StudentClasses
                                             select classes;

                            foreach (StudentClass sc in resetQuery) {
                                db.StudentClasses.DeleteOnSubmit(sc);
                            }

                            db.SubmitChanges();
                            scope.Complete();
                            return;
                        }
                        //The "rollback" part
                    } catch (TransactionAbortedException ex) {
                        Console.WriteLine(ex.Message);
                    } catch (SqlException e) {
                        if (e.Number == 1205) {
                            counter++;
                        } else {
                            throw;
                        }
                    }
                }
            }
        }


        // According to internet (https://stackoverflow.com/questions/494550/how-does-transactionscope-roll-back-transactions) if Dispose() is called before Complete(), the transaction will rollback. Using guarantees that dispose is called regardless so we just try-catch the transaction and throw an exception if you need to rollback.
        public bool EnrollStudent(Student s, Course c) {
            int counter = 0;

            while (counter < 3) {
                using (var db = new CoursemoDataContext()) {
                    try {
                        using (var scope = new TransactionScope()) {

                            if (s == null || c == null) {
                                throw new TransactionAbortedException("Student or Course cannot be null");
                            }

                            StudentClass sc = new StudentClass {
                                NetID = s.NetID,
                                CRN = c.CRN,
                                isWaitlisted = false
                            };

                            db.StudentClasses.InsertOnSubmit(sc);
                            db.SubmitChanges();
                            scope.Complete();
                            return true;
                        }

                        //rollback
                    } catch (TransactionAbortedException ex) {

                    } catch (SqlException e) {
                        if (e.Number == 1205) {
                            counter++;
                        } else {
                            return false;
                        }
                    }
                }
            }
            return false;
        }

        public bool DropStudent(Student s, Course c, out Student Enrolled) {
            int counter = 0;

            while (counter < 3) {
                using (var db = new CoursemoDataContext()) {
                    try {
                        using (var scope = new TransactionScope()) {

                            if (s == null || c == null) {
                                throw new TransactionAbortedException("Student or Course cannot be null");
                            }

                            var getStudentQuery = (from a in db.Students
                                                   join sc in db.StudentClasses on a.NetID equals sc.NetID
                                                   where (s.NetID == sc.NetID) && (c.CRN == sc.CRN) && (sc.isWaitlisted == false)
                                                   select sc).First();

                            StudentClass toDrop = getStudentQuery;

                            if (toDrop == null) {
                                throw new TransactionAbortedException("StudentClass is null");
                            }

                            db.StudentClasses.DeleteOnSubmit(toDrop);

                            Enrolled = c.GetNextStudentInWaitlist();  //Enrolls next student in the class
                            db.SubmitChanges();
                            scope.Complete();
                            return true;
                        }
                    } catch (TransactionAbortedException ex) {
                        Enrolled = null;
                        return false;
                    } catch (SqlException e) {
                        if (e.Number == 1205) {
                            counter++;
                        } else {
                            throw;
                        }
                    }
                }
            }
            Enrolled = null;
            return false;
        }

        public bool AddToWaitlist(Student s, Course c) {
            int counter = 0;

            while (counter < 3) {
                using (var db = new CoursemoDataContext()) {
                    try {
                        using (var scope = new TransactionScope()) {

                            if (s == null || c == null) {
                                throw new TransactionAbortedException("Student or Course cannot be null");
                            }

                            StudentClass sc = new StudentClass {
                                NetID = s.NetID,
                                CRN = c.CRN,
                                isWaitlisted = true,
                                DateWaitListed = DateTime.Now
                            };

                            db.StudentClasses.InsertOnSubmit(sc);
                            db.SubmitChanges();
                            scope.Complete();
                            return true;
                        }
                        //Rollback
                    } catch (TransactionAbortedException ex) {

                    } catch (SqlException e) {
                        if (e.Number == 1205) {
                            counter++;
                        } else {
                            throw;
                        }
                    }
                }
            }
            return false;
        }

        public bool RemoveFromWaitlist(Student s, Course c) {
            int counter = 0;

            while (counter < 3) {
                using (var db = new CoursemoDataContext()) {
                    try {
                        using (var scope = new TransactionScope()) {

                            if (s == null || c == null) {
                                throw new TransactionAbortedException("Student or Course cannot be null");
                            }

                            var query = (from sc in db.StudentClasses
                                         where (sc.NetID == s.NetID) && (sc.CRN == c.CRN) && (sc.isWaitlisted == true)
                                         select sc).First();

                            db.StudentClasses.DeleteOnSubmit(query);
                            db.SubmitChanges();
                            scope.Complete();
                            return true;
                        }

                    } catch (TransactionAbortedException) {
                        return false;
                    } catch (SqlException e) {
                        if (e.Number == 1205) {
                            counter++;
                        } else {
                            throw;
                        }
                    }

                }
            }

            return false;
        }

        public bool SwapCourses(Student s1, Course c1, Student s2, Course c2) {
            int counter = 0;

            while (counter < 3) {

                using (var db = new CoursemoDataContext()) {
                    try {
                        using (var scope = new TransactionScope()) {

                            var getFirstStudentCourse = from sc in db.StudentClasses
                                                        where sc.CRN == c1.CRN && sc.NetID == s1.NetID && sc.isWaitlisted == false
                                                        select sc;

                            StudentClass sc1 = getFirstStudentCourse.First();

                            var getSecondStudentCourse = from sc in db.StudentClasses
                                                         where sc.CRN == c2.CRN && sc.NetID == s2.NetID && sc.isWaitlisted == false
                                                         select sc;

                            StudentClass sc2 = getSecondStudentCourse.First();


                            StudentClass newSC1 = new StudentClass {
                                NetID = sc1.NetID,
                                CRN = sc2.CRN,
                                isWaitlisted = false
                            };

                            StudentClass newSC2 = new StudentClass {
                                NetID = sc2.NetID,
                                CRN = sc1.CRN,
                                isWaitlisted = false
                            };

                            db.StudentClasses.DeleteOnSubmit(sc1);
                            db.StudentClasses.DeleteOnSubmit(sc2);


                            db.StudentClasses.InsertOnSubmit(newSC1);
                            db.StudentClasses.InsertOnSubmit(newSC2);

                            db.SubmitChanges();
                            scope.Complete();
                            return true;
                        }
                    } catch (TransactionAbortedException) {
                        return false;
                    } catch (SqlException e) {
                        if (e.Number == 1205) {
                            counter++;
                        } else {
                            throw;
                        }
                    }
                }
            }
            return false;
        }
    }

    public partial class Student {

        public override string ToString() {
            return String.Format(@"{0}, {1} ({2})", LastName, FirstName, NetID);
        }

        public IReadOnlyList<Course> GetStudentCourses() {
            List<Course> courses = new List<Course>();


            using (var db = new CoursemoDataContext()) {
                var query = from c in db.Courses
                            join sc in db.StudentClasses on c.CRN equals sc.CRN
                            join st in db.Students on sc.NetID equals st.NetID
                            where (sc.NetID == NetID) && (sc.isWaitlisted == false)
                            select c;

                foreach (Course c in query) {
                    courses.Add(c);
                }
            }

            return courses;
        }

        public IReadOnlyList<Course> GetWaitlistedCourses() {
            List<Course> courses = new List<Course>();


            using (var db = new CoursemoDataContext()) {
                var query = from c in db.Courses
                            join sc in db.StudentClasses on c.CRN equals sc.CRN
                            join st in db.Students on sc.NetID equals st.NetID
                            where (sc.NetID == NetID) && (sc.isWaitlisted == true)
                            orderby sc.DateWaitListed ascending
                            select c;

                foreach (Course c in query) {
                    courses.Add(c);
                }
            }

            return courses;
        }

        public bool IsEnrolled(Course c) {
            using (var db = new CoursemoDataContext()) {

                var query = from course in db.Courses
                            join sc in db.StudentClasses on course.CRN equals sc.CRN
                            join st in db.Students on sc.NetID equals st.NetID
                            where (sc.NetID == NetID) && (sc.CRN == c.CRN)
                            select course;

                if (query == null) {
                    return false;
                }

                if (query.Count() == 1) {
                    return true;
                } else {
                    return false;
                }
            }
        }

        public bool Equals(Student other) {
            return NetID == other.NetID;
        }

    }

    public partial class Course {

        public override string ToString() {
            return String.Format(@"{0}{1}, {2}", DepartmentAbbreviation, CourseNumber, CRN);
        }

        public IReadOnlyList<Student> GetStudentsEnrolled() {
            List<Student> students = new List<Student>();

            using (var db = new CoursemoDataContext()) {
                var query = from s in db.Students
                            join sc in db.StudentClasses on s.NetID equals sc.NetID
                            where (sc.CRN == CRN) && (sc.isWaitlisted == false)
                            select s;

                foreach (Student s in query) {
                    students.Add(s);
                }
            }

            return students;
        }

        public IReadOnlyList<Student> GetWaitlistedStudents() {
            List<Student> students = new List<Student>();

            using (var db = new CoursemoDataContext()) {
                var query = from s in db.Students
                            join sc in db.StudentClasses on s.NetID equals sc.NetID
                            where (sc.isWaitlisted == true) && (sc.CRN == CRN)
                            orderby sc.DateWaitListed ascending
                            select s;

                foreach (Student s in query) {
                    students.Add(s);
                }

            }

            return students;

        }

        public bool IsFull() {

            using (var db = new CoursemoDataContext()) {

                var query = from sc in db.StudentClasses
                            where (sc.CRN == CRN) && (sc.isWaitlisted == false)
                            select sc;

                int Count = query.Count();


                return Count >= Size;

            }
        }

        private bool HasWaitlist() {
            using (var db = new CoursemoDataContext()) {

                var query = from sc in db.StudentClasses
                            where (sc.CRN == CRN) && (sc.isWaitlisted == true)
                            select sc;

                int Count = query.Count();

                return Count > 0;
            }
        }

        /// <summary>
        /// Get the next student from the waitlist and remove them from the waitlist
        /// </summary>
        /// <returns>The next student in Waitlist</returns>
        public Student GetNextStudentInWaitlist() {
            using (var db = new CoursemoDataContext()) {
                try {
                    using (var scope = new TransactionScope()) {
                        try {

                            //This will throw an error if the list is empty, which is OK.
                            var query = (from s in db.Students
                                         join sc in db.StudentClasses on s.NetID equals sc.NetID
                                         where (sc.CRN == CRN) && (sc.isWaitlisted == true)
                                         orderby sc.DateWaitListed ascending
                                         select s).First();

                            Student TheStudent = query;

                            //get the right class
                            var removeQuery = (from sc in db.StudentClasses
                                               where (sc.NetID == TheStudent.NetID) && (CRN == sc.CRN)
                                               select sc).First();

                            StudentClass SClass = removeQuery;
                            SClass.isWaitlisted = false;
                            SClass.DateWaitListed = null;


                            db.SubmitChanges();
                            scope.Complete();

                            return TheStudent;
                        } catch (Exception) {
                            db.SubmitChanges();
                            scope.Complete();
                            return null;
                        }
                    }
                    //Rollback
                } catch (TransactionAbortedException) {
                    return null;
                }
            }
        }


        public bool Equals(Course obj) {
            return CRN == obj.CRN; //primary keys are equal
        }
    }

}

