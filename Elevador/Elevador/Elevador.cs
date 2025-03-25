using System;
using System.Collections.Generic;

public class Elevador
{
    bool portaAberta;
    int andarAtual;

    double pesoMax;
    double pesoAtual;
    int numPessoaMax;
    int numPessoaAtual;

    int qtdAndares;

    public bool PortaAbeta
    {
        get { return portaAberta; }
        set { portaAberta = value; }
    }
    public int AndarAtual
    {
        get { return andarAtual; }
        set { andarAtual = value; }
    }
    public double PesoMax
    {
        get { return pesoMax; }
    }
    public double PesoAtual
    {
        get { return pesoAtual; }
        set { pesoAtual = value; }
    }

    public int NumPessoaMax
    {
        get { return numPessoaMax; }
        set { numPessoaMax = value; }
    }
    public int NumPessoaAtual
    {
        get { return numPessoaAtual; }
        set { numPessoaAtual = value; }
    }

    public int QtdAndares
    {
        get { return qtdAndares; }
        set { qtdAndares = value; }
    }

    public Elevador(int qtdAndares)
    {
        this.pesoMax = 500;
        this.numPessoaMax = 6;
        this.portaAberta = false;
        this.andarAtual = 0;
        this.pesoAtual = 0;
        this.numPessoaAtual = 0;
        this.qtdAndares = qtdAndares;
    }

    public void AbrirPorta()
    {
        PortaAbeta = true;
        Console.WriteLine("\nA porta do elevador abriu");
    }

    public void FecharPorta()
    {
        PortaAbeta = false;
        Console.WriteLine("\nA porta do elevador fechou");
    }

    public void Subir(int andar)
    {
        if (PesoAtual <= PesoMax && NumPessoaAtual <= NumPessoaMax)
        {
            if (PortaAbeta == true)
            {
                Console.WriteLine($"\nPorta aberta! Elevador não pode se mover");
            }
            else
            {
                while (andarAtual < andar)
                {
                    Console.WriteLine($"\nSubindo para o andar {andar}");
                    andarAtual += 1;
                    Console.WriteLine($"Andar atual: {andarAtual}");
                }
            } 
        }
        else
        {
            Console.WriteLine("Peso excedido! Elevador não pode se mover");
        }
    }

    public void Descer(int andar)
    {
        if (PesoAtual <= PesoMax && NumPessoaAtual <= NumPessoaMax)
        {
            if (PortaAbeta == true)
            {
                Console.WriteLine($"\nPorta aberta! Elevador não pode se mover");
            }
            else
            {
                while (andarAtual > andar)
                {
                    Console.WriteLine($"\nDescendo para o andar {andar}");
                    andarAtual -= 1;
                    Console.WriteLine($"Andar atual: {andarAtual}");
                }
            }
        }
        else
        {
            Console.WriteLine("Peso excedido! Elevador não pode se mover");
        }
    }
}