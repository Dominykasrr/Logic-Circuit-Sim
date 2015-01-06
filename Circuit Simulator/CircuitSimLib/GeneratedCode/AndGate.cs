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
    /// Constructor
    /// </summary>
    public AndGate()
    {
        this.Input = new InputPoint[2];
        this.Input[0] = new InputPoint(this.X, this.Y, 10, this);
        this.Input[1] = new InputPoint(this.X, this.Y, 10, this);

        this.Output = new OutputPoint(this.X, this.Y, 10, this);

        this.Img[0] = CircuitSimLib.Properties.Resources.and;
    }

    /// <summary>
    /// Calculates the output for an AND gate
    /// </summary>
    /// <returns>Returns a calculated int</returns>
    public override bool CalculateOutput()
    {
        return Input[0].ConnectedElementsOutput() && Input[1].ConnectedElementsOutput();
    }
    public override void Draw(Graphics gr)
    {
        gr.DrawImage(Img[0], new Rectangle(this.X - Img[0].Width / 2, this.Y - Img[0].Height/2-19, Img[0].Width, Img[0].Height));
    }
}

