namespace ContaHoueseMvc.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        public string NomeDaConta { get; set; }
        public IFormFile CodigoDeBarras { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime DataPublicacao { get; set; } = DateTime.Now;
        public bool Situacao { get; set; } = false;
        public double Valor { get; set; }
    }
}
