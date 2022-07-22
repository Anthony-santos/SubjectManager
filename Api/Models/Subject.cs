namespace Api.Models;
public class Subject
{
    public Subject(string Name, List<Lesson> Lessons)
    {
        this.Name = Name;
        this.Lessons = Lessons;
    }    
    public int Id { set; get; }
    public string Name { set; get; }
    public List<Lesson> Lessons { set; get; }

}
