using System;
using System.Collections.Generic;

public class Biblioteca
{
    List<Livro> livros = new List<Livro>();
    int qtdLivro = 0;

    public List<Livro> Livros
    {
        get { return livros; }
        set { livros = value; }
    }
    public int QtdLivro
    {
        get { return qtdLivro; }
        set { qtdLivro = value; }
    }

    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
        qtdLivro++;
    }

    public void RemoverLivro(Livro livro)
    {
        livros.Remove(livro);
        qtdLivro--;
    }

    public bool AlugarLivro(Pessoa pessoa, Livro livro, Biblioteca biblio)
    {
        if (!biblio.Livros.Contains(livro))
        {
            Console.WriteLine("Livro não encontrado");
            return false;
        }

        if(pessoa.LivroAlugado != 0)
        {
            Console.WriteLine("Apenas um livro por vez");
            return false;
        }

        if(biblio.QtdLivro <= 0)
        {
            Console.WriteLine("Sem livros para alugar");
            return false;
        }

        biblio.QtdLivro--;
        pessoa.LivroAlugado++;
        Console.WriteLine($"Livro alugado por:\nNome: {pessoa.Nome}\nCPF: {pessoa.Cpf}\nLivro Alugado: {livro.Titulo}");

        return true;
    }

    public void ImprimirDados(Pessoa pessoa)
    {
        Console.WriteLine("Título\tAutor\tAno");
        foreach(var livro in livros)
        {
            Console.WriteLine($"{livro.Titulo}\t{livro.Autor}\t{livro.Ano}");
        }
    }
}
