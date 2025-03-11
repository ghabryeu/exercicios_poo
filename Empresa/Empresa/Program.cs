Empresa empresa = new Empresa();
Funcionario funcionario = new Funcionario();
Funcionario funcionario2 = new Funcionario();

funcionario.Nome = "gabs";
funcionario.Salario = 2300;
funcionario2.Nome = "roger";
funcionario2.Salario = 4500;

empresa.AdicionarFuncionario(funcionario);
empresa.AdicionarFuncionario(funcionario2);

empresa.GerarRelatorio();


//Console.WriteLine("\n");
//// nomes e salário
//foreach (var f in empresa.SalarioFuncionario)
//{
//    Funcionario func = f.Key;
//    double salario = f.Value;

//    Console.WriteLine($"Nome: {func.Nome}\nSalário: " + salario);
//}
