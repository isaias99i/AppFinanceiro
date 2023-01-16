using AppFinanceiro.Application.DTO.DTO.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinanceiro.Application.DTO.DTO
{
    public class MovimentacaoDTO
    {
        public int? Id { get; set; }
        public string Motivo { get; set; }
        public MetodoDeGasto Metodo { get; set; }
        public double Gasto { get; set; }
        public DateTime Data { get; set; }
    }
}
