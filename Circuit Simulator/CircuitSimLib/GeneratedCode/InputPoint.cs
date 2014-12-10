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
	public virtual Element ConnectsTo
	{
		get;
		set;
	}
    /// <summary>
    /// Checks if this InputPoint is clicked
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public override bool AreYouClicked()
    {
        return base.AreYouClicked();
    }
}

