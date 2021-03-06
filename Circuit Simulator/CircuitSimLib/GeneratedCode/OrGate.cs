﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

/// <summary>
/// An OR gate class to store the correct image and 
/// calculate the appropriate output
/// </summary>
public class OrGate : Gate
{
    /// <summary>
    /// Constructor
    /// </summary>
    public OrGate()
    {
        this.Input = new InputPoint[2];
        this.Input[0] = new InputPoint(-42, -9, 10, this);
        this.Input[1] = new InputPoint(-42, 8, 10, this);
        this.Output = new OutputPoint(42, 0, 20, this);

        this.Img[0] = CircuitSimLib.Properties.Resources.or;
    }

    /// <summary>
    /// Calculates the output for an OR gate
    /// </summary>
    /// <returns>Returns a calculated boolean</returns>
    public override bool CalculateOutput()
    {
        return Input[0].ConnectedElementsOutput() || Input[1].ConnectedElementsOutput();
    }
}

