using System;
using System.Collections.Generic;

public class Predio
{
    int andares;
    Elevador elevador;

    public int Andares
    {
        get { return andares; }
        set { andares = value; }
    }

    public Predio()
    {
        this.andares = 8;
        this.elevador = new Elevador(andares);
    }
}
