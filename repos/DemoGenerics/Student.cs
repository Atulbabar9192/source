using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DemoGenerics
{
    public class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public string Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            if (this.Sid < other.Sid)
                return -1;
            return 0;

        }
    }

    class CompareStudent : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return 1;
            if (x.Marks < y.Marks)
                return -1;
            else
                return 0;
        }
    }
    public class TestStudent
    {
        public static void Main()
        {
            Student S1 = new Student { Sname = "John", Sid = 105, Class = "10", Marks = 76.55f };
            Student S2 = new Student { Sname = "Rohan", Sid = 102, Class = "10", Marks = 86.55f };
            Student S3 = new Student { Sname = "Jasmine", Sid = 104, Class = "10", Marks = 60.55f };
            Student S4 = new Student { Sname = "Rony", Sid = 103, Class = "10", Marks = 96.54f };
            Student S5 = new Student { Sname = "Nil", Sid = 101, Class = "10", Marks = 56.5f };

            List<Student> students = new List<Student> { S1, S2, S3, S4, S5 };
            CompareStudent obj = new CompareStudent();
            students.Sort(obj);
            students.Remove(S1);
                
            foreach (Student S in students)
            Console.WriteLine( S.Sid + " " + S.Sname + " " + S.Class + " " + S.Marks);
            Console.ReadLine();

        }
    }
}
