using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Gate : Element
{
    /// <summary>
    ///Inputs of the Gate
    /// </summary>
	public InputPoint[] Input { get; set; }

    /// <summary>
    ///Output of the Gate
    /// </summary>
	public OutputPoint Output { get; set; }

    /// <summary>
    ///Constructor
    /// </summary>
    public Gate()
    {
        this.Input = new InputPoint[2];
        this.Input[0] = new InputPoint(this.X, this.Y, 10);
        this.Input[1] = new InputPoint(this.X, this.Y, 10);
        this.Output = new OutputPoint(this.X, this.Y, 10);
    }

    /// <summary>
    ///Calculates the output based on the inputs
    /// </summary>
    /// <returns>Returns a boolean</returns>
	public bool CalculateOutput()
	{
		throw new System.NotImplementedException();
	}

}

