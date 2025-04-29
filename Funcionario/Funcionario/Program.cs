FuncionarioTrabalhador func_1 = new FuncionarioTrabalhador("Isabela", 2000);
FuncionarioTrabalhador func_2 = new FuncionarioTrabalhador("Gabs", 150);

Empresa empresa = new Empresa();

empresa.AdicionarFuncionario(func_1);
empresa.AdicionarFuncionario(func_2);

empresa.ImprimirDados();

empresa.Trabalhar();