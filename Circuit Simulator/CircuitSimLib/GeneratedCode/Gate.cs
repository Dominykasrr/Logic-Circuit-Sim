using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// A class that gates should inherit from
/// </summary>
public class Gate : Element
{
	/// <summary>
	/// An array of the InputPoints of the gate
	/// </summary>
    public virtual InputPoint[] input; //no getter and setter needed was badly declared
    //also cannot specify how big is the array without creating it!
	
    
	//removed the output point named output because we have OutputPoint named OutputPoint and we need only 1

	//the simple input point was removed due to us having the array
    
    /// <summary>
    /// The output point of the gate
    /// </summary>
	public virtual OutputPoint OutputPoint
	{
		get;
		set;
	}
    /// <summary>
    /// Calculates the output of the gate
    /// </summary>
    /// <returns>Returns an integer</returns>
	public virtual int calculateOutput()
	{
		throw new System.NotImplementedException();
	}

}

