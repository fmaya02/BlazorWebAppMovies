using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppMovies.Models
{
    [Table("user_account")]
    public class UserAccount
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("user_name")]
        [MaxLength(100)]
        public string? UserName { get; set; }

        [Required]
        [Column("password")]
        [MaxLength(100)]
        public string? UserPassword { get; set; }

        [Required]
        [Column("role")]
        [MaxLength(20)]
        public string? Role { get; set; }
    }
}
