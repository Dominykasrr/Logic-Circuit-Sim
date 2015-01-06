using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

[Serializable]
public class Circuit
{
	public List<Element> Elements { get; set; }
	public List<Sink> Sinks { get; set; }
    private Graphics gr;

    /// <summary>
    /// Constructor
    /// </summary>
    public Circuit(Graphics gr)
    {
        this.Elements = new List<Element>();
        this.Sinks = new List<Sink>();
        this.gr = gr;
    }

	public void DrawAll() 
    {
        for (int i = 0; i < this.Elements.Count; i++)
        {
            this.Elements[i].Draw(gr);
            this.Elements[i].DrawConnections();
        }

        for (int i = 0; i < this.Sinks.Count; i++)
        {
            this.Sinks[i].Draw(gr);
            this.Sinks[i].DrawConnections();
        }
    }

	public void DrawSinksAndConnections()
	{
        for (int i = 0; i < this.Sinks.Count; i++)
        {
            this.Sinks[i].Draw(gr);
            this.Sinks[i].DrawConnections();
        }

        for (int i = 0; i < this.Elements.Count; i++)
        {
            this.Elements[i].DrawConnections();
        }
	}

	public bool MoveElement(Element el, int x, int y)
	{
        for (int i = 0; i < this.Elements.Count; i++)
        {
            if (el == this.Elements[i])
            {
                this.Elements[i].X = x;
                this.Elements[i].Y = y;
                return true;
            }
        }
        return false;
	}

    public bool MoveElement(int iX, int iY, int nX, int nY)
    {
        Element temp = FindElement(iX, iY);
        if (temp != null)
        {
            if (FindElement(nX, nY) == null)
            {
                MoveElement(temp, nX, nY);
                return true;
            }
            else return false;
        }
        else return false;
    }

	public bool RemoveElement(int x, int y)
	{
        Element temp = FindElement(x, y);
        if (temp != null)
        {
            for (int i = 0; i < this.Elements.Count; i++)
            {
                if (temp == this.Elements[i])
                {
                    this.Elements.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
        else return false;
	}

	public bool AddElement(String type, int x, int y)
	{
        if(type == "AND")
        {
            AndGate temp = new AndGate();
            this.Elements.Add(temp);
            MoveElement(temp, x, y);
            return true;
        }
        else if (type == "OR")
        {
            OrGate temp = new OrGate();
            MoveElement(temp, x, y);
            this.Elements.Add(temp);
            return true;
        }
        else return false;
	}

	public Element FindElement(int x, int y)
	{
        for (int i = 0; i < this.Elements.Count; i++)
        {
            if (this.Elements[i].AreYouClicked(x, y)) return this.Elements[i];
        }
        return null;
	}

	public ConnectionPoint FindConnectionPoint(int x, int y)
	{
        for (int i = 0; i < this.Elements.Count; i++)
        {
            if (this.Elements[i].AreYouClicked(x, y))
            {
                if (this.Elements[i].GetType() == typeof(Gate))
                {
                    Gate g = (Gate)this.Elements[i];
                    if (g.Output.AreYouClicked(x, y)) return g.Output;
                    for (int j = 0; j < g.Input.Length; j++)
                    {
                        if (g.Input[j].AreYouClicked(x, y)) return g.Input[j];
                    }
                }
                else if (this.Elements[i].GetType() == typeof(Source))
                {
                    Source s = (Source)this.Elements[i];
                    if (s.Output.AreYouClicked(x, y)) return s.Output;
                }
                else if (this.Elements[i].GetType() == typeof(Sink))
                {
                    Sink s = (Sink)this.Elements[i];
                    if (s.Input.AreYouClicked(x, y)) return s.Input;
                }
                else return null;
            }
        }
        return null;
	}

    public bool MakeConnection(int aX, int aY, int bX, int bY)
    {
        ConnectionPoint A = FindConnectionPoint(aX, aY);
        ConnectionPoint B = FindConnectionPoint(bX, bY);
        if (MakeConnection(A, B)) return true;
        else return false;
    }

	public bool MakeConnection(ConnectionPoint A, ConnectionPoint B)
	{
        if (A.GetType() == typeof(InputPoint) && base.GetType() == typeof(InputPoint)) throw new Exception();
        else if (A.GetType() == typeof(OutputPoint) && base.GetType() == typeof(OutputPoint)) throw new Exception();
        else if (A.GetType() == typeof(OutputPoint))
        {
            OutputPoint temp1 = (OutputPoint)A;
            InputPoint temp2 = (InputPoint)B;

            temp1.ConnectsTo.Add(B);
            temp2.ConnectsTo = A;
            return true;
        }
        else if (A.GetType() == typeof(InputPoint))
        {
            InputPoint temp1 = (InputPoint)A;
            OutputPoint temp2 = (OutputPoint)B;

            temp1.ConnectsTo = B;
            temp2.ConnectsTo.Add(A);
            return true;
        }
        else throw new Exception();
    }

}

