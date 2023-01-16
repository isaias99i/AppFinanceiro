using System;
using System.Collections.Generic;
using System.Text;
using AppFinanceiro.Application.DTO.DTO;

namespace AppFinanceiro.Application.Interfaces
{
    public interface IApplicationServiceUsuario
    {
        void Add(UsuarioDTO obj);
        UsuarioDTO GetById(int id);
        IEnumerable<UsuarioDTO> GetAll();
        void Update(UsuarioDTO obj);
        void Remove(UsuarioDTO obj);
        void Dispose();
    }
}
