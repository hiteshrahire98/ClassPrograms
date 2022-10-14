using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPrograms
{
    public class Employee
    {
        protected int id;
        protected string name;
        protected double basicsalary, hra, da, pf, netpaid;
        private static int count;

        public Employee(string name, double basicsalary)
        {
            count++;
            this.id = count;
            this.name = name;
            this.basicsalary = basicsalary;
        }

        public virtual void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary) - pf;
        }

        public static string TotalCount()
        {
            return $"Total count is {count}";
        }

        public override string ToString()
        {
            return $"Employee details -->Id :{id}  Name :{name}  Salary {netpaid}";
        }
    }
    public class Manager : Employee
    {
        private double ta;
        public Manager(string name, double bs, double ta) : base(name, bs) 
        {
            this.ta = ta;
        }
        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + ta) - pf;
        }

        public override string ToString()
        {
            return $"Manager details -->Id :{id}  Name :{name}  Salary {netpaid} Travelling Allowance:{ta}";
        }
    }

    public class President : Employee
    {
        private double ma,ta;
        public President(string name, double bs, double ma,double ta) : base(name, bs)
        {
            this.ma = ma;
            this.ta = ta;
        }

        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + ma +ta) - pf;
        }
        public override string ToString()
        {
            return $"President details -->Id :{id}  Name :{name}  Salary {netpaid}  Medical Allowance:{ma}  Travelling Allowance:{ta}";
        }

    }

    public class SalesManager : Employee
    {
        private double bonus,commission,ta,ma;

        public SalesManager(string name, double bs, double bonus,double commission,double ta,double ma) : base(name, bs)
        {
            this.bonus=bonus;
            this.commission = commission;
            this.ta=ta;
            this.ma=ma;
        }

        public override void CalculateSalary()
        {
            hra = basicsalary * 0.40;
            da = basicsalary * 0.20;
            pf = basicsalary * 0.12;
            netpaid = (hra + da + basicsalary + bonus + commission + ta + ma) - pf;
        }

        public override string ToString()
        {
            return $"SalesManager details -->Id :{id}  Name :{name}  Salary {netpaid}  Bonus:{bonus}  Commission:{commission}   Travelling Allowance:{ta}  Medical Allowance:{ma}";
        }
    }
}
