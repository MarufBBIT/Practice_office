using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management.Core.Domain
{
    public class Employee:BaseEntity
    {
        public string EmployeeFirstName { get; set; } = default!;
        public string EmployeeLastName { get; set; } = default!;
        public DateTime JoinDate { get; set; }
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
    }
}
