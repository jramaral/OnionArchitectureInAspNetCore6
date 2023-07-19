using DomainLayer.Data;
using DomainLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ICustomServices;

namespace OnionArchitectureInAspNetCore6WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController: ControllerBase
    {
        private readonly ICustomService<Student> _service;
        private readonly ApplicationDbContext _context;

        public StudentsController(ICustomService<Student> service, ApplicationDbContext context)
        {
            _service = service;
            _context = context;
        }

        [HttpGet(nameof(GetStudentById))]
        public IActionResult GetStudentById(int id)
        {
            var obj = _service.Get(id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllStudent))]
        public IActionResult GetAllStudent()
        {
            var obj = _service.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost(nameof(CreateStudent))]
        public IActionResult CreateStudent(Student student)
        {
            if (student != null)
            {
                _service.Insert(student);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPost(nameof(UpdateStudent))]
        public IActionResult UpdateStudent(Student student)
        {
            if (student != null)
            {
                _service.Update(student);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete(nameof(DeleteStudent))]
        public IActionResult DeleteStudent(Student student)
        {
            if (student != null)
            {
                _service.Delete(student);
                return Ok("Deleted Successfully");
            }
            else
            {
                return BadRequest("Something went wrong");
            }
        }
    }
}
