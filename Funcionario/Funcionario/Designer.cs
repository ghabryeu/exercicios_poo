public class Designer : FuncionarioTrabalhador
{
    public Designer(string nome, double salario) : base(nome, salario)
    {
    }

    public override void ExecutarTarefa()
    {
        Console.WriteLine("...criando arte");
    }
}