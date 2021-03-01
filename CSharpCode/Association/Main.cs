using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Student s1 = new Student("223", "Sakib", 3.5F);
            Student s2 = new Student("172", "Asif", 3.8F);
            Student s3 = new Student("451", "Naeem", 3.0F);

            Department d1 = new Department("CS", "Computer Science");
            Department d2 = new Department("EEE", "Electrical & Electronic Engineering");

            s1.Dept = d1;
            s2.Dept = d2;
            s3.Dept = d2;

            s1.ShowInfo();
            s1.ShowDepartment();

            s2.ShowInfo();
            s2.ShowDepartment();

            s3.ShowInfo();
            s3.ShowDepartment();

            
            d1.Name = "Computer Science & Engineering";

            s1.ShowInfo();
            s1.ShowDepartment();

            d1.AddStudent(s1);
            d1.AddStudent(s2);

            d1.PrintStudent();

            Course c1 = new Course("mat101", "Math 1");
            Course c2 = new Course("mat102", "Math 2");
            Course c3 = new Course("mat103", "Math 3");
          
            Student s4 = new Student("213", "Shovon", 3.8F);
            
            c1.AddStudent(s1, s2);
            c2.AddStudent(s1, s4);

            c1.PrintStudent();
            c2.PrintStudent();

            s1.PrintCourse();
            s3.PrintCourse();
        }
    }
}