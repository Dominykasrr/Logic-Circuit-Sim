using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Element
{
	public int ElementID { get; set; }
    private static int ElementCount = 0;

	public int X { get; set; }

	public int Y { get; set; }

    public Element()
    {
        this.X = 0;
        this.Y = 0;

        this.ElementID = ElementCount;
        ElementCount++;
    }

	public void Draw()
	{
		throw new System.NotImplementedException();
	}

	public void DrawConnections()
	{
		throw new System.NotImplementedException();
	}

	public bool AreYouClicked()
	{
		throw new System.NotImplementedException();
	}

}

