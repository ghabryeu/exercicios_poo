using System;
using System.Collections.Generic;

public class Predio
{
    int[] andares = new int[8];

    public int[] Andares
    {
        get { return andares; }
        set { andares = value; }
    }

    public Predio(int[] andares)
    {
        this.andares = andares;
    }
}
