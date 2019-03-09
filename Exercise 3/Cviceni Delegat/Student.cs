namespace Cviceni_Delegat
{
    public class Student
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public Faculty Faculty { get; set; }

        public Student(string name, int number, Faculty faculty)
        {
            Name = name;
            Number = number;
            Faculty = faculty;
        }

        public override string ToString()
        {
            return $"Jméno: {Name}, Číslo: {Number}, Fakulta: {Faculty}";
        }
    }
}