using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public abstract class Source : Element
{
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
        this.Output = new OutputPoint(this.X, this.Y, 25, this);
    }

    public override void Draw(Graphics gr)
    {
        base.Draw(gr);
    } 
}

