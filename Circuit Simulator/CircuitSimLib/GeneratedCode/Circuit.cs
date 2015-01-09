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
        foreach (Element ele in this.Elements)
        {
            ele.Draw(gr);
        }
    }

    public void DrawSinksAndConnections()
    {
        for (int i = 0; i < this.Sinks.Count; i++)
        {
            this.Sinks[i].Draw(gr);
            this.Sinks[i].DrawConnections(gr);
        }

        for (int i = 0; i < this.Elements.Count; i++)
        {
            this.Elements[i].DrawConnections(gr);
        }
    }

    public bool MoveElement(Element el, int x, int y)
    {
        if (FindElement(x, y) == null)
        {
            el.X = x;
            el.Y = y;
            return true;
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
        Element temp = FindElement(x, y); // why do you go through the lists twice?
        if (temp != null)
        {
            if (temp.GetType() != typeof(Sink))
            {
                foreach (Element e in Elements)
                {
                    if (e.GetType().BaseType == typeof(Gate))
                    {
                        Gate gt = (Gate)e;
                        foreach (InputPoint ip in gt.Input)
                        {
                            if (ip.ConnectsTo != null)
                            {
                                if (ip.ConnectsTo.Owner == temp)
                                {
                                    ip.ConnectsTo = null;
                                }
                            }
                        }
                    }
                    if(e.GetType() == typeof(Sink))
                    {
                        Sink snk = (Sink)e;
                        if (snk.Input.ConnectsTo != null)
                        {
                            if (snk.Input.ConnectsTo.Owner == temp)
                            {
                                snk.Input.ConnectsTo = null;
                            }
                        }
                    }
                }
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
            else // its a sink
            {
                for (int i = 0; i < this.Elements.Count; i++)
                {
                    if (temp == this.Elements[i])
                    {
                        this.Elements.RemoveAt(i);
                    }
                }
                for (int i = 0; i < this.Sinks.Count; i++)
                {
                    if (temp == this.Sinks[i])
                    {
                        this.Sinks.RemoveAt(i);
                    }
                }
                return true;
            }
        }
        else return false;
    }

    public bool AddElement(String type, int x, int y)
    {
        Element temp = null;
        switch (type)
        {
            case "AND":
                temp = new AndGate();
                break;
            case "OR":
                temp = new OrGate();
                break;
            case "NOT":
                temp = new NotGate();
                break;
            case "STSOURCE":
                temp = new StaticSource();
                break;
            case "DYSOURCE":
                temp = new DynamicSource();
                break;
            case "XOR":
                temp = new AndGate();
                break;
            case "NAND":
                temp = new AndGate();
                break;
            case "SINK":
                temp = new Sink();
                break;
            default:
                return false;
        }
        if (MoveElement(temp, x, y))
        {
            if (temp.GetType() == typeof(Sink)) this.Sinks.Add((Sink)temp);
            this.Elements.Add(temp);
            return true;
        }
        return false;
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
                if (this.Elements[i].GetType().BaseType == typeof(Gate))
                {
                    Gate g = (Gate)this.Elements[i];

                    if (g.Output.AreYouClicked(x, y))
                    {
                        return g.Output;
                    }

                    for (int j = 0; j < g.Input.Length; j++)
                    {
                        if (g.Input[j].AreYouClicked(x, y))
                        {
                            return g.Input[j];
                        }
                    }
                }
                else if (this.Elements[i].GetType().BaseType == typeof(Source))
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
        if (A != null && B != null)
        {
            if (MakeConnection(A, B)) return true;
            else return false;
        }
        return false;
    }

    public bool MakeConnection(ConnectionPoint A, ConnectionPoint B)
    {
        if (A.GetType() == B.GetType()) return false;
        else if (A.GetType() == typeof(OutputPoint))
        {
            OutputPoint temp1 = (OutputPoint)A;
            InputPoint temp2 = (InputPoint)B;

            temp2.ConnectsTo = A;
            return true;
        }
        else if (A.GetType() == typeof(InputPoint))
        {
            InputPoint temp1 = (InputPoint)A;
            OutputPoint temp2 = (OutputPoint)B;

            temp1.ConnectsTo = B;
            return true;
        }
        else throw new Exception();
    }

}

