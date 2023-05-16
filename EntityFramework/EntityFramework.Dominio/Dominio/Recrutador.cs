using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Dominio.Dominio
{
    [Table("tb_Recrutador")]
    public class Recrutador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdRecrutador { get; set; }

        public string NomeRecrutador { get; set; }

        public string EmailRecrutador { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey("Usuario")]
        public int Id_Usuario { get; set; }
    }
}
