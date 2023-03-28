using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Contatos
{
    public abstract class Contato
    {
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }

        public abstract string GetTipo();
    }
}

