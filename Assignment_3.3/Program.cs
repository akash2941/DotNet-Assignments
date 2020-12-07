
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] arr = new Student[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Student Name :");
                string Name1 = Console.ReadLine();
                Console.WriteLine("Enter Student Roll No :");
                int rno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Mark for Subject :");
                Decimal mark = Convert.ToDecimal(Console.ReadLine());

                arr[i].Name = Name1;
                arr[i].RollNo = rno;
                arr[i].Marks = mark;

            }

            foreach (var item in arr)
            {
                Console.WriteLine("Roll no : " + item.RollNo + " Name : " + item.Name + " Marks : " + item.Marks);

            }
            Console.ReadLine();

        }
    }
    struct Student
    {

        public string Name;
        public int RollNo;
        public decimal Marks;

        Student(string name, int Rno, decimal mark)
        {
            RollNo = 0;
            this.RollNo = Rno;
            Name = "aa";
            this.Name = name;
            Marks = 0;
            this.Marks = mark;
        }

    }
}