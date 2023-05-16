using EntityFramework.Data.Repositorio.Interfce;
using EntityFramework.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Data.Repositorio
{
    public class UsuarioRepositorio : GenericRepositorio<Usuario>, IUsuarioRepository
    {
    }
}
