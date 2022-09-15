namespace SubjectManager.Infra.Repositories.Interfaces;
public interface ISubjectRepository{
    List<Subject> GetAllSubjects();
    Subject GetSubjectById(int id);
    Subject AddSubject(Subject subject);
    Subject EditSubject(Subject subject);
    Subject RemoveSubjectById(int id);
}