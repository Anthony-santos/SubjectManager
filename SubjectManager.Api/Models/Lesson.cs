using System.ComponentModel.DataAnnotations;

namespace Api.Models;
public class Lesson
{
    [Key]
    public int Id { set; get; }
    public string? DayOfWeak { set; get; }
    public string? StartTime { set; get; }
    public string? EndTime { set; get; }
}
