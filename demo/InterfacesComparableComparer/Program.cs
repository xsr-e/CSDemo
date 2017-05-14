using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesComparableComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var pp = new Person[]{
                new Person {FirstName="Zygmunt", LastName="Nowak"}
                ,new Person {FirstName="Anna", LastName="Nowak"}    
                ,new Person {FirstName="Jan", LastName="Kowalski"}
            };

            Array.Sort(pp);
            Console.WriteLine(pp[0]);
            Array.Sort(pp, new PersonFirstNameComparer());
            Console.WriteLine(pp[0]);
            Array.Sort(pp, new PersonLastNameComparer());
            Console.WriteLine(pp[0]);

        }

    }

    public class Person : IComparable, IComparable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CompareTo(object obj)
        {
            var pOther = obj as Person;
            return CompareTo(pOther);
        }
        
        public int CompareTo(Person other)
        {

            var otherFull = other.LastName + other.FirstName;
            var full = this.FirstName + this.LastName;

            return full.CompareTo(otherFull);
        }
        public override string ToString()
        {
            return LastName + " " + FirstName;
        }
    }

    class PersonLastNameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
    class PersonFirstNameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.FirstName.CompareTo(y.FirstName);
        }
    }

}