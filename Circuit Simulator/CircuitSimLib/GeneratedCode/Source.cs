using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public abstract class Source : Element
{
    private OutputPoint output;
    /// <summary>
    ///A boolean that states the current output of the source
    /// </summary>
    public bool State { get; set; }

    /// <summary>
    //An OutputPoint that specifies the output for the source
    /// </summary>
    public OutputPoint Output { get; set; }

    /// <summary>
    ///Constructor
    /// </summary>
    public Source()
        : base()
    {
        this.State = false;
        this.Output = new OutputPoint(0, 0, 25, this);
        this.Img = new Image[2];

    }

    public override void Draw(Graphics gr)
    {
        int intState = Convert.ToInt16(State);
        gr.DrawImage(Img[intState], new Rectangle(this.X - Img[intState].Width / 2, this.Y - Img[intState].Height / 2, Img[intState].Width, Img[intState].Height));
    }
    public override void DrawConnections(Graphics gr)
    {

    }
}

