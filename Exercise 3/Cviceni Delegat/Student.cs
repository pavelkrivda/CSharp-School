namespace Cviceni_Delegat
{
    /// <summary>
    /// Třída popisující informace o studentovy.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Jméno studenta
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Číslo studenta
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Fakulta studenta
        /// </summary>
        public Faculty Faculty { get; set; }

        /// <summary>
        /// Konstruktor pro vytvoření studenta
        /// </summary>
        /// <param name="name">Jméno studenta</param>
        /// <param name="number">Číslo studenta</param>
        /// <param name="faculty">Fakulta studenta</param>
        public Student(string name, int number, Faculty faculty)
        {
            Name = name;
            Number = number;
            Faculty = faculty;
        }

        /// <summary>
        /// Výpis informací o studentovy 
        /// </summary>
        /// <returns>Naformátovaný řetěžec s informacemi o studentovy.</returns>
        public override string ToString()
        {
            return $"Jméno: {Name}, Číslo: {Number}, Fakulta: {Faculty}";
        }
    }
}