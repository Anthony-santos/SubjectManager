namespace SubjectManager.Api.Services.Interfaces;

public interface ISubjectService
{
    Task<List<Subject>> GetAllSubjectsAsync();
    Task<Subject> GetSubjectByIdAsync(int id);
    Task<Subject> AddSubjectAsync(Subject model);
    Task<Subject> EditSubject(int id, Subject model);
    Task<Subject> RemoveSubjectById(int id);
}