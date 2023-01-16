using System;
using AppFinanceiro.Application.DTO.DTO.Enums;

namespace AppFinanceiro.Application.DTO.DTO
{
    public class UsuarioDTO
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        public MetodoDeGasto Metodo { get; set; }
        public double Seguranca { get; set; }
    }
}
