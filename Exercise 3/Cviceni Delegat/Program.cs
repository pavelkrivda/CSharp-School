using System;
using Fei.BaseLib;

namespace Cviceni_Delegat
{
    internal class Program
    {
        private static Students students = new Students();

        public static void Main(string[] args)
        {
            int choice = 0;
            do
            {
                students.PrintMenu();
                choice = Reading.ReadInt("Zadej svoji volbu");
                executeChoice(choice);
            } while (choice != 0);
        }


        private static void executeChoice(int choice)
        {
            switch (choice)
            {
                case   1:
                 students.addStudents();
                    break;
                
                case   2:
                 students.PrintStudents();
                    break;
                
                case   3:
                 students.ShortStudents(Key.Number);
                    break;
                
                case   4:
                    students.ShortStudents(Key.Name);
                    break;
                case   5:
                    students.ShortStudents(Key.Faculty);
                    break;
            }
        }
    }
}