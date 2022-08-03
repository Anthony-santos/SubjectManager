using Api.Models;
using Api.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubjectController
{
    private readonly ISubjectRepository _subjectRepository;
    public SubjectController(ISubjectRepository subjectRepository)
    {
        _subjectRepository = subjectRepository;
    }

    [HttpGet(Name = "GetSubjects")]
    public IEnumerable<Subject> Get()
    {
        return _subjectRepository.GetAllSubjects();
    }
    public IEnumerable<Subject> Add(Subject? subject){
        try
        {
            _subjectRepository.AddSubject(subject);
            return subject;
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}
