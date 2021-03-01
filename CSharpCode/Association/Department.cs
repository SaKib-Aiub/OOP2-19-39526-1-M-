using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        private string id;
        private string name;

        private int studentCount;
        private Student[] students;

        public Department()
        {
            students = new Student[50];
        }

        public Department(string id, string name)
        {
            this.Name = name;
            this.Id = id;
            students = new Student[50];
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
                s.Dept = this;
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

        public void ShowInfo()
        {
            Console.WriteLine("Dept Id: {0}", this.Id);
            Console.WriteLine("Dept Name: {0}", this.Name);
        }
    }
}