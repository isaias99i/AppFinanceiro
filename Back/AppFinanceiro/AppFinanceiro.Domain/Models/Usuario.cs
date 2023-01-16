using AppFinanceiro.Domain.Models.Enums;

namespace AppFinanceiro.Domain.Models
{
    public class Usuario : Base
    {
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public MetodoDeGasto Metodo{ get; set; }
        public double Seguranca { get; set; }
    }
}
