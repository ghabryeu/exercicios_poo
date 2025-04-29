public class Empresa
{
    public List<Funcionario> Funcionarios {  get; set; } = new List<Funcionario>();

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Funcionarios.Add(funcionario);
    }

    public void ImprimirDados()
    {
        Console.WriteLine("Nome\tSalario");
        foreach (Funcionario func in Funcionarios)
        {
            Console.WriteLine($"{func.Nome}\t{func.Salario}");
        }
    }

    public void Trabalhar()
    {
        Funcionario funcTrab_1 = new FuncionarioTrabalhador("Isabela", 2000);
        FuncionarioTrabalhador func_1 = (FuncionarioTrabalhador)funcTrab_1;

        foreach (FuncionarioTrabalhador func in Funcionarios)
        {

            func.ExecutarTarefa();
        }

    }
}