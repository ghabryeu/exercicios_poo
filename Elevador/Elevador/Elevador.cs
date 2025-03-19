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

    public Elevador()
    {
        this.pesoMax = 500;
        this.numPessoaMax = 6;
        this.portaAberta = false;
        this.andarAtual = 0;
        this.pesoAtual = 0;
        this.numPessoaAtual = 0;
    }

    public void AbrirPorta()
    {
        PortaAbeta = true;
        Console.WriteLine("A porta do elevador abriu");
    }

    public void FecharPorta()
    {
        PortaAbeta = false;
        Console.WriteLine("A porta do elevador fechou");
    }

    public void Subir(Predio predio)
    {
        if(PesoAtual <= PesoMax && NumPessoaAtual <= NumPessoaMax)
        {
            return;
        }

        if(PortaAbeta == false)
        {
            return;
        }

        for(int i = AndarAtual; i < predio.Andares.Length; i++)
        {

        }

    }

    public void Descer()
    {

    }
}