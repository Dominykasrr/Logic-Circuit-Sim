using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// An AND gate class to store the correct image and 
/// calculate the appropriate output
/// </summary>
public class AndGate : Gate
{
	/// <summary>
	/// The image of the AND gate
	/// </summary>
    public static Image IMG
	{
		get;
		set;
	}
    /// <summary>
    /// Calculates the output for an AND gate
    /// </summary>
    /// <returns>Returns a calculated int</returns>
    public override int calculateOutput()
    {
        //to satisfy the compiler
        return 0;
    }
}

