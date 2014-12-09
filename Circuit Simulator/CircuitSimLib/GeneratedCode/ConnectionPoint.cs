using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ConnectionPoint
{
	public virtual int X { get; set; }
	public virtual int Y { get; set; }
	public virtual int Radius { get; set; }

	public virtual bool AreYouClicked()
	{
		throw new System.NotImplementedException();
	}

}

