using System;
using System.Collections.Generic;

public class Pessoa
{
    string nome;
    string cpf;
    int livroAlugado;

    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public string Cpf
    {
        get { return cpf; }
        set { cpf = value; }
    }

    public int LivroAlugado
    {
        get { return livroAlugado; }
        set { livroAlugado = value; }
    }

    public Pessoa(string nome, string cpf)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.livroAlugado = 0;
    }
}

