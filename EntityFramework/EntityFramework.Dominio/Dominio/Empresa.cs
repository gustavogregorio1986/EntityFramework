using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Dominio.Dominio
{
    [Table("tb_Empresa")]
    public class Empresa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEmpresa { get; set; }

        public string NomeEmopresa { get; set; }

        public string Cpf { get; set; }

        public Candidato Candidato { get; set; }

        [ForeignKey("Candidato")]
        public int Id_Candidato { get; set; }
    }
}
