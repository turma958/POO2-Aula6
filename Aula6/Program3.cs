//// Resto do código
//using System.Diagnostics;
//using System.Reflection;

//Stopwatch watch = new Stopwatch();

//Aluno aluno3;
//for (int i = 0; i < 500000; i++)
//{
//    aluno3 = new Aluno
//    {
//        Nome = "Davi"
//    };
//    aluno3.DescreverAluno();
//}
//watch.Stop();
//long tempoSemReflexaoEmMilisegundos = watch.ElapsedMilliseconds;

//watch.Reset();
//watch.Start();

//for (int i = 0; i < 500000; i++)
//{
//    var novoAluno = Activator.CreateInstance<Aluno>();
//    var propertyInfos = novoAluno.GetType().GetProperties();
//    foreach (PropertyInfo propertyInfo in propertyInfos)
//    {
//        if (propertyInfo.Name == "Nome")
//        {
//            propertyInfo.SetValue(novoAluno, "Davi");
//        }
//    }

//    var metodo = novoAluno.GetType().GetMethod("DescreverAluno");
//    metodo.Invoke(novoAluno, null);
//}
//watch.Stop();
//long tempoComReflexaoEmMilisegundos = watch.ElapsedMilliseconds;

//Console.WriteLine($"Tempo de execução para criar e instanciar 500.000 de vezes o aluno e chamar o método DescreverAlunoSemImpressao");
//Console.WriteLine($"  Sem reflexão: {tempoSemReflexaoEmMilisegundos} ms");
//Console.WriteLine($"  Com reflexão: {tempoComReflexaoEmMilisegundos} ms");

//class Aluno
//{
//    public string Nome { get; set; }

//    public string DescreverAluno()
//    {
//        return Nome;
//    }
//}