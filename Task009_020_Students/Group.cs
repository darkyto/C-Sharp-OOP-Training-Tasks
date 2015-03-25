namespace Task009_020_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Group // task 16
    {
        public int GroupNumber { get; private set; }
        public string DepartmentName { get; private set; }

        public Group(int group , string name)
        {
            this.GroupNumber = group;
            this.DepartmentName = name;
        }
    }
}
