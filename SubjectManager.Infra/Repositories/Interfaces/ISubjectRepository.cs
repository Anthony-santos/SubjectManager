namespace SubjectManager.Infra.Repositories.Interfaces;
public interface ISubjectRepository{
    Task<List<Subject>> GetAllSubjectsAsync();
    Task<Subject> GetSubjectByIdAsync(int id);
    Task AddSubjectAsync(Subject subject);
    Task EditSubjectAsync(Subject subject);
    Task RemoveSubjectByIdAsync(int id);
}