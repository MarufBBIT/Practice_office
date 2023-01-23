using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Core.Domain
{
    public class Department:BaseEntity
    {
        public string DepartmentName { get; set; } = default!;
    }
}
