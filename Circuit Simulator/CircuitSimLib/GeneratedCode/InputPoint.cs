﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/// <summary>
/// An InputPoint class
/// </summary>
public class InputPoint : ConnectionPoint
{
    /// <summary>
    /// The element this point is connected to
    /// </summary>
    public ConnectionPoint ConnectsTo { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public InputPoint(int x, int y, int r, Element owner)
        : base(x, y, r)
    {
        this.ConnectsTo = null;
        this.Owner = owner;
    }

    /// <summary>
    /// Checks if this InputPoint is clicked
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public override bool AreYouClicked(int x, int y)
    {
        return base.AreYouClicked(x, y);
    }

    /// <summary>
    /// Return the output of the connected element
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public bool ConnectedElementsOutput()
    {
        if(ConnectsTo == null)
        {
            return false;
        }
        if (ConnectsTo.Owner.GetType().BaseType == typeof(Gate))
        {
            Gate temp = (Gate)ConnectsTo.Owner;
            return temp.CalculateOutput();
        }
        else if (ConnectsTo.Owner.GetType().BaseType == typeof(Source))
        {
            Source temp = (Source)ConnectsTo.Owner;
            return temp.State;
        }
        throw new Exception();
    }


}

