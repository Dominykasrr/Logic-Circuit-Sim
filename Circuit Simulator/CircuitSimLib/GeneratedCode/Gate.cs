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

    }

    /// <summary>
    ///Calculates the output based on the inputs
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public bool CalculateOutput();

}

