using Employee_Management.Core.Domain;
using Employee_Management.Data;

namespace Employee_Managemet.Services
{
    public class EmployeeServices
    {
        private readonly AppDbContext db;
        public EmployeeServices(AppDbContext db)
        {
            this.db=db;
        }
        public IEnumerable<Employee> EmployeeList()
        {
            return db.Employees.ToList();
        }
        public void Insert(Employee employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
        }
    }
}