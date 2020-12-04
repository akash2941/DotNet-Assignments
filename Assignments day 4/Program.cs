using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Program
    {
        static void Main()
        {
            CEO a1 = new CEO("akash",4,2636.34M,"peon","holiday");
            CEO a2 = new CEO("akash", 4, 2636.34M, "peon", "holiday");
            CEO a3 = new CEO("akash", 4, 2636.34M, "peon", "holiday");
            a1.CalNetSalary();
            Console.WriteLine(a1.EmpNo);
            Console.WriteLine(a2.EmpNo);
            Console.WriteLine(a3.EmpNo);

            Console.WriteLine(a3.EmpNo);
            Console.WriteLine(a2.EmpNo);
            Console.WriteLine(a1.EmpNo);
            Console.ReadLine();

            Class2 e1 = new Class2();
            e1.Delete();
        }
    }
    
    public  interface IDbFunctions
    {
            void Insert();
            void Update();
            void Delete();
    }
    

    public abstract class Employee : IDbFunctions
    {
        private String name;
        protected decimal basic;
        public String Name
        {
            set
            {
                if (value != null)
                    Name = value;
                else
                    Console.WriteLine("Blank name");

            }
            get
            {
                return name;
            }
        }

        private static int lastempNo = 0;
        private int empNo;
        public int EmpNo
        {
            get { return empNo; }
            private set { empNo = value; }   /// Property Accessor
        }

        private short deptNo;

        public short DeptNo
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("Dept number is zero or less than");
            }
        }

        public abstract decimal Basic { get; set; }


        
        public Employee(String name,short deptNo,decimal basic)
        {
            this.name = name;
            empNo = ++lastempNo;
            this.deptNo = deptNo;
            this.basic = basic;

        }

        public abstract void CalNetSalary();

        public void Insert()
        {
            Console.WriteLine("Employee class- Insert");
        }

        public void Update()
        {
            Console.WriteLine("Employee class- Update");
        }

        public void Delete()
        {
            Console.WriteLine("Employee class- Delete");
        }
    }



    public class Manager : Employee,IDbFunctions
    {
        private String designation;

        public override decimal Basic { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void CalNetSalary()
        {
            Console.WriteLine("calnet called");
           
        }

        public Manager(String designation,String name,short deptNo,decimal basic) : base(name ,deptNo,basic)
        {
            this.designation = designation;
        }

        public String Designation
        {
            set
            {
                if (value != null)
                    designation = value;
                else
                    Console.WriteLine("cannot be blank");
            }
            get
            {
                return designation;
            }
        }

        public void Insert()
        {
            Console.WriteLine("mANAGER class- Insert");
        }

        public void Update()
        {
            Console.WriteLine("Manager class- Update");
        }

        public void Delete()
        {
            Console.WriteLine("Manager class- Delete");
        }
    }

    public class GeneralManager : Manager,IDbFunctions
    {
        private String perks;
        public override void CalNetSalary()
        {
            Console.WriteLine("calnet clled");
        }

        public GeneralManager( String name, short deptNo, decimal basic,String designation ,String perks)  : base  (designation,name, deptNo, basic)
        {
            this.perks = perks;
        }

        public void Insert()
        {
            Console.WriteLine("GeneralManager class- Insert");
        }

        public void Update()
        {
            Console.WriteLine("GeneralManager class- Update");
        }

        public void Delete()
        {
            Console.WriteLine("GeneralManager class- Delete");
        }

    }

    public class CEO : GeneralManager,IDbFunctions
    {
        public sealed override void CalNetSalary()
        {
            Console.WriteLine("calnet called++++++++++++++++");
        }

        public CEO(String name, short deptNo, decimal basic, String designation, String perks) : base( name, deptNo, basic,designation,perks)
        {
           
        }
        public void Insert()
        {
            Console.WriteLine("CEO - Insert");
        }

        public void Update()
        {
            Console.WriteLine("CEO - Update");
        }

        public void Delete()
        {
            Console.WriteLine("CEO - Delete");
        }


    }

   
}
