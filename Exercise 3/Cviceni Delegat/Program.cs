using System;
using Fei.BaseLib;

namespace Cviceni_Delegat
{
    internal class Program
    {
        private static Students students = new Students();
        private static TableStudents tableStudents = new TableStudents();

        public static void Main(string[] args)
        {
            students.DoIt();
        }
    }
}