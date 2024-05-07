using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace troca_games.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public Perfil Perfil { get; set; }

        public ICollection<Jogo> Jogos { get; set; }
    }

    public enum Perfil
    { Admin, User}
}
