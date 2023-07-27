using SubjectManager.Domain.ValueObjects;

namespace SubjectManager.Domain.Entities;

public class Semester : Entity
{
    private readonly IList<Subject> _subjects;

    public Semester(string tittle)
        : this(new Period(tittle))
    {
    }

    public Semester(Period period)
    {
        _subjects = new List<Subject>();
        Period = period;
        Active = false;

        AddNotifications(Period.Notifications);
    }

    public Period Period { get; private set; }
    public bool Active { get; private set; }
    public IReadOnlyCollection<Subject> Subjects => _subjects.ToArray();

    public void AddSubject(Subject subject)
    {
        AddNotifications(subject.Notifications);
        if (subject.IsValid)
            _subjects.Add(subject);
    }

    public void Activate() => Active = true;
    public void Deactivate() => Active = false;
}