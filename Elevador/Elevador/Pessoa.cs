using System;
using System.Collections.Generic;

public class Pessoa
{
    double peso;

    public double Peso
    {
        get { return peso; }
        set { peso = value; }
    }

    public Pessoa(double peso)
    {
        this.peso = peso;
    }

    public void ChamarElevador(Elevador elevador, int andarChamado)
    {
        if (elevador.PortaAbeta == false)
        {
            Console.WriteLine("Elevador disponível");
            return;
        }

        if(andarChamado == elevador.AndarAtual)
        {
            Console.WriteLine("Elevador já está no andar chamado");
        }
        else
        {
            Console.WriteLine($"Movendo o elevador do andar {elevador.AndarAtual} para o andar {andarChamado}");
            elevador.AndarAtual = andarChamado;
        }

        elevador.AbrirPorta();
    }

    public void EntrarElevador(Elevador elevador)
    {
        if(elevador.PortaAbeta == true)
        {
            elevador.NumPessoaAtual++;
            elevador.PesoAtual += peso;
            Console.WriteLine("Uma pessoa entrou no elevador");
        }
    }

    public void SairElevador(Elevador elevador)
    {
        if (elevador.PortaAbeta == true)
        {
            elevador.NumPessoaAtual--;
            elevador.PesoAtual -= peso;
            Console.WriteLine("Uma pessoa saiu do elevador");
        }
    }
}
