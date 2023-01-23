using Practise.Core.Domain;
using Practise.Data;

namespace Practise.Service
{
    public class StudentService
    {
        private readonly AppDbContext context;

        public StudentService(AppDbContext context)
        {
            this.context = context;
        }
        public void Insert(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
        
        public IEnumerable<Student> StudentList()
        {
            return context.Students.ToList();
        }

    }
}