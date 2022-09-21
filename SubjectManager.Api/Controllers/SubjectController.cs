namespace SubjectManager.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubjectController : ControllerBase
{
    private readonly ISubjectService _subjectService;

    public SubjectController(ISubjectService subjectService)
    {
        _subjectService = subjectService;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var subjects = await _subjectService.GetAllSubjectsAsync();
            return Ok(subjects);
        }
        catch (Exception ex)
        {
            return BadRequest(new List<string> { ex.Message });
        }
    }

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        try
        {
            var subject = await _subjectService.GetSubjectByIdAsync(id);
            return Ok(subject);
        }
        catch (Exception ex)
        {
            return BadRequest(new List<string> { ex.Message });
        }
    }

    [HttpPost("")]
    public async Task<IActionResult> Create([FromBody] Subject model)
    {
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState.Values.SelectMany(v => v.Errors.Select(b => b.ErrorMessage)));

        try
        {
            var subject = await _subjectService.AddSubjectAsync(model);
            return Ok(subject);
        }
        catch (Exception ex)
        {
            return BadRequest(new List<string> { ex.Message });
        }
    }

    [HttpPost("edit/{id:int}")]
    public async Task<IActionResult> Edit(int id, [FromBody] Subject model)
    {
        if (!ModelState.IsValid)
            return UnprocessableEntity(ModelState.Values.SelectMany(v => v.Errors.Select(b => b.ErrorMessage)));

        try
        {
            var subject = await _subjectService.EditSubject(id, model);
            return Ok(subject);
        }
        catch (Exception ex)
        {
            return BadRequest(new List<string> { ex.Message });
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _subjectService.RemoveSubjectById(id);
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(new List<string> { ex.Message });
        }
    }
}