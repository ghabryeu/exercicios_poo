using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Disciplina
{
    public string Nome { get; set; }
    public int MediaCurso { get; set; }
    List<Aluno> Alunos { get; set; } = new List<Aluno>();
    Dictionary<Aluno, List<int>> Notas { get; set; } = new Dictionary<Aluno, List<int>>();

    public void AdicionarAluno(Aluno aluno)
    {
        Alunos.Add(aluno);
        Notas[aluno] = new List<int>();
    }

    public void AdicionarNota(Aluno aluno, int nota)
    {
        Notas[aluno].Add(nota);
    }

    public int CalcularMedia(Aluno aluno)
    {
        int soma = Notas[aluno].Sum();
        return soma / Notas[aluno].Count;
    }

    public bool AprovarReprovar(Aluno aluno)
    {
        if(CalcularMedia(aluno) < MediaCurso)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void ImprimirDados()
    {
        Console.WriteLine("Nome\tDisciplina\tMédia final\tAprovado");

        foreach(var aluno in Alunos)
        {
            Console.WriteLine($"{aluno.Nome}\t{Nome}\t{CalcularMedia(aluno)}\t{AprovarReprovar(aluno)}");
        }

    }
}
