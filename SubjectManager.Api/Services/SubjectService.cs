namespace SubjectManager.Api.Services;

public class SubjectService : ISubjectService
{
    private readonly ISubjectRepository _subjectRepository;

    public SubjectService(ISubjectRepository subjectRepository)
    {
        _subjectRepository = subjectRepository;
    }
    public async Task<List<Subject>> GetAllSubjectsAsync()
    {
        var list = await _subjectRepository.GetAllSubjectsAsync();
        if (list.Count == 0)
            throw new Exception("Nenhuma matéria encontrada");

        return list;
    }

    public async Task<Subject> GetSubjectByIdAsync(int id)
    {
        var subject = await _subjectRepository.GetSubjectByIdAsync(id);
        if (subject == null)
            throw new Exception("Matéria não existe");

        return subject;
    }

    public async Task<Subject> AddSubjectAsync(Subject model)
    {
        await _subjectRepository.AddSubjectAsync(model);
        return model;
    }

    public async Task<Subject> EditSubject(int id, Subject model)
    {
        var subject = await this.GetSubjectByIdAsync(id);

        subject.Name = model.Name;
        await _subjectRepository.EditSubjectAsync(subject);
        return model;
    }

    public async Task RemoveSubjectById(int id)
    {
        await _subjectRepository.RemoveSubjectByIdAsync(id);
    }
}