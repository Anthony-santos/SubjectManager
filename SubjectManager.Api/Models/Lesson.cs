using System.ComponentModel.DataAnnotations;

namespace Api.Models;
public class Lesson
{
    [Key]
    public int Id { set; get; }

    [Required(ErrorMessage = "Este campo é obrigatorio")]
    public int SubjectId { set; get; }

    [Required(ErrorMessage = "Este campo é obrigatorio", AllowEmptyStrings = false)]
    public string DayOfWeak { set; get; } = null!;

    [Required(ErrorMessage = "Este campo é obrigatorio", AllowEmptyStrings = false)]
    public string StartTime { set; get; } = null!;
    
    [Required(ErrorMessage = "Este campo é obrigatorio", AllowEmptyStrings = false)]
    public string EndTime { set; get; } = null!;
}
