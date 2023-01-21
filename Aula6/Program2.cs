//using System.ComponentModel.DataAnnotations;
//using System.Reflection;

//Console.WriteLine(ObtemValorDoDisplay(Escolaridade.Colegio));

//var aluno = new Aluno()
//{
//    Nome = "Davi",
//    Email = "davi@teste.com",
//    Idade = 25,
//    Escolaridade = Escolaridade.Colegio
//};

//var meuTipo = aluno.GetType();
//var meuTipo2 = typeof(Aluno);

//var propriedades = meuTipo.GetProperties();

//foreach (var propriedade in propriedades)
//{
//    Console.WriteLine($"{propriedade.Name} - {propriedade.GetValue(aluno)}");
//}

//Console.WriteLine();

////var metodos = meuTipo.GetMethods();

////foreach (var metodo in metodos)
////{
////    Console.WriteLine($"{metodo.Name} {metodo.ReturnType.Name}");

////    var parametros = metodo.GetParameters();

////    foreach (var parametro in parametros)
////    {
////        Console.WriteLine($"{parametro.Name}");
////    }
////    Console.WriteLine();
////}

////var propriedadeNome = meuTipo.GetProperty("Nome");
////var typePropriedadeNome = propriedadeNome.PropertyType;

////bool isString = typePropriedadeNome == typeof(string);

////propriedadeNome.SetValue(aluno, "Davi Nascimento");

////var propriedadeIdade = meuTipo.GetProperty("Idade");
////propriedadeIdade.SetValue(aluno, 10);


////var minhaInstancia = Activator.CreateInstance<Aluno>();
////var minhaInstanciaType = minhaInstancia.GetType();
////var propriedadeNomeJIT = minhaInstanciaType.GetProperty("Nome");
////propriedadeNomeJIT.SetValue(minhaInstancia, "Davi Runtime");
////var propriedadeEmailJIT = minhaInstanciaType.GetProperty("Email");
////propriedadeEmailJIT.SetValue(minhaInstancia, "davi@teste.com");

////var methodType = minhaInstanciaType.GetMethod("ListarInformacoes");
////methodType.Invoke(minhaInstancia, null);

//Console.ReadLine();

//string ObtemValorDoDisplay(Escolaridade enumObj)
//{
//    var enumType = enumObj.GetType().GetField(enumObj.ToString());
//    var displayAttributes = enumType.GetCustomAttributes(typeof(DisplayAttribute), true) as DisplayAttribute[];

//    if(displayAttributes != null && displayAttributes.Length > 0)
//    {
//        return displayAttributes[0].Name;
//    }

//    return enumObj.ToString();
//}

//enum Escolaridade
//{
//    [Display(Name = "Colégio")]
//    Colegio,
//    Faculdade,
//    [Display(Name = "Pós graduação")]
//    PosGraduacao
//}

//class Aluno
//{
//    private string id = "";

//    public string Nome { get; set; }
//    public string Email { get; set; }
//    public int Idade { get; set; }
//    public Escolaridade Escolaridade { get; set; }

//    private void _ListarInformacoes()
//    {
//        Console.WriteLine($"{Nome} - {Email} - {Idade}");
//    }

//    public void ListarInformacoes()
//    {
//        _ListarInformacoes();
//    }
//}