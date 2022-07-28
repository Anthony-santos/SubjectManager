namespace Api.Models;
public class Subject
{
    public int Id { set; get; }
    public string Name { set; get; }
    public List<Lesson>? Lessons { set; get; }

}
