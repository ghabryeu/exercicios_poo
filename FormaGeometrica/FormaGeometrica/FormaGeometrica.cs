using System;
using System.Collections.Generic;

public class FormaGeometrica
{
    int area_;
    int base_;
    int altura_;

    public int Area_
    {
        get { return area_; }
        set { area_ = value; }
    }

    public int Base_ 
    { 
        get { return base_; } 
        set { base_ = value; }
    }

    public int Altura_ 
    {
        get { return altura_; }
        set { altura_ = value; }
    }

    public FormaGeometrica(int base_, int altura_)
    {
        this.base_ = base_;
        this.altura_ = altura_;
        this.area_ = 0;
    }
}
