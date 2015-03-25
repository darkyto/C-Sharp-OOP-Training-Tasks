using System;
using System.Collections.Generic;
namespace Task003_005_Students
{
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        private string firstname;
        private string lastName;
        private int age;

        #region
        public Student(string firstName, string lastName)
        {
            this.Firstname = firstName;
            this.LastName = lastName;
        }
        public Student(string firstName, string lastName, int age)
            : this(firstName, lastName)
        {
            this.Age = age;
        }
        #endregion

        #region Properties
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can not be null or empty string");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }
        public string Firstname
        {
            get { return this.firstname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can not be null or empty string");
                }
                else
                {
                    this.firstname = value;
                }
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (age < 0 || age > 150)
                {
                    throw new ArgumentOutOfRangeException("Invalid age entered Enter integer values within 12 and 150");
                }
                else
                {
                    this.age = value;
                }
            }
        }
        #endregion


        #region Methods
        public override string ToString()
        {
            return string.Format("Student : " + this.firstname + " " + this.lastName); //  
        }
        public string ToStringAge()
        {
            return string.Format("Student : " + this.firstname + " " + this.lastName + " \nYears : " + this.age + "\n"); //  
        }

        #endregion
    }

}
