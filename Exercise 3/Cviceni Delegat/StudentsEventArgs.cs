using System;

namespace Cviceni_Delegat
{
    class StudentsEventArgs : EventArgs
    {
        public Student Student1 { get; set; }
        public Student Student2 { get; set; }

        public StudentsEventArgs(Student student1, Student student2)
        {
            Student1 = student1;
            Student2 = student2;
        }
    }
}
