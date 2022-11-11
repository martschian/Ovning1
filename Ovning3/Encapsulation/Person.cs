using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3.Encapsulation
{

    internal class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Age has to be greater than zero");
            }

        }

        private string fName;
        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                    fName = value;
                else
                    throw new ArgumentException("First name has to be between 2-10 characters");
            }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15)
                    lName = value;
                else
                    throw new ArgumentException("Last name has to be between 3-15 characters");
            }
        }

        private double height;
        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Person(string fName, string lName)
        {
            if (string.IsNullOrEmpty(fName))
                throw new ArgumentNullException("fName", "fName cannot be null");
            if (string.IsNullOrEmpty(lName))
                throw new ArgumentNullException("lName", "fName cannot be null");

            FName = fName;
            LName = lName;
        }
    }
}
