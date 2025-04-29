public abstract class Funcionario
{
    string nome;
    double salario;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public double Salario
    {
        get { return salario; }
        set { salario = value; }
    }

    public Funcionario(string nome, double salario)
    {
        this.nome = nome;
        this.salario = salario;
    }

    public abstract void ReceberAumento();

}