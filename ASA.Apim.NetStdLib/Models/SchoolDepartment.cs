using Department_WebService;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASA.Apim.NetStdLib.Models
{
    public class SchoolDepartment
    {
        public Department School { get; set; }
        public List<Department> Departments { get; set; } = new List<Department>();
    }
}
