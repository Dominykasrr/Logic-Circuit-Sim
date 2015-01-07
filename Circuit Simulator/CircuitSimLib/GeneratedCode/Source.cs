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
    public OutputPoint Output 
    {
        get 
        {
            this.output.X = X;
            this.output.Y = Y;
            return this.output; 
        } 
        set
        {
            this.output = value;
        } 
    }

    /// <summary>
    ///Constructor
    /// </summary>
    public Source()
        : base()
    {
        this.State = false;
        this.Output = new OutputPoint(this.X, this.Y, 25, this);
        this.Img = new Image[2];

    }

    public override void Draw(Graphics gr)
    {
        int intState = Convert.ToInt16(State);
        gr.DrawImage(Img[intState], new Rectangle(this.X - Img[intState].Width / 2, this.Y - Img[intState].Height / 2, Img[intState].Width, Img[intState].Height));
    }
    public override void DrawConnections(Graphics gr)
    {
        if (output != null)
        {
            Pen pen;
            if (State) pen = new Pen(Color.Green);
            else pen = new Pen(Color.Black);
            foreach (ConnectionPoint cp in output.ConnectsTo)
            {
                gr.DrawLine(pen, output.X, output.Y, cp.X, cp.Y);
            }
        }
    }
}

