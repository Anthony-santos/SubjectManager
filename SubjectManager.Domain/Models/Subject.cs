namespace SubjectManager.Domain.Models;
public class Subject
{
    [Key]
    [Range(0, 99999)]
    public int Id { set; get; }

    [Required(ErrorMessage = "Este campo é obrigatorio", AllowEmptyStrings = false)]
    [MaxLength(25, ErrorMessage = "Esta campo deve ter no mpaximo 35 caracteres")]
    public string Name { set; get; } = null!;
}
