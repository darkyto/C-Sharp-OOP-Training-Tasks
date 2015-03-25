/*
Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
Create a List<Student> with sample students. Select only the students that are from group number 2.
Use LINQ query. Order the students by FirstName.
 */
namespace Task009_020_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string studentID;
        private string phoneNumber;
        private string email;
        private List<double> marks;
        private int group;


        public Student(string firstName, string lastName, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Group = group;
        }
        public Student(string firstName, string lastName, string id, string phone, string mail, List<double> marks, int group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.StudentID = id;
            this.PhoneNumber = phone;
            this.Email = mail;
            this.Marks = marks;
            this.Group = group;
        }

        #region properties
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public List<double> Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        #endregion

        #region methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.FirstName);
            sb.AppendLine(this.LastName);
            if (this.StudentID != null)
            {
                sb.AppendLine(this.StudentID);
            }
            if (this.PhoneNumber != null)
            {
                sb.AppendLine("Phone number : "+this.PhoneNumber);
            }
            if (this.Email != null)
            {
                sb.AppendLine("E-mail : "+this.Email);
            }
            if (marks.Count != 0)
            {
                sb.AppendLine("Marks: " + string.Join(", ",this.Marks));
            }
            sb.AppendLine(string.Format("Group : {0} ", this.Group));

            return sb.ToString();
        }

        #endregion
    }
}
