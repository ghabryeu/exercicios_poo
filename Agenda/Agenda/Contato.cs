using System;
using System.Collections.Generic;

public class Contato
{
    string nome;
    string email;
    string telefone;

    public string Nome 
    { get { return nome; } 
      set { nome = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string Telefone
    {
        get { return telefone; }
        set { telefone = value; }
    }

    public Contato(string nome, string email, string telefone)
    {
        this.nome = nome;
        this.email = email;
        this.telefone = telefone;
    }
}
