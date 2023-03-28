using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Contatos
{
    public class ContatoEmail : Contato, IContatoEmail
    {
        public string Email { get; set; }

        public override string GetTipo()
        {
            return "Email";
        }
    }
}
