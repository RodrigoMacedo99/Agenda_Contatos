// See https://aka.ms/new-console-template for more information
using Agenda_Contatos;

//criação dos objetos
ContatoEmail contatoEmail = new ContatoEmail();
ContatoTelefone contatoTelefone = new ContatoTelefone();
Agenda agenda = new Agenda();

//add email
contatoEmail.Nome = "Hilton Vicente César";
contatoEmail.Email = "Hilton@gmail.com";
contatoEmail.Categoria = Categoria.Faculdade;

//add telefone
contatoTelefone.Nome = "laranginha";
contatoTelefone.DDD = "71";
contatoTelefone.Numero = "998852456";
contatoTelefone.Categoria = Categoria.Trabalho;

//add agenda
agenda.AdicionarContato(contatoEmail);
agenda.AdicionarContato(contatoTelefone);

//alocando em uma lista os valores
List<Contato> contatos = agenda.ListarContatos();

foreach (Contato contato in contatos)
{
    Console.WriteLine("===================================================================");
    Console.WriteLine($"Nome: {contato.Nome} - Categoria: {contato.Categoria} - Tipo: {contato.GetTipo()}");

    if (contato is IContatoEmail)
    {
        IContatoEmail ContatoEmail = contato as IContatoEmail;
        Console.WriteLine($"Email: {contatoEmail.Email}");
        Console.WriteLine("===================================================================");
    }
    else if (contato is IContatoTelefone)
    {
        IContatoTelefone ContatoTelefone = contato as IContatoTelefone;
        Console.WriteLine($"Telefone: ({contatoTelefone.DDD}) {contatoTelefone.Numero}");
        Console.WriteLine("===================================================================");
    }
}
