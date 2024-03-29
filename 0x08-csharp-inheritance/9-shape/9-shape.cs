﻿using System;

///<summary> class Shape</summary>
class Shape
{
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

class Rectangle : Shape
{
    private int width;

    private int height;

    ///<summary> public property width</summary>
    public int Width
    {
        get
        {
            return width;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            width = value;
        }
    }

    /// <summary> public property height </summary>
    public int Height
    {
        get
        {
            return height;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            height = value;
        }
    }

    ///<summary> public override </summary>
    public override int Area()
    {
        return height * width;
    }

    ///<summary> public property </summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}

class Square : Rectangle
{
    private int size;

    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }
            size = value;
            Width = size;
            Height = size;
        }
    }
    ///<summary> public property </summary>
    public override string ToString()
    {
        return string.Format("[Square] {0} / {1}", size, size);
    }
}
