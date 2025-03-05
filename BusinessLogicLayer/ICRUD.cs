using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface ICRUD
    {
        void Create(Student std);
        List<Student> Get();
        void Update(int id, Student std);
        void Delete(int id);
        List<Student> GetStudentByID(int id);
        //Task ResetIdentity();
    }
}
