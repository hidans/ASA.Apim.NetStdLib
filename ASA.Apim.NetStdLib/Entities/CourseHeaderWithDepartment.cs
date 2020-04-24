using CourseHeader_WebService;
using Department_WebService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASA.Apim.NetStdLib.Entities
{
    public class CourseHeaderWithDepartment
    {
        public CourseHeader Info { get; set; }
        public Department Departments { get; set; }
        public CourseHeaderWithDepartment() { }

        public CourseHeaderWithDepartment(CourseHeader course, Department departments)
        {
            Info = course;
            Departments = departments;
        }

    }
}
