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
    /// Constructor
    /// </summary>
    public OrGate()
    {
        this.Input = new InputPoint[2];
        this.Input[0] = new InputPoint(this.X, this.Y, 10);
        this.Input[1] = new InputPoint(this.X, this.Y, 10);

        this.Output = new OutputPoint(this.X, this.Y, 10);

        this.Img = CircuitSimLib.Properties.Resources.or;
    }

    /// <summary>
    /// Calculates the output for an OR gate
    /// </summary>
    /// <returns>Returns a calculated boolean</returns>
    public override bool CalculateOutput()
    {
        return base.CalculateOutput();
    }
}

