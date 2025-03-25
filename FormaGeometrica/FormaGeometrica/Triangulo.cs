using System;
using System.Collections.Generic;

public class Triangulo : FormaGeometrica
{
    // A = (b x h) / 2

    public Triangulo(int base_, int altura_) : base(base_, altura_)
    {

    }

    public void CalcularArea()
    {
        Area_ = (Base_ * Altura_) / 2;
        Console.WriteLine($"A área do triângulo é: {Area_}");
    }
}
