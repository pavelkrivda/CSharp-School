using System;
using Microsoft.SqlServer.Server;

namespace ConsoleApplication1
{
    internal class Program
    {
        public class Person
        {
            private string firstname;
            private string lastname;
            private Adresa adresa;

            public Person(string firstname, string lastname, Adresa adresa)
            {
                this.firstname = firstname;
                this.lastname = lastname;
                this.adresa = adresa;
            }

            public override string ToString()
            {
                return $"{firstname} {lastname}\n{adresa}";
            }
        }
        
        public class Adresa
        {
            private string street;
            private string number;
            private string postCode;
            private string city;

            public Adresa(string street, string number, string postCode, string city)
            {
                this.street = street;
                this.number = number;
                this.postCode = postCode;
                this.city = city;
            }

            public override string ToString()
            {
                return $"{street} {number}\n{postCode.Substring(0,3)} {postCode.Substring(3)}, {city}";
            }
        }

        public static void Main(string[] args)
        {
            Person person = new Person("Josef","Novák", 
                new Adresa("Jindřišská", "16", "111 50", "Praha 1"));
            Console.WriteLine(person);
        }
    }
}