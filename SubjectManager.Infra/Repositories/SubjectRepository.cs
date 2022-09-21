namespace SubjectManager.Infra.Repositories;

public class SubjectRepository : ISubjectRepository
{
    private readonly DataContext _context;

    public SubjectRepository(DataContext context)
    {
        _context = context;
    }

    public async Task<List<Subject>> GetAllSubjectsAsync()
    {
        return await _context.Subjects
            .ToListAsync();
    }

    public async Task AddSubjectAsync(Subject subject)
    {
        _context.Subjects.Add(subject);
        await _context.SaveChangesAsync();
    }

    public async Task EditSubjectAsync(Subject subject)
    {
        var s = await _context.Subjects
            .FirstOrDefaultAsync(x => x.Id == subject.Id);
        s.Name = subject.Name;
        s.Lessons = subject.Lessons;
        await _context.SaveChangesAsync();
    }

    public async Task<Subject> GetSubjectByIdAsync(int Id)
    {
        return await _context.Subjects
            .FirstOrDefaultAsync(x => x.Id == Id);
    }

    public async Task RemoveSubjectByIdAsync(int Id)
    {
        var subject = await _context.Subjects.FirstOrDefaultAsync(x => x.Id == Id);
        _context.Subjects.Remove(subject);
        await _context.SaveChangesAsync();
    }
}