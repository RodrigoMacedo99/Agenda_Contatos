using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Contatos
{
    public class Agenda
    {
        private List<Contato> contatos;

        public Agenda()
        {
            contatos = new List<Contato>();
        }

        public void AdicionarContato(Contato contato)
        {
            contatos.Add(contato);
        }

        public void RemoverContato(Contato contato)
        {
            contatos.Remove(contato);
        }

        public void AlterarContato(Contato contatoAntigo, Contato contatoNovo)
        {
            int index = contatos.IndexOf(contatoAntigo);
            contatos[index] = contatoNovo;
        }

        public List<Contato> ListarContatos()
        {
            return contatos;
        }
    }

}
