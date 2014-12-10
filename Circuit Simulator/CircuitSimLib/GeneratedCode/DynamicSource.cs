using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class DynamicSource : Source
{
    //The frequency of the dynamic source
	public virtual int frequency { get; set; }

    //The image of the dynamic source
	public static Image IMG { get; set; }

    //The output of the dynamic source
	public virtual int value { get; set; }

}

