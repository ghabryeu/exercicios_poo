using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Empresa
{
    public string Nome { get; set; }
    public List<Funcionario> funcionarios { get; set; } = new List<Funcionario>();

    public double desconto;
    public double Desconto
    {
        get { return desconto; }
        set
        {
            if (value > 5000)
                desconto = 0.275;
            else if (value > 4000)
                desconto = 0.225;
            else if (value > 3000)
                desconto = 0.15;
            else if (value > 2000)
                desconto = 0.075;
            else
                desconto = 0;
        }
    }

    public void AdicionarFuncionario(Funcionario funcionario)
    {
        Desconto = funcionario.Salario;
        funcionarios.Add(funcionario);
    }

    public void GerarRelatorio()
    {
        double totalBruto = 0;
        double totalDescontado = 0;
        double totalLiquido = 0;

        Console.WriteLine($"Relatório de Pagamentos - {Nome}\n");
        Console.WriteLine("Nome\tCPF\tSalário Bruto\tDesconto\tSalário Líquido");

        foreach (var f in funcionarios)
        {
            Desconto = f.Salario;
            double descontoValor = f.Salario * Desconto;
            double liquido = f.Salario - descontoValor;
            totalBruto += f.Salario;
            totalDescontado += descontoValor;
            totalLiquido += liquido;

            Console.WriteLine($"{f.Nome}\t{f.Cpf}\t{f.Salario:C}\t{descontoValor:C}\t{liquido:C}");
        }

        Console.WriteLine("\nResumo Geral:");
        Console.WriteLine($"Total Bruto: {totalBruto:C}");
        Console.WriteLine($"Total Descontado: {totalDescontado:C}");
        Console.WriteLine($"Total Líquido: {totalLiquido:C}");
    }
}
