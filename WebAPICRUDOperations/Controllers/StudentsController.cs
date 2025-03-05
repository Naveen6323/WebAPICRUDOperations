using BusinessLogicLayer;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPICRUDOperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ICRUD crud;
        public StudentsController(ICRUD context)
        {
            crud = context;
        }
        [HttpGet]
        public ActionResult<List<Student>> GetStudents()
        {
            var data= crud.Get();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public ActionResult GetStudentById(int id)
        {
            var data = crud.Get().Find(e=>e.rollno==id);
            if (data == null)
            {
                return NotFound();
            }
            return Ok(crud.GetStudentByID(id));
        }

        [HttpPost]
        public  ActionResult AddStudent(Student std)
        {
             crud.Create(std);
            return Ok("added succesfully");
        }
        [HttpPut("{id}")]
        public  ActionResult UpdateStudent( int id,Student std)
        {
            if (id != std.rollno)
            {
                return BadRequest();
            }
            crud.Update(id, std);
            return Ok("updated");
        }
        [HttpDelete("{id}")]
        public  ActionResult DeleteStudent(int id)
        {
            if(crud.Get().Find(e=>e.rollno==id)==null)
            {
                return NotFound();
            }
            crud.Delete(id);
            return Ok("succeccfully removed");
        }

    }
}
