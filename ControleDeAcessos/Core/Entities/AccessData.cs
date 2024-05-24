using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleDeAcessos.Core.Entities;

public class AccessData
{
    [Key]
    public int id {  get; set; }
    [Required]
    [MaxLength(100)]
    public string username { get; set; }
    [Required]
    [MaxLength(100)]
    [DataType(DataType.Password)]
    public string password { get; set; }
    public string platform { get; set; }
    public string description { get; set; }
    [Required]
    public int userId { get; set; }
    [ForeignKey(nameof(userId))]
    public virtual Users User {  get; set; }
}