using AppFinanceiro.Domain.Core.Interfaces.Repositorys;
using AppFinanceiro.Domain.Core.Interfaces.Services;
using AppFinanceiro.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinanceiro.Domain.Services.Services
{
    public class ServiceUsuario : ServiceBase<Usuario>, IServiceUsuario
    {
        public readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario RepositoryUsuario) : base(RepositoryUsuario)
        {
            _repositoryUsuario= RepositoryUsuario;
        }
    }
}
