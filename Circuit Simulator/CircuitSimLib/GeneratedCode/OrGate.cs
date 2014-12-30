using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

/// <summary>
/// An OR gate class to store the correct image and 
/// calculate the appropriate output
/// </summary>
public class OrGate : Gate
{
    /// <summary>
    /// The image of the OR gate
    /// </summary>
	public static Image IMG { get; set; }

    /// <summary>
    /// Calculates the output for an OR gate
    /// </summary>
    /// <returns>Returns a calculated boolean</returns>
    public override bool CalculateOutput()
    {
        return base.CalculateOutput();
    }
}

