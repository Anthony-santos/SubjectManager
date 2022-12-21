namespace SubjectManager.Domain.Entities;

public class Lesson : Entity
{
    public Lesson(EDayOfWeek dayOfWeek, string startTime, string endTime)
    {
        DayOfWeek = dayOfWeek;
        StartTime = startTime;
        EndTime = endTime;

        AddNotifications(new Contract<Notification>()
            .IsLowerThan((int)DayOfWeek, 7, "Lesson.DayOfWeek", "Day of week is bigger than supported.")
            .IsGreaterThan((int)DayOfWeek, 1, "Lesson.DayOfWeek", "Day of week is lower than supported.")
            .IsGreaterThan(StartTime, 2, "Lesson.StartTime", "Start time has to have more than 2 characters.")
            .IsGreaterThan(EndTime, 2, "Lesson.EndTime", "Start time has to have more than 2 characters."));
    }

    public EDayOfWeek DayOfWeek { get; private set; }
    public string StartTime { get; private set; }
    public string EndTime { get; private set; }
}