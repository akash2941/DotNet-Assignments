using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of batches : ");
            int batchNo = Convert.ToInt32(Console.ReadLine());
            int[][][] arr = new int[batchNo][][];
            for (int i = 0; i < batchNo; i++)
            {
                Console.WriteLine("Eeter the number of Students of batch : " + (i + 1));
                int numberOfStudents = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[numberOfStudents][];
                for (int j = 0; j < numberOfStudents; j++)
                {
                    Console.WriteLine("Enter the marks of student : " + (j + 1));
                    arr[i][j] = new int[3];
                    for (int k = 0; k < 3; k++)
                    {
                        Console.WriteLine("Enter the marks of subject : " + (k + 1));
                        arr[i][j][k] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.ReadLine();
                //Console.WriteLine("Eeter the number of Students of batch : " + i + 1);
                //int numberOfStudents = Convert.ToInt32(Console.ReadLine());
                //arr[i][][];
            }
            Console.WriteLine();
            for (int i = 0; i < batchNo; i++)
            {
                Console.WriteLine("Batch No : " + (i + 1));
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Marks for student : " + (j + 1));
                    for (int k = 0; k < arr[i][j].Length; k++)
                    {
                        Console.WriteLine("Marks for subject " + (k + 1) + " is : " + arr[i][j][k]);
                    }
                }
            }
            Console.ReadLine();

        }
    }
}