using System.ComponentModel.DataAnnotations;

namespace ControleDeAcessos.Data.Domain;

public class Users
{
    [Key]
    public int id { get; set; }
    [Required]
    [MaxLength(30)]
    public string username { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string password { get; set; }
    [Required]
    public string name { get; set; }
    public string? email { get; set; }
}
