using AppFinanceiro.Application.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinanceiro.Application.Interfaces
{
    public interface IApplicationServiceMovimentacao
    {
        void Add(MovimentacaoDTO obj);
        MovimentacaoDTO GetById(int id);
        IEnumerable<MovimentacaoDTO> GetAll();
        void Update(MovimentacaoDTO obj);
        void Remove(MovimentacaoDTO obj);
        void Dispose();
    }
}
