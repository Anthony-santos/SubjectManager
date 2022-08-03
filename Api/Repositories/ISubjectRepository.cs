using Api.Models;

namespace Api.Repositories;
public interface ISubjectRepository{
    List<Subject> GetAllSubjects();
    Subject GetSubjectById(int id);
    Subject AddSubject(Subject subject);
    Subject EditSubject(Subject subject);
    Subject RemoveSubjectById(int id);
}