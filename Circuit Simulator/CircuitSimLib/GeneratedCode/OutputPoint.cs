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
	public virtual List<Element> ConnectsTo
	{
		get;
		set;
	}
    /// <summary>
    /// Checks if this OutputPoint is clicked
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public override bool AreYouClicked()
    {
        return base.AreYouClicked();
    }
}

