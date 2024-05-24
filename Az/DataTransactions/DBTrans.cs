using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Az.Models;
using SQLite;

namespace Az.DataTransactions
{
    public  class DBTrans
    {
        public string dbPath;
        private SQLiteConnection connection;

        public DBTrans( string _dbPath)
        {
            this.dbPath = _dbPath;
            Init();
        }

        public void Init()
        {
            connection = new SQLiteConnection(this.dbPath);
            connection.CreateTable<Student>();
            connection.CreateTable<Course>();
            connection.CreateTable<Enroll>();
        }

        public List<Student> getAllStudents()
        {
            return connection.Table<Student>().ToList();
        }

        public void AddStudents(Student student)
        {
         
            connection.Insert(student);
        }

        public void DeleteStudent(int Student_ID) {
            connection.Delete(new Student { Student_ID = Student_ID });
        }

        public List <Course> getAllCourses()
        {
            return connection.Table<Course>().ToList();
        }

        public void AddCourses (Course course)
        {
            connection.Insert(course);
        }

        public void DeleteCourse(int Course_ID)
        {
            connection.Delete(new Course { Course_ID = Course_ID });
        }

        public List <Enroll> getEnrolls()
        {
            return connection.Table<Enroll>().ToList();
        }

        public void AddEnroll(Enroll enroll)
        {
            connection.Insert(enroll);
        }

        public void DeleteEnroll(int Enroll_ID)
        {
            connection.Delete(new Enroll {  Enroll_ID = Enroll_ID });
        }
    }
}
