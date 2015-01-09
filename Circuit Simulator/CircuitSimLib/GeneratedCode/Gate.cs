using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public abstract class Gate : Element
{
    /// <summary>
    ///Inputs of the Gate
    /// </summary>
	public InputPoint[] Input { get; set; }

    /// <summary>
    ///Output of the Gate
    /// </summary>
	public OutputPoint Output { get; set; }

    /// <summary>
    ///Constructor
    /// </summary>
    public Gate() : base()
    {
        Img = new Image[1];
    }
    public override void Draw(Graphics gr)
    {
        gr.DrawImage(Img[0], new Rectangle(this.X - Img[0].Width / 2, this.Y - Img[0].Height / 2, Img[0].Width, Img[0].Height));
    }

    /// <summary>
    ///Calculates the output based on the inputs
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public abstract bool CalculateOutput();
    public override void DrawConnections(Graphics gr)
    {
        foreach (InputPoint input in Input)
            if (input.ConnectsTo != null)
            {
                Pen pen;
                if (input.ConnectedElementsOutput()) pen = new Pen(Color.Green,2);
                else pen = new Pen(Color.Black,2);
                gr.DrawLine(pen, input.X, input.Y, input.ConnectsTo.X, input.ConnectsTo.Y);
            }
    }
}

