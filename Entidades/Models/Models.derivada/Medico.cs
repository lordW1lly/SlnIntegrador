using Entidades.Models.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Models.derivada
{
    public class Medico : Persona
    {
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
        public Medico()
        {

        }
    }
}
