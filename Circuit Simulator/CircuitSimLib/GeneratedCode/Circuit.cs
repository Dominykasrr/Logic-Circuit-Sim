using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[Serializable]
public class Circuit
{
	public List<Element> Elements { get; set; }

	public List<Sink> Sinks { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Circuit()
    {
        this.Elements = new List<Element>();
        this.Sinks = new List<Sink>();
    }

	public void DrawAll() 
    {
        for (int i = 0; i < this.Elements.Count; i++)
        {
            this.Elements[i].Draw();
            this.Elements[i].DrawConnections();
        }

        for (int i = 0; i < this.Sinks.Count; i++)
        {
            this.Sinks[i].Draw();
            this.Sinks[i].DrawConnections();
        }
    }

	public void DrawSinksAndConnections()
	{
        for (int i = 0; i < this.Sinks.Count; i++)
        {
            this.Sinks[i].Draw();
            this.Sinks[i].DrawConnections();
        }

        for (int i = 0; i < this.Elements.Count; i++)
        {
            this.Elements[i].DrawConnections();
        }
	}

	public bool MoveElement(Element el, int X, int Y)
	{
		throw new System.NotImplementedException();
	}

	public void RemoveElement(Element el)
	{
		throw new System.NotImplementedException();
	}

	public void AddElement(Element type)
	{
		throw new System.NotImplementedException();
	}

	public Element FindElement(int X, int Y)
	{
		throw new System.NotImplementedException();
	}

	public void FindConnectionPoint(int X, int Y)
	{
		throw new System.NotImplementedException();
	}

	public void MakeConnection(ConnectionPoint A, ConnectionPoint B)
	{
        if (A.GetType() == typeof(InputPoint) && base.GetType() == typeof(InputPoint)) throw new Exception();
        else if (A.GetType() == typeof(OutputPoint) && base.GetType() == typeof(OutputPoint)) throw new Exception();
        else if(A.GetType() == typeof(OutputPoint))
        {
            OutputPoint temp1 = (OutputPoint)A;
            InputPoint temp2 = (InputPoint)B;

            temp1.ConnectsTo.Add(B);
            temp2.ConnectsTo = A;
        }
        else if (A.GetType() == typeof(InputPoint))
        {
            InputPoint temp1 = (InputPoint)A;
            OutputPoint temp2 = (OutputPoint)B;

            temp1.ConnectsTo = B;
            temp2.ConnectsTo.Add(A);
        }
    }

}

