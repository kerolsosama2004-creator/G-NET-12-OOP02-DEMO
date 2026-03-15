using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02_DEMO
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public static int TotalStudents = 0;
        public Student(string name)
        {
            Name = name;
            TotalStudents++;
            Id = TotalStudents;

        }
    }
}
