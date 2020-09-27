using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjEmpresa.Models
{
    public class Empresa
    {
        [Key]
        public int idEmpresa { get; set; }
        public string cnpj { get; set; }
        public string nome { get; set; }
        [DataType(DataType.Date)]
        public DateTime dataAbertura { get; set; }
        public string atividade { get; set; }
    }
}