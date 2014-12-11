using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Source : Element
{
    //A boolean that states the current output of the source
	public virtual bool state { get; set; }
    
    //An OutputPoint that specifies the output for the source
	public virtual OutputPoint output { get; set; }
}

