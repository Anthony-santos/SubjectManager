using System.ComponentModel.DataAnnotations;

namespace Api.Models;
public class Subject
{
    [Key]
    public int Id { set; get; }
    public string? Name { set; get; }
    public List<Lesson>? Lessons { set; get; }

}
