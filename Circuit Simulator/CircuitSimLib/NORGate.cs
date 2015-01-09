using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

/// <summary>
/// An NOR gate class to store the correct image and 
/// calculate the appropriate output
/// </summary>
public class NORGate : Gate
{
    /// <summary>
    /// Constructor
    /// </summary>
    public NORGate()
    {
        this.Input = new InputPoint[2];
        this.Input[0] = new InputPoint(-45, -9, 10, this);
        this.Input[1] = new InputPoint(-45, 8, 10, this);
        this.Output = new OutputPoint(44, 0, 20, this);

        this.Img[0] = CircuitSimLib.Properties.Resources.nor;
    }

    /// <summary>
    /// Calculates the output for an NOR gate
    /// </summary>
    /// <returns>Returns a calculated boolean</returns>
    public override bool CalculateOutput()
    {
        return !(Input[0].ConnectedElementsOutput() || Input[1].ConnectedElementsOutput());
    }
}

