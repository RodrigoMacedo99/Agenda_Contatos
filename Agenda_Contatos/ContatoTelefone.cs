using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Contatos
{
    public class ContatoTelefone : Contato, IContatoTelefone
    {
        public string DDD { get; set; }
        public string Numero { get; set; }

        public override string GetTipo()
        {
            return "Telefone";
        }
    }

}
