using System;
using System.Collections.Generic;

public class Agenda
{
    List<Contato> contatos = new List<Contato>();

    public List<Contato> Contatos
    {
        get { return contatos; }
        set { contatos = value; }
    }

    public void AdicionarContato(Contato contato)
    {
        contatos.Add(contato);
    }

    public void RemoverContato(Contato contato)
    {
        contatos.Remove(contato);
    }

    // nome ou email == telefone
    public void BuscarContato(string retorno)
    {
        bool encontrado = false;

        Console.WriteLine($"\nTelefone: ");

        foreach(var contato in contatos)
        {
            if (contato.Nome == retorno || contato.Email == retorno)
            {
                Console.WriteLine(contato.Telefone);
                encontrado = true;
                break;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Telefone não encontrado");
        }
    }

    public void ImprimirDados()
    {
        Console.WriteLine($"\nNome\tEmail\t        Telefone");
        for (int i = 0; i < contatos.Count; i++)
        {
            Console.WriteLine($"{contatos[i].Nome}\t{contatos[i].Email}\t{contatos[i].Telefone}");
        }
    }
}