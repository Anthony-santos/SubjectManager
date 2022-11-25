namespace SubjectManager.Domain.Entities;
public class Class : Entity
{
    public Class(EDayOfWeek dayOfWeek, TimeOnly starTime, TimeOnly endTime)
    {
        DayOfWeek = dayOfWeek;
        StarTime = starTime;
        EndTime = endTime;
    }

    public EDayOfWeek DayOfWeek { get; private set; }
    public TimeOnly StarTime { get; private set; }
    public TimeOnly EndTime { get; private set; }
}
