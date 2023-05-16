using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Dominio.Dominio
{
    [Table("tb_Candidato")]
    public class Candidato
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCandidato { get; set; }

        public string NomeCndidato { get; set; }

        public string EmailCandidato { get; set; }

        public string Sexo { get; set; }

        public string Telfone { get; set; }

        public Usuario Usuario { get; set; }

        [ForeignKey("Usuario")]
        public int Id_Usuario { get; set; }
    }
}
