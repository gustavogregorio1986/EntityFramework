using EntityFramework.Data.Repositorio;
using EntityFramework.Dominio.Dominio;
using EntityFramework.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Servico.Servico
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly UsuarioRepositorio _repositorio;

        public UsuarioServico()
        {
            _repositorio = new UsuarioRepositorio();
        }

        public void Adicionar(Usuario usuario)
        {
            _repositorio.Adicionar(usuario);
        }
    }
}
