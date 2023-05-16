using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Dominio.Dominio
{
    [Table("tb_Setor")]
    public class Setor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSetor { get; set; }

        public string NomeSetor { get; set; }

        public Empresa Empresa { get; set; }

        [ForeignKey("Empresa")]
        public int Id_Empresa { get; set; }
    }
}
