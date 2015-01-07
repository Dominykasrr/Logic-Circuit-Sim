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
        int intState = Convert.ToInt16(State);
        gr.DrawImage(Img[intState], new Rectangle(this.X - Img[intState].Width / 2, this.Y - Img[intState].Height / 2, Img[intState].Width, Img[intState].Height));
    }

}

