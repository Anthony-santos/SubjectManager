namespace SubjectManager.Api.Services;

public class LessonService : ILessonService
{
    private readonly ISubjectService _subjectService;
    private readonly ILessonRepository _lessonRepository;

    public LessonService(ISubjectService subjectService, ILessonRepository lessonRepository)
    {
        _subjectService = subjectService;
        _lessonRepository = lessonRepository;
    }
    
    public async Task AddAsync(Lesson lesson)
    {
        await _lessonRepository.AddAsync(lesson);
    }

    public async Task<Lesson> GetAsync(int id)
    {
        var entity = await _lessonRepository.GetAsync(id);
        if (entity == null)
            throw new Exception("Aula não econtrada");
        return entity;
    }

    public async Task<List<Lesson>> GetFromSubjectAsync(int subjectId)
    {
        await _subjectService.GetSubjectByIdAsync(subjectId);

        var entity = await _lessonRepository.GetFromSubjectAsync(subjectId);
        return entity;
    }

    public async Task EditLessonAsync(int lessonId, Lesson lesson)
    {
        var entity = await GetAsync(lessonId);

        entity.DayOfWeak = lesson.DayOfWeak;
        entity.StartTime = lesson.StartTime;
        entity.EndTime = lesson.EndTime;
    }

    public async Task RemoveLessonAsync(int lessonId)
    {
        var entity = await GetAsync(lessonId);
        await _lessonRepository.RemoveLessonAsync(entity);
    }
}