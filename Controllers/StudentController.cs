using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentERP.Models;

namespace studentERP.Controllers;
[ApiController]
[Route("[controller]")]

public class StudentController : ControllerBase
{
    private readonly StudentDBContext _studentDBContext;

    public StudentController(StudentDBContext studentDBContext)
    {
        _studentDBContext = studentDBContext;
    }
    
    // HTTP GET API CALL
    // HTTP POST API CALL

    [HttpGet("GetStudents")]
    public async Task<IEnumerable<Student>> GetStudents()
    {
        return await _studentDBContext.Students.ToListAsync();
    }

    [HttpPost("AddStudent")]
    public async Task<ActionResult<Student>> AddStudent(Student objStudent)
    {
        _studentDBContext.Students.Add(objStudent);
        await _studentDBContext.SaveChangesAsync();
        return Ok(objStudent);
    }
    
}