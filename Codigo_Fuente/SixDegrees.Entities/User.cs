using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SixDegrees.Entities.Commons;

namespace SixDegrees.Entities
{
#nullable enable
    [Table("Usuarios")]
    public class User
    {
        [Key]
        [Column("UsuId")]
        public long UserId { get; set; }

        [MaxLength(100, ErrorMessage = ErrorMessages.MaxLenghtName)]
        [Column("Nombre")]
        public string? Name { get; set; }

        [MaxLength(100, ErrorMessage = ErrorMessages.MaxLenghtName)]
        [Column("Apellido")]
        public string? LastName { get; set; }
    }
#nullable disable
}
