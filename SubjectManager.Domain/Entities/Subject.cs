namespace SubjectManager.Domain.Entities;

public class Subject : Entity
{
    private readonly IList<Lesson> _lessons;

    public Subject(string name)
    {
        _lessons = new List<Lesson>();
        Name = name;
        CreatedAt = DateTime.Now;
        
        AddNotifications(new Contract<Notification>()
            .IsGreaterThan(name,2,"Subject.Name", "Subject name has to have more than 2 characters."));
    }

    public string Name { get; private set; }
    public DateTime CreatedAt { get; private set; }

    public IReadOnlyCollection<Lesson> Lessons => _lessons.ToArray();

    public void AddLesson(Lesson lesson)
    {
        AddNotifications(lesson.Notifications);
        if(lesson.IsValid)
            _lessons.Add(lesson);
    }
}