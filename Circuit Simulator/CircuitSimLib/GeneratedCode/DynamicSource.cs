using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class DynamicSource : Source
{
    /// <summary>
    ///Frequency of the DynamicSource
    /// </summary>
	public int Frequency { get; set; }

    /// <summary>
    ///Image for the DynamicSource
    /// </summary>
	public Image Img { get; set; }

    /// <summary>
    ///Constructor
    /// </summary>
    public DynamicSource()
        : base()
    {
        this.Img = CircuitSimLib.Properties.Resources.clock;
        this.Frequency = 0;
    }

}

