namespace SubjectManager.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubjectController : ControllerBase
{
    private readonly ISubjectRepository _subjectRepository;
    public SubjectController(ISubjectRepository subjectRepository)
    {
        _subjectRepository = subjectRepository;
    }

    [HttpGet]
    [Route("")]
    public IActionResult GetAll()
    {
        var subjects = _subjectRepository.GetAllSubjects();
        return Ok(subjects);
    }

    [HttpGet]
    [Route("{id:int}")]
    public IActionResult GetById(int id)
    {
        var subject = _subjectRepository.GetSubjectById(id);
        return Ok(subject);
    }

    [HttpPost]
    [Route("")]
    public IActionResult Create([FromBody] Subject model)
    {
        if(ModelState.IsValid)
        {
            try
            {
                var subject = _subjectRepository.AddSubject(model);
                return Ok(subject);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        return StatusCode(412, "Ouver um erro ao tentar criar uma nova matéria");
    }
    [HttpPost]
    [Route("/edit")]
    public IActionResult Edit([FromBody] Subject model)
    {
        if (ModelState.IsValid)
        {
            try
            {
                var subject = _subjectRepository.EditSubject(model);
                return Ok(subject);
            }
            catch (Exception e)
            {
                throw e;
            }            
        }
        return StatusCode(412, "Ouve um erro ao tentar editar a matéria.");
    }

    [HttpDelete]
    [Route("{id:int}")]
    public IActionResult Delete(int id)
    {
        var subject = _subjectRepository.RemoveSubjectById(id);
        return Ok(subject);
    }
}
