using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Course
    {
        private string id;
        private string name;

        private int studentCount;
        private Student[] students;

        public Course()
        {
            this.students = new Student[10];
        }

        public Course(string id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.students = new Student[10];
        }

        public string Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public int StudentCount
        {
            set { this.studentCount = value; }
            get { return this.studentCount; }
        }

        public void AddStudent(params Student[] stdns)
        {
            foreach (Student s in stdns)
            {
                this.students[this.StudentCount++] = s;
                if (s.GetCourse(this.Id) == null)
                    s.AddCourse(this);
            }
        }

        
        public Student GetStudent(string id)
        {
            for (int i = 0; i < this.StudentCount; ++i)
                if (id == this.students[i].Id)
                    return this.students[i];

            return null;
        }

        public void PrintStudent()
        {
            for (int i = 0; i < this.StudentCount; ++i)
            {
                this.students[i].ShowInfo();
            }
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("C Name: {0}", this.Name);
            Console.WriteLine("C ID: {0}", this.Id);
        }
    }
}