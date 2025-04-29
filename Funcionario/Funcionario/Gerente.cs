public class Gerente : Funcionario
{
    public Gerente(string nome, double salario) : base(nome, salario)
    {
    }

    public override void ReceberAumento()
    {
        double perSalario = Salario * 0.2;
        Salario += perSalario;
    }
}