using Microsoft.AspNetCore.Mvc;

namespace DependencyInversion.Controllers;

[ApiController, Route("student")]
public class StudentController : ControllerBase
{
    // StudentRepository studentRepository = new StudentRepository();
    // Logbook logbook = new Logbook();

    IStudentRepository studentRepository;
    ILogbook logbook;

    public StudentController(IStudentRepository student, ILogbook book)
    {
        studentRepository = student;
        logbook = book;
    }

    [HttpGet]
    public IEnumerable<Student> Get()
    {
        logbook.Add($"returning student's list");
        return studentRepository.GetAll();
    }

    [HttpPost]
    public void Add([FromBody] Student student)
    {
        studentRepository.Add(student);
        logbook.Add($"The Student {student.Fullname} have been added");
    }
}
