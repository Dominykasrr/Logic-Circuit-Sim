using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ConnectionPoint
{
    /// <summary>
    /// X coordinate of the ConnectionPoint
    /// </summary>
    /// 
    int x, y;
    public int X 
    {
        get
        {
            return this.x + Owner.X;
        }
        set
        {
            this.x = value;
        }
    }

    /// <summary>
    /// X coordinate of the ConnectionPoint
    /// </summary>
    public int Y { 
        get
        {
            return this.y + Owner.Y;
        }
        set
        {
            this.y = value;
        }

    }

    /// <summary>
    /// Radius of the ConnectionPoint
    /// </summary>
    private int Radius { get; set; }

    /// <summary>
    /// A pointer to the owner of the ConnectionPoint
    /// </summary>
    public Element Owner = null;

    /// <summary>
    /// Constructor
    /// </summary>
    public ConnectionPoint(int x, int y, int r)
    {
        this.X = x;
        this.Y = y;
        this.Radius = r;
    }

    /// <summary>
    /// Checks if this ConnectionPoint was clicked
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public virtual bool AreYouClicked(int x, int y)
    {
        double d = Math.Sqrt(Math.Pow(x - this.X, 2) + Math.Pow(y - this.Y, 2));

        return (d < this.Radius);
    }

}

