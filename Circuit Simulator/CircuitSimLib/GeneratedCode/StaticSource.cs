using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class StaticSource : Source
{
    /// <summary>
    ///Image array for the two states of the StaticSource
    /// </summary>
	public Image[] Img { get; set; }

    /// <summary>
    ///Constructor
    /// </summary>
    public StaticSource()
        : base()
    {
        Img[0] = CircuitSimLib.Properties.Resources.source;
        Img[1] = CircuitSimLib.Properties.Resources.source_on;
    } 

}

