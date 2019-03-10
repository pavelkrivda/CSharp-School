using System;
using Fei.BaseLib;
    
namespace Cviceni_Delegat
{
    public class Students
    {
       private StringComparer comparer = StringComparer.OrdinalIgnoreCase; 
        
        private Student[] students = new Student[100];
        private int studentCount = 0;

        private delegate int ShortStudentsHandler(Student firstStudetn, Student secoundStudent);

        /// <summary>
        /// Testuje funkčnost třídy
        /// </summary>
        public void DoIt()
        {
            int choice = 0;
            do
            {
                printMenu();
                choice = Reading.ReadInt("Zadej svoji volbu");
                executeChoice(choice);
            } while (choice != 0);
        }

        /// <summary>
        /// Zpracovává volby zadané uživatelem z hlavního menu.
        /// </summary>
        /// <param name="choice">Volba uživatele.</param>
        private void executeChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    addStudents();
                    break;

                case 2:
                    printStudents();
                    break;

                case 3:
                    shortStudents(Key.Number);
                    break;

                case 4:
                    shortStudents(Key.Name);
                    break;
                case 5:
                    shortStudents(Key.Faculty);
                    break;
            }
        }

        /// <summary>
        /// Vypíše menu na obrazovku.
        /// </summary>
        private void printMenu()
        {
            Console.WriteLine("1) Načtení studentů z klávesnice\n" +
                              "2) Výpis studentů na obrazovku\n" +
                              "3) Seřazení studentů podle čísla\n" +
                              "4) Seřazení studentů podle jména\n" +
                              "5) Seřazení studentů podle fakulty\n" +
                              "0) Konec programu");
        }

        /// <summary>
        /// Vrátí počet fakult v enumu Fakulty.
        /// </summary>
        /// <returns>Počet fakult v enumu Fakulty.</returns>
        private int countFaculty()
        {
            return Enum.GetNames(typeof(Key)).Length;
        }

        /// <summary>
        /// Vypíše fakulty v enumu Fakulty.
        /// </summary>
        private void printFaculty()
        {
            for (int i = 0; i < countFaculty(); i++)
            {
                Console.WriteLine($"{i} {(Key) i}");
            }
        }

        /// <summary>
        /// Vrátí fakultu z enumu Fakulty podle zadaného indexu.
        /// </summary>
        /// <param name="index">Pozice fakulty.</param>
        /// <returns>Vrátí fakultu na zadané pozici.</returns>
        /// <exception cref="ArgumentException">Chyba pokud je záporný index.
        /// Nebo větší než je počet faklut v enumu Fakulty</exception>
        private Faculty getFacultyByPosition(int index)
        {
            if (index < 0 || index > countFaculty())
                throw new ArgumentException("Neplatný index!");

            return (Faculty) index;
        }

        /// <summary>
        /// Přidá studenta do pole
        /// </summary>
        private void addStudents()
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

        /// <summary>
        /// Vytvoří nového studenta
        /// </summary>
        /// <returns>Vrátí nového studenta</returns>
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

        /// <summary>
        /// Vytiskne studenty uložené v poli.
        /// </summary>
        private void printStudents()
        {
            for (int i = 0; i < studentCount; i++)
                Console.WriteLine(students[i]);
        }

        /// <summary>
        /// Setřídí studenty podle jejich Čísel.
        /// </summary>
        /// <param name="firstStudent">Student jehož číslo se bude porovnávat s druhým studentem.</param>
        /// <param name="secondStudent">Student jehož číslo se bude porovnávat s prvním studentem.</param>
        /// <returns>Vrátí 1 pokud má první studen větší číslo než druhý.
        ///Vrátí 0 pokud jsou čísla stejné a -1 pokud je číslo druhého studenta větší než prvního.</returns>
        private int shortByNumber(Student firstStudent, Student secondStudent)
        {
            if (firstStudent.Number < secondStudent.Number)
                return -1;

            return firstStudent.Number.Equals(secondStudent.Number) ? 0 : 1;
        }

        /// <summary>
        /// Setřídí studenty podle jejich Jména.
        /// </summary>
        /// <param name="firstStudent">Student jehož jméno se bude porovnávat se jménem druhého studentem.</param>
        /// <param name="secondStudent">Student jehož jméno se bude porovnávat se jménem prvním studentem.</param>
        /// <returns>Vrátí 1 pokud má první studen delší jméno než druhý.
        ///Vrátí 0 pokud je jméno stejné a -1 pokud je jméno druhého studenta větší než prvního.</returns>
        private int shortByName(Student firstStudent, Student secondStudent)
        {
            return comparer.Compare(firstStudent.Name, secondStudent.Name);
        }

        /// <summary>
        /// Setřídí studenty podle jejich Fakult.
        /// </summary>
        /// <param name="firstStudent">Student jehož fakluta se bude porovnávat s fakultou druhého studenta.</param>
        /// <param name="secondStudent">Student jehož fakulta se bude porovnávat s fakultou prvním studenta.</param>
        /// <returns>Vrátí 1 pokud má první studen fakultu v seznamu výše než druhý.
        ///Vrátí 0 pokud je fakulta stejná a -1 pokud je fakulta v seznamu nížš než  u druhého studenta.</returns>
        private int shortByFaculty(Student firstStudent, Student secondStudent)
        {
            return comparer.Compare(firstStudent.Faculty, secondStudent.Faculty);
        }

        /// <summary>
        /// Setřídí studenty dle zadaného klíče (Jména, Čísla, Fakulty)
        /// </summary>
        /// <param name="key">Klíč podle kterého se bude řadit</param>
        /// <exception cref="Exception">Vyjímka v případě že je seznam prázný</exception>
        /// <exception cref="ArgumentException">Vyjímka pokud nen zadán validní klíč</exception>
        private void shortStudents(Key key)
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