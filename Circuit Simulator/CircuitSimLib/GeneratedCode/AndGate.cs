using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

/// <summary>
/// An AND gate class to store the correct image and 
/// calculate the appropriate output
/// </summary>
public class AndGate : Gate
{
	/// <summary>
	/// The image of the AND gate
	/// </summary>
    public Image Img { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public AndGate()
    {
        this.Input = new InputPoint[2];
        this.Input[0] = new InputPoint(this.X, this.Y, 10);
        this.Input[1] = new InputPoint(this.X, this.Y, 10);

        this.Output = new OutputPoint(this.X, this.Y, 10);

        this.Img = CircuitSimLib.Properties.Resources.and;
    }

    /// <summary>
    /// Calculates the output for an AND gate
    /// </summary>
    /// <returns>Returns a calculated int</returns>
    public override bool CalculateOutput()
    {
        return base.CalculateOutput();
    }
}

