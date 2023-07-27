namespace SubjectManager.Domain.Entities;

public class Subject : Entity
{
    private readonly IList<Lesson> _lessons;

    public Subject(string name)
    {
        _lessons = new List<Lesson>();
        Name = name;
        CreatedAt = DateTime.Now;
        Validate();
    }

    public string Name { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public IEnumerable<Lesson> Lessons => _lessons.ToArray();

    public bool AddLesson(Lesson lesson)
    {
        var collided = _lessons.Aggregate(false, (current, l)
            => current || l.CollideWith(lesson));

        if (collided)
            lesson.AddNotification("Subject.Lesson", "Lesson collide with other lesson already added");

        AddNotifications(lesson.Notifications);
        if (!lesson.IsValid) return false;

        _lessons.Add(lesson);
        return true;
    }

    private void Validate()
    {
        AddNotifications(new Contract<Notification>()
            .IsGreaterThan(Name, 2, "Subject.Name", "Subject name has to have more than 2 characters."));
    }
}