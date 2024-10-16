using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string name;
        private double mark;
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Mark
        {
            get { return mark; }
            set { mark = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Address = "karbla";
            student.Name = "mortda abbas ";
            student.Mark = 99.6;
            Console.WriteLine("student name :" + student.Name + "student address: " + student.Address + "  Mark: " + student.Mark);
            Console.ReadKey();
        }
    }
}
