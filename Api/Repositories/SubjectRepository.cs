using Api.Models;
using Api.Context;

namespace Api.Repositories;
public class SubjectRepository : ISubjectRepository
{
    private readonly DataContext _context;
    public SubjectRepository(DataContext context){
        _context = context;
    }
    public Subject AddSubject(Subject subject)
    {
        try
        {
            _context.Subjects.Add(subject);
            _context.SaveChanges();
            return subject;
        }
        catch (Exception e)
        {
            throw e;
        }

    }

    public Subject EditSubject()
    {
        throw new NotImplementedException();
    }

    public List<Subject> GetAllSubjects()
    {
        try{
            return _context.Subjects.ToList();
        }catch (Exception e){
            throw e;
        }
    }

    public Subject GetSubjectById(int Id)
    {
        throw new NotImplementedException();
    }

    public Subject RemoveSubject()
    {
        throw new NotImplementedException();
    }
}