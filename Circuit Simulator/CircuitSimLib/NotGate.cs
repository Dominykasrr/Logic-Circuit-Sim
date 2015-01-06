using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

/// <summary>
/// An NOT gate class to store the correct image and 
/// calculate the appropriate output
/// </summary>
public class NotGate : Gate
{
    /// <summary>
    /// Constructor
    /// </summary>
    public NotGate()
    {
        this.Input = new InputPoint[1];
        this.Input[0] = new InputPoint(this.X, this.Y, 10, this);
        

        this.Output = new OutputPoint(this.X, this.Y, 10, this);

        this.Img[0] = CircuitSimLib.Properties.Resources.inverter;
    }

    /// <summary>
    /// Calculates the output for an NOT gate
    /// </summary>
    /// <returns>Returns a calculated boolean</returns>
    public override bool CalculateOutput()
    {
        return !(Input[0].ConnectedElementsOutput());
    }
}

