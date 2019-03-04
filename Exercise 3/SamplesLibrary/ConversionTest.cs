using System;
using System.Reflection;
using System.Security;

namespace Exercise_3.SamplesLibrary
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Person(int id)
        {
            Id = id;
        }

//        public static implicit operator Person(int v)
//        {
//            return new Person(v);
//        }
        
        public static explicit operator Person(int v)
        {
            return new Person(v);
        }
        
        public static implicit operator int(Person person)
        {
            return person.Id;
        }

        public override string ToString()
        {
            return Id + ' ' + Name;
        }
    }

    public class ConversionTest
    {
        public static void DoIt()
        {
             double realNumber = 3.14;
             realNumber = Math.PI;
             realNumber = 10;
             realNumber = 10.0;
             realNumber = (double) 10;

             int integerNumber = 3;
             integerNumber = (int)Math.Floor(Math.PI);

             
             Person person = new Person(1);
            // Person person2 = integerNumber;
             Person person2 = (Person)integerNumber;
             int integerNumber2 = person2;
             
             
             object person3 = new Person(2);
             (person3 as Person).Name = "Jarda";
       
             if (person2 is Person)
             {
                 
             }

             // stejné
             if (person2.GetType() == typeof(Person))
             {
                 
             }
        }
    }
}