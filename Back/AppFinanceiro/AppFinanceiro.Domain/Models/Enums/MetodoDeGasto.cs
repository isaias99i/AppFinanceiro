using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinanceiro.Domain.Models.Enums
{
    public enum MetodoDeGasto : int
    {
        Nubank = 0,
        BancoInter = 1,
        Caixa = 2,
        C6Bank = 3, 
        Rico = 4, 
        BancoDoBrasil = 5, 
        Físico = 6
    }
}
