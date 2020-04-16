using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Data.Entities
{
    public class Department
    {
        public Department(int id, string departmentName)
        {
            Id = id;
            DepartmentName = departmentName;
        }

        public int Id { set; get; }
        public string DepartmentName { set; get; }
    }
}
