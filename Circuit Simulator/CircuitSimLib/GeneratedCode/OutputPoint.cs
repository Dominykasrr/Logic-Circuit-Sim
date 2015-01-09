using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// An output point class
/// </summary>
public class OutputPoint : ConnectionPoint
{
    /// <summary>
    /// A list of elements this OutputPoint is connected to
    /// </summary>

    /// <summary>
    /// Constructor
    /// </summary>
    public OutputPoint(int x, int y, int r, Element owner)
        : base(x, y, r)
    {
        this.Owner = owner;
    }

    /// <summary>
    /// Checks if this OutputPoint is clicked
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public override bool AreYouClicked(int x, int y)
    {
        return base.AreYouClicked(x, y);
    }
}

