using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
		throw new System.NotImplementedException();
	}

	public void DrawSinksAndConnections()
	{
		throw new System.NotImplementedException();
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
		throw new System.NotImplementedException();
	}

}

