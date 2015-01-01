using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Circuit
{
	public static List<Element> elements { get; set; }

	public virtual List<Sink> sinks { get; set; }

	public virtual Element Element { get; set; }

	public virtual Sink Sink { get; set; }

	public virtual void DrawAll() 
    {
		throw new System.NotImplementedException();
	}

	public virtual void DrawSinksAndConnections()
	{
		throw new System.NotImplementedException();
	}

	public virtual bool MoveElement(Element el, int X, int Y)
	{
		throw new System.NotImplementedException();
	}

	public virtual void RemoveElement(Element el)
	{
		throw new System.NotImplementedException();
	}

	public virtual void AddElement(Element type)
	{
		throw new System.NotImplementedException();
	}

	public virtual Element FindElement(int X, int Y)
	{
		throw new System.NotImplementedException();
	}

	public virtual void FindConnectionPoint(int X, int Y)
	{
		throw new System.NotImplementedException();
	}

	public virtual void MakeConnection(ConnectionPoint A, ConnectionPoint B)
	{
		throw new System.NotImplementedException();
	}

}

