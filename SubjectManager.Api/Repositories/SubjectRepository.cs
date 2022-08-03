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

    public Subject EditSubject(Subject subject)
    {
        try
        {
            var s = _context.Subjects.FirstOrDefault(x => x.Id == subject.Id);

            if (s != null)
            {
                s.Name = subject.Name;
                s.Lessons = subject.Lessons;

                _context.SaveChanges();
                return subject;
            }
            return null;
        }
        catch (Exception e)
        {
            throw e;
        }
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
        try
        {
            return _context.Subjects.FirstOrDefault(x => x.Id == Id);;
        }
        catch (Exception e)
        {
            throw e;
        }
    }

    public Subject RemoveSubjectById(int Id)
    {
        try
        {
            var subject = _context.Subjects.FirstOrDefault(x => x.Id == Id);
            _context.Subjects.Remove(subject);
            _context.SaveChanges();
            return subject;
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}