public class Programador : FuncionarioTrabalhador
{
    public Programador(string nome, double salario) : base(nome, salario)
    {
    }

    public override void ExecutarTarefa()
    {
        Console.WriteLine("...programando");
    }
}