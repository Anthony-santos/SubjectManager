namespace SubjectManager.Domain.Entities;
public class Subject : Entity
{
    private readonly IList<Class> _classes;
    public Subject(string name)
    {
        Name = name;
        _classes = new List<Class>();
        Active = true;
    }

    public string Name { get; private set; }
    public IReadOnlyCollection<Class> Classes
    {
        get { return _classes.ToArray();  }
    }

    public bool Active { get; private set; }

    public void Activate() => Active = true;
    public void Deactivate() => Active = false;
    
    public void AddClass(Class lesson)
    {
        
        _classes.Add(lesson);
    }
}
