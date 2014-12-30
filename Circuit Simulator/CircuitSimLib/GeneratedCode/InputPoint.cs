using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// An InputPoint class
/// </summary>
public class InputPoint : ConnectionPoint
{
    /// <summary>
    /// The element this point is connected to
    /// </summary>
    public Element ConnectsTo { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public InputPoint(int x, int y, int r)
        : base(x, y, r)
    {
        this.ConnectsTo = null;
    }

    /// <summary>
    /// Checks if this InputPoint is clicked
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public override bool AreYouClicked(int x, int y)
    {
        return base.AreYouClicked(x, y);
    }
}

