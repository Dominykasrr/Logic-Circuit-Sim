using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ConnectionPoint
{
    /// <summary>
    /// X coordinate of the ConnectionPoint
    /// </summary>
    private int X { get; set; }

    /// <summary>
    /// X coordinate of the ConnectionPoint
    /// </summary>
    private int Y { get; set; }

    /// <summary>
    /// Radius of the ConnectionPoint
    /// </summary>
    private int Radius { get; set; }

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
    public bool AreYouClicked(int x, int y)
    {
        double d = Math.Sqrt(Math.Pow(x - this.X, 2) + Math.Pow(y - this.Y, 2));

        if (d > this.Radius) return false;
        else return true;
    }

}

