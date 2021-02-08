using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Course
    {
        private string cName;
        private string cCode;
        private int cCredit;

        public Course()
        {
            Console.WriteLine("Empty Course Object Created.");
        }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + cName);
            Console.WriteLine("Course Code: " + cCode);
            Console.WriteLine("Course Credit: " + cCredit);
        }

        public string CName
        {
            set
            {
                cName = value;
            }
            get
            {
                return cName;
            }
        }

        public string CCode
        {
            set
            {
                cCode = value;
            }
            get
            {
                return cCode;
            }
        }

        public int CCredit
        {
            set
            {
                cCredit = value;
            }
            get
            {
                return cCredit;
            }
        }
    }
}