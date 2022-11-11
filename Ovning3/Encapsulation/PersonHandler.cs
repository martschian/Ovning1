using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Encapsulation
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFirstName(Person pers, string fname)
        {
            pers.FName = fname;
        }
        public void SetLastName(Person pers, string lname)
        {
            pers.LName = lname;
        }
        public void SetWeight(Person pers, double weight)
        {
            pers.Weight = weight;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(fName: fname, lName: lname);
            person.Age = age;
            person.Weight = weight;
            person.Height = height;
            return person;
        }
    }
}
