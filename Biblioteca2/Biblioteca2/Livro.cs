using System;
using System.Collections.Generic;

public class Livro
{
    string titulo;
    string autor;
    int ano;

    public string Titulo { 
        get { return titulo; }
        set { titulo = value; }
    }

    public string Autor
    {
        get { return autor; }
        set { titulo = value; }
    }

    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }

    public Livro(string titulo, string autor, int ano)
    {
        this.titulo = titulo;
        this.autor = autor;
        this.ano = ano;
    }
}
