using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProjeto.Domain.Entities
{
    public class Curso 
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}
