using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Main
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter ID: ");
            student.Id = Console.ReadLine();

            Console.Write("Enter Department: ");
            student.Department = Console.ReadLine();

            Console.Write("Enter CGPA: ");
            student.Cgpa = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            student.ShowInfo();
            Triangle triangle = new Triangle();

            Console.Write("Enter X: ");
            triangle.X = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Y: ");
            triangle.Y = Convert.ToInt16(Console.ReadLine());

            Console.Write("Enter Z: ");
            triangle.Z = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            triangle.ShowInfo();


            Account account = new Account();

            Console.Write("Enter Account Name: ");
            acount.AcName = Console.ReadLine();

            Console.Write("Enter Account ID: ");
            acount.Acid = Console.ReadLine();

            Console.Write("\nEnter Deposit Amount: ");
            account.Deposit(Convert.ToInt16(Console.ReadLine()));

            Console.Write("\nEnter Withdraw Amount: ");
            account.Withdraw(Convert.ToInt16(Console.ReadLine()));

            Course course = new Course();

            Console.Write("Enter Course Name: ");
            course.CName = Console.ReadLine();

            Console.Write("Enter Course Code: ");
            course.CCode = Console.ReadLine();

            Console.Write("Enter Course Credit: ");
            course.CCredit = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("");
            course.ShowCourseInfo();

            Console.WriteLine("End!");
            Console.ReadLine();
        }
    }
}