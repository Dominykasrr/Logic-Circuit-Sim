using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class StaticSource : Source
{
    //Image array for the 2 states of the source
	public static Image[] IMG { get; set; }

    //The source's output
	public virtual int value { get; set; }

}

