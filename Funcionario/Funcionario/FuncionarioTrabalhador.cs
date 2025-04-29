public class FuncionarioTrabalhador : Funcionario
{

    public FuncionarioTrabalhador(string nome, double salario) : base(nome, salario)
    {
    }

    public override void ReceberAumento()
    {
        double perSalario = Salario * 0.1;
        Salario += perSalario;
    }

    public virtual void ExecutarTarefa()
    {
        Console.WriteLine("Estou...");
    }
}