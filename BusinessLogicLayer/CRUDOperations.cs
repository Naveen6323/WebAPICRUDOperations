using DataAccessLayer;
using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer
{
    public class CRUDOperations:ICRUD
    {
        private readonly StudentDBContext context;
        public CRUDOperations(StudentDBContext context)
        {
            this.context = context;
        }

        public void Create(Student std)
        {
            //await ResetIdentity();
             context.Students.Add(std);
             context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.Students.Remove(context.Students.Find(id));
            context.SaveChanges();
        }
        public List<Student> Get()
        {
            return context.Students.ToList();
        }
        public void Update(int id, Student std)
        {
            context.Students.Update(std);
            context.SaveChanges();
        }
        public List<Student> GetStudentByID(int id)
        {
           
            return context.Students.Where(e=>e.rollno==id).ToList();
        }
        //public async Task ResetIdentity()
        //{
        //    var reset = await context.Students.MaxAsync(s => s.rollno);
        //    if(reset==null)
        //    {
        //        reset = 0;
        //    }
        //    await context.Database.ExecuteSqlRawAsync($"DBCC CHECKIDENT('Students', RESEED, {reset})");
        //}
    }
}
