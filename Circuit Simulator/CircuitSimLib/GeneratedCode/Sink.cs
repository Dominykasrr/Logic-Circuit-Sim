using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class Sink : Element
{
    /// <summary>
    ///The input of the Sink
    /// </summary>
    public InputPoint Input { get; set; }

    /// <summary>
    ///Constructor
    /// </summary>
    public Sink()
        : base()
    {
        this.Img = new Image[2];
        this.Img[0] = CircuitSimLib.Properties.Resources.lamp;
        this.Img[1] = CircuitSimLib.Properties.Resources.lamp_on;

        this.Input = new InputPoint(this.X, this.Y, 25);
    }

}

