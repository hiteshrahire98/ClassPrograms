using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ClassPrograms
//{

//    public interface IPrintable
//    {
//        string Print();
//    }

//    public class Student : IPrintable
//    {
//        private int rollno;
//        private string name;
//        private string address;
//        public  Student(int rollno, string name, string address)
//        { 
//           this.rollno = rollno;
//            this.name = name;
//            this.address = address;
//        }
//        public string Print()
//        {
//            return $"Rollno:{rollno}  Name:{name}  Address:{address}";
//        }
//    }

//    public class Employee : IPrintable
//    {
//        private int empid;
//        private string empname;
//        private string address;
//        public Employee(int empid, string empname, string address)
//        {
//            this.empid= empid;
//            this.empname= empname;
//            this.address= address;
//        }
//        public string Print()
//        {
//            return $"Employee Id:{empid}  Employee Name:{empname}  Employee Address:{address}";

//        }
//    }


//    public class Interface
//    {

//        static void Main(string[] args)
//        {
//            Student s1 = new Student(1,"Hitesh","Nashik");
//            Console.WriteLine(s1.Print());



//            Employee e1 = new Employee(101,"Sachin","Malegaon");
//            Console.WriteLine(e1.Print());

//        }

//    }
//}
