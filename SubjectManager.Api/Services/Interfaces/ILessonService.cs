namespace SubjectManager.Api.Services.Interfaces;

public interface ILessonService
{
    Task AddAsync(Lesson lesson);
    Task<Lesson> GetAsync(int id);
    Task<List<Lesson>> GetFromSubjectAsync(int subjectId);
    Task EditLessonAsync(int lessonId, Lesson lesson);
    Task RemoveLessonAsync(int lessonId);
}