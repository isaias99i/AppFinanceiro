using AppFinanceiro.Application.DTO.DTO;
using AppFinanceiro.Application.Interfaces;
using AppFinanceiro.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppFinanceiro.Application.Service
{
    public class ApplicationServiceUsuario : IApplicationServiceUsuario
    {
        private readonly IServiceUsuario _serviceUsuario;
        private readonly IMapperUsuario _mapperUsuario;

        public ApplicationServiceUsuario(IServiceUsuario ServiceUsuario, IMapperCliente MapperCliente)
        {
            _serviceUsuario= ServiceUsuario;
            _mapperUsuario = MapperCliente;
        }

        public void Add(UsuarioDTO obj)
        {
            var objUsuario = _mapperUsuario.MapperToEntity(obj);
            _serviceUsuario.Add(objUsuario);
        }

        public void Dispose()
        {
            _serviceUsuario.Dispose();
        }
    }
}
