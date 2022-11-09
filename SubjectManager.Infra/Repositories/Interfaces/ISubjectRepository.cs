namespace SubjectManager.Infra.Repositories.Interfaces;
public interface ISubjectRepository{
    Task AddSubjectAsync(Subject subject);
    Task<List<Subject>> GetAllSubjectsAsync();
    Task<Subject> GetSubjectByIdAsync(int id);
    Task EditSubjectAsync(Subject subject);
    Task RemoveSubjectByIdAsync(int id);
}