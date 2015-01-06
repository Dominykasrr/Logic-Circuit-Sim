using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class StaticSource : Source
{
    /// <summary>
    ///Constructor
    /// </summary>
    public StaticSource()
        : base()
    {
        this.Img = new Image[2];
        this.Img[0] = CircuitSimLib.Properties.Resources.source;
        this.Img[1] = CircuitSimLib.Properties.Resources.source_on;
    }

    /// <summary>
    /// Toggles the state of the StaticSource
    /// </summary>
    public void Toggle()
    {
        this.State = !this.State;
    }

    public override void Draw(Graphics gr)
    {
        base.Draw(gr);
    }

}

