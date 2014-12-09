using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class DynamicSource : Source
{
	public virtual int frequency { get; set; }

	public static Image IMG { get; set; }

	public virtual int value { get; set; }

}

