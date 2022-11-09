namespace SubjectManager.Infra.Repositories;

public class LessonRepository : ILessonRepository
{
    private readonly DataContext _context;
    public LessonRepository(DataContext context)
    {
        _context = context;
    }
    public async Task AddAsync(Lesson lesson)
    {
        _context.Lessons.Add(lesson);
        await _context.SaveChangesAsync();
    }

    public async Task<Lesson?> GetAsync(int id)
    {
        var entity = await _context.Lessons
            .FirstOrDefaultAsync(x => x.Id == id);
        return entity;
    }

    public async Task<List<Lesson>> GetFromSubjectAsync(int subjectId)
    {
        var entity = await _context.Lessons
            .Where(x => x.SubjectId == subjectId)
            .ToListAsync();
        return entity;
    }

    public async Task EditLessonAsync(int lessonId, Lesson lesson)
    {
        var entity = await _context.Lessons
            .FirstOrDefaultAsync(x => x.Id == lessonId);
        entity.DayOfWeak = lesson.DayOfWeak;
        entity.StartTime = lesson.StartTime;
        entity.EndTime = lesson.EndTime;
        await _context.SaveChangesAsync();
    }

    public async Task RemoveLessonAsync(Lesson lesson)
    {
        _context.Lessons.Remove(lesson);
        await _context.SaveChangesAsync();
    }
}