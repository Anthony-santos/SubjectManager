namespace SubjectManager.Infra.Repositories.Interfaces;

public interface ILessonRepository
{
    Task AddAsync(Lesson lesson);
    Task<Lesson?> GetAsync(int id);
    Task<List<Lesson>> GetFromSubjectAsync(int subjectId);
    Task EditLessonAsync(int lessonId, Lesson lesson);
    Task RemoveLessonAsync(Lesson lesson);
}