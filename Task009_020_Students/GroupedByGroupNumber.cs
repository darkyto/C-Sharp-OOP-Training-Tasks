namespace Task009_020_Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class GroupedByGroupNumber
    {
        public static IEnumerable<Student> SortByGroups(IEnumerable<Student> students)
        {
            var groupedResult = from name in students
                                group name by name.Group into grouped
                                from newName in grouped
                                orderby newName.Group
                                select newName;          

            return groupedResult;
        }
    }
}
