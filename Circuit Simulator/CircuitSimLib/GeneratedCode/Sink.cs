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
        this.Input = new InputPoint(0, 0, 25, this);
    }
    public override void Draw(Graphics gr)
    {

        int intState = Convert.ToInt16(Input.ConnectedElementsOutput());
        gr.DrawImage(Img[intState], new Rectangle(this.X - Img[intState].Width / 2, this.Y - Img[intState].Height / 2, Img[intState].Width, Img[intState].Height));
    }
    public override void DrawConnections(Graphics gr)
    {
        if (Input.ConnectsTo != null)
        {
            Pen pen;
            if (Input.ConnectedElementsOutput()) pen = new Pen(Color.Green, 2);
            else pen = new Pen(Color.Black, 2);
            gr.DrawLine(pen, Input.X, Input.Y, Input.ConnectsTo.X, Input.ConnectsTo.Y);
        }
    }

}

