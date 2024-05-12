using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace troca_games.Models
{
    [Table("Jogos")]
    public class Jogo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Jogo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Console")]
        public string Console { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Venda/Aluguel")]
        public NegociacaoJogo NegociacaoJogo { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Condição")]
        public CondicaoJogo CondicaoJogo { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Proprietário")]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        [Display(Name = "Proprietário")]
        public Usuario Usuario { get; set; }
    }

    public enum NegociacaoJogo
    {
        Venda, Aluguel
    }

    public enum CondicaoJogo
    {
        Novo, Usado
    }
}