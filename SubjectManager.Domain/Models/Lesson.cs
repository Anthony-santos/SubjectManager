namespace SubjectManager.Domain.Models;
public class Lesson
{
    [Key]
    [Range(0, 99999)]
    public int Id { set; get; }

    [Required(ErrorMessage = "Este campo é obrigatorio")]
    [Range(0, 99999)]
    public int SubjectId { set; get; }

    [Required(ErrorMessage = "Este campo é obrigatorio", AllowEmptyStrings = false)]
    [RegularExpression($"/^([1-8])$/", ErrorMessage = "Campo DayOfWeak não permite números")]
    public int DayOfWeak { set; get; }

    [Required(ErrorMessage = "Este campo é obrigatorio", AllowEmptyStrings = false)]
    public string StartTime { set; get; } = null!;
    
    [Required(ErrorMessage = "Este campo é obrigatorio", AllowEmptyStrings = false)]
    public string EndTime { set; get; } = null!;
}
