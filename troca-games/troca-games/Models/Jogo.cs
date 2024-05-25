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

        [Display(Name = "Venda/Aluguel")]
        public NegociacaoJogo NegociacaoJogo { get; set; }

        [Display(Name = "Condição")]
        public CondicaoJogo CondicaoJogo { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        public decimal Valor { get; set; }

        [Display(Name = "Vendedor")]
        public string Vendedor { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-mail de contato")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório")]
        [Display(Name = "Status")]
        public Status Status { get; set; }

        [Display(Name = "Comprador")]
        public string? Comprador { get; set; }

        [Display(Name = "Aviso")]
        public Aviso? Aviso { get; set; }

        public virtual ICollection<Desejo> Desejos { get; set; }
    }

    public enum NegociacaoJogo
    {
        Venda, Aluguel
    }

    public enum CondicaoJogo
    {
        Novo, Usado
    }

    public enum Status
    {
        [Display(Name = "Disponível")]
        Disponivel,
        [Display(Name = "Indisponível")]
        Indisponivel
    }

    public enum Aviso
    {
        Cancelado, Reservado
    }
}
