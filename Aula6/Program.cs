//var pessoa = new Pessoa { Nome = "Davi" };
//pessoa.Nome = "Davi";

//var pessoaType = pessoa.GetType();
//pessoaType.GetProperty("Nome").SetValue(pessoa, "Davi reflection");

var pessoa = Activator.CreateInstance<Pessoa>();

Console.ReadLine();

class Pessoa
{
    public required string Nome { get; set; }
}