using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanInheritance
{
    class Teacher : Person
    {
        public string TeacherId { get; set; }
        public string Subject { get; set; }
        public Teacher(string name, int age, string teacherid, string subject) : base(name, age)
        {
            this.TeacherId = teacherid;
            this.Subject = subject;
        }
    }
}
