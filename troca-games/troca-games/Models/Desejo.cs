using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace troca_games.Models
{
    [Table("Desejos")]
    public class Desejo
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Jogo")]
        public int JogoId { get; set; }

        public string Usuario { get; set; }

        public virtual Jogo Jogo { get; set; }
    }
}
