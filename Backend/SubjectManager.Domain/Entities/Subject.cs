namespace SubjectManager.Domain.Entities;

public class Subject : Entity
{
    private readonly IList<Lesson> _lessons;
    
    protected Subject()
    {
        _lessons = new List<Lesson>();
    }

    public Subject(string name)
    {
        _lessons = new List<Lesson>();
        Name = name;
        CreatedAt = DateTime.Now;
        Validate();
    }

    public string Name { get; private set; } = null!;
    public DateTime CreatedAt { get; private set; }

    public IEnumerable<Lesson> Lessons => _lessons.ToArray();

    public void AddLesson(Lesson lesson)
    {
        var isColiding = _lessons.Aggregate(false, (current, l)
            => current || l.CollideWith(lesson));

        if (isColiding)
            lesson.AddNotification("Subject.Lesson", "Lesson collide with other lesson already added");

        AddNotifications(lesson.Notifications);
        if (!lesson.IsValid) return;

        _lessons.Add(lesson);
    }

    private void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsNotNullOrWhiteSpace(Name, "Subject.Name", "Subject name can't be null or empty."));
    }
}