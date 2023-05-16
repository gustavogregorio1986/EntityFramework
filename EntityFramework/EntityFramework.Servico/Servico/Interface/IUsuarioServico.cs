using EntityFramework.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Servico.Servico.Interface
{
    public interface IUsuarioServico
    {
        void Adicionar(Usuario usuario);
    }
}
