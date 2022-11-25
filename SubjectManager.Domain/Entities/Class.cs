namespace SubjectManager.Domain.Entities;
public class Class : Entity
{
    public Class(EDayOfWeek dayOfWeek, int starTime, int endTime)
    {
        DayOfWeek = dayOfWeek;
        StarTime = starTime;
        EndTime = endTime;
    }

    public EDayOfWeek DayOfWeek { get; private set; }
    public int StarTime { get; private set; }
    public int EndTime { get; private set; }
}
