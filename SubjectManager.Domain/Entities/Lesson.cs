namespace SubjectManager.Domain.Entities;

public class Lesson : Entity
{
    public Lesson(EDayOfWeek dayOfWeek, string startTime, string endTime)
    {
        DayOfWeek = dayOfWeek;
        StartTime = TimeSpan.Parse(startTime);
        EndTime = TimeSpan.Parse(endTime);
        Validate();
    }

    public EDayOfWeek DayOfWeek { get; private set; }
    public TimeSpan StartTime { get; private set; }
    public TimeSpan EndTime { get; private set; }
    public TimeSpan Duration => EndTime - StartTime;

    public bool CollideWith(Lesson lesson)
    {
        if (DayOfWeek != lesson.DayOfWeek) return false;

        var newLessonBeginningCollide = StartTime <= lesson.StartTime && lesson.StartTime <= EndTime;
        var newLessonEndingCollide = StartTime <= lesson.EndTime && lesson.EndTime <= EndTime;

        var oldLessonBeginningCollide = lesson.StartTime <= StartTime && StartTime <= lesson.EndTime;
        var oldLessonEndingCollide = lesson.StartTime <= EndTime && EndTime <= lesson.EndTime;

        return newLessonBeginningCollide || newLessonEndingCollide || oldLessonBeginningCollide || oldLessonEndingCollide;
    }

    private void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsLowerThan((int)DayOfWeek, 7, "Lesson.DayOfWeek", "Day of week is bigger than supported.")
            .IsGreaterThan((int)DayOfWeek, 1, "Lesson.DayOfWeek", "Day of week is lower than supported.")
            .IsGreaterOrEqualsThan(EndTime, StartTime, "Lesson.Duration", "End time need to be bigger than start time."));
    }
}