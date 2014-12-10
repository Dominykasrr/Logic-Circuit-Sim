using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class ConnectionPoint
{
    //X coordinate of the connection point
	public virtual int X { get; set; }

    //Y coordinate of the connection point
	public virtual int Y { get; set; }

    //Radius of the connection point
	public virtual int Radius { get; set; }

    //This method returns if a connection point was clicked
	public virtual bool AreYouClicked()
	{
		throw new System.NotImplementedException();
	}

}

