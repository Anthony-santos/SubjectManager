namespace SubjectManager.Infra.Repositories;

public class SubjectRepository : ISubjectRepository
{
    private readonly DataContext _context;

    public SubjectRepository(DataContext context)
    {
        _context = context;
    }

    public async Task AddSubjectAsync(Subject subject)
    {
        _context.Subjects.Add(subject);
        await _context.SaveChangesAsync();
    }
    
    public async Task<List<Subject>> GetAllSubjectsAsync()
    {
        return await _context.Subjects
            .ToListAsync();
    }

    public async Task<Subject> GetSubjectByIdAsync(int Id)
    {
        var entity = await _context.Subjects
            .FirstOrDefaultAsync(x => x.Id == Id);
        return entity;
    }
    
    public async Task EditSubjectAsync(Subject subject)
    {
        var entity = await _context.Subjects
            .FirstOrDefaultAsync(x => x.Id == subject.Id);
        entity.Name = subject.Name;
        await _context.SaveChangesAsync();
    }

    public async Task RemoveSubjectByIdAsync(int Id)
    {
        var entity = await _context.Subjects
            .FirstOrDefaultAsync(x => x.Id == Id);
        _context.Subjects.Remove(entity);
        await _context.SaveChangesAsync();
    }
}