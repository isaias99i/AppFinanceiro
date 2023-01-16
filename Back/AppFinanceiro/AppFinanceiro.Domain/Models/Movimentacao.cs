using AppFinanceiro.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinanceiro.Domain.Models
{
    public class Movimentacao : Base
    {
        public string Motivo { get; set; }
        public MetodoDeGasto Metodo { get; set; }
        public double Gasto { get; set; }
        public DateTime Data{ get; set;}
    }
}
