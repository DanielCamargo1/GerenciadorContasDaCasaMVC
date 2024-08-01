using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ContaHoueseMvc.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Necessario adicionar um nome!")]
        [DisplayName("Nome Da Conta")]
        public string NomeDaConta { get; set; }
        //public IFormFile CodigoDeBarras { get; set; }
        [Required(ErrorMessage = "Adicionar a data de vencimento!")]
        public DateTime Vencimento { get; set; }
        public DateTime DataPublicacao { get; set; } = DateTime.Now;
        public bool Situacao { get; set; } = false;
        [Required(ErrorMessage = "Necessario adicionar um valor!")]
        public double Valor { get; set; }
    }
}
