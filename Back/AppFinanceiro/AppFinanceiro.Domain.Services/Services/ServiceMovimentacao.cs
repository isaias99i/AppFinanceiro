using AppFinanceiro.Domain.Core.Interfaces.Repositorys;
using AppFinanceiro.Domain.Core.Interfaces.Services;
using AppFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinanceiro.Domain.Services.Services
{
    public class ServiceMovimentacao : ServiceBase<Movimentacao>, IServiceMovimentacao
    {
        public readonly IRepositoryMovimentacao _repositoryMovimentacao;

        public ServiceMovimentacao(IRepositoryMovimentacao RepositoryMovimentacao) : base(RepositoryMovimentacao)
        {
            _repositoryMovimentacao = RepositoryMovimentacao;
        }
    }
}
