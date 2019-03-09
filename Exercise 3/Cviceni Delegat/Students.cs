using System;
using Fei.BaseLib;

namespace Cviceni_Delegat
{
    public class Students
    {
        private Student[] students = new Student[100];
        private int studentCount = 0;

        public delegate int ShortStudentsHandler(Student firstStudetn, Student secoundStudent);

        public void PrintMenu()
        {
            Console.WriteLine("1) Načtení studentů z klávesnice\n" +
                              "2) Výpis studentů na obrazovku\n" +
                              "3) Seřazení studentů podle čísla\n" +
                              "4) Seřazení studentů podle jména\n" +
                              "5) Seřazení studentů podle fakulty\n" +
                              "0) Konec programu");
        }

        private int countFaculty()
        {
            return Enum.GetNames(typeof(Key)).Length;
        }

        private void printFaculty()
        {
            for (int i = 0; i < countFaculty(); i++)
            {
                Console.WriteLine($"{i} {(Key) i}");
            }
        }

        private Faculty getFacultyByPosition(int index)
        {
            if (index < 0 || index > countFaculty())
                throw new ArgumentException("Neplatný index!");

            return (Faculty) index;
        }

        public void addStudents()
        {
            string name;
            int number;
            Faculty faculty;
            char choise;

            do
            {
                students[studentCount++] = createStudent();
                choise = Reading.ReadChar("Chcete přidat dalšího studenta a/n");
                Console.WriteLine();
            } while (choise != 'n');
        }

        private Student createStudent()
        {
            string name;
            int number;
            Faculty faculty;
            name = Reading.ReadString("Zadej jméno");
            number = Reading.ReadInt("Zadej číslo");

            int numberFaculty;

            do
            {
                printFaculty();
                numberFaculty = Reading.ReadInt("Číslo fakulty");
            } while (numberFaculty < 0 || numberFaculty > countFaculty());

            faculty = getFacultyByPosition(numberFaculty);
            return new Student(name, number, faculty);
        }

        public void PrintStudents()
        {
            for (int i = 0; i < studentCount; i++)
                Console.WriteLine(students[i]);
        }

        private int shortByNumber(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Number < secondStudent.Number)
                return -1;

            return firstStudent.Number.Equals(secondStudent.Number) ? 0 : 1;
        }

        private int shortByName(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Name.Length < secondStudent.Name.Length)
                return -1;

            return firstStudent.Name.Equals(secondStudent.Name) ? 0 : 1;
        }

        private int shortByFaculty(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Faculty < secondStudent.Faculty)
                return -1;

            return firstStudent.Faculty.Equals(secondStudent.Faculty) ? 0 : 1;
        }

        public void ShortStudents(Key key)
        {
            if (studentCount == 0)
                throw new Exception("Pole je prázdné!");

            if (studentCount < 2)
                return;

            ShortStudentsHandler shortStudents;
            switch (key)
            {
                case Key.Name:
                    shortStudents = shortByName;
                    break;

                case Key.Number:
                    shortStudents = shortByNumber;
                    break;

                case Key.Faculty:
                    shortStudents = shortByFaculty;
                    break;

                default:
                    throw new ArgumentException("Neplatný parametr třídění!");
            }


            for (int i = 0; i < studentCount - 1; i++)
            {
                for (int j = 0; j < studentCount - i - 1; j++)
                {
                    if (shortStudents(students[j + 1], students[j]) < 1)
                    {
                        Student tmp = students[j + 1];
                        students[j + 1] = students[j];
                        students[j] = tmp;
                    }
                }
            }
        }
    }
}