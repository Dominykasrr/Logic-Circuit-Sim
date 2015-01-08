using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public abstract class Element
{
    /// <summary>
    /// ID of an Element
    /// </summary>
    public int ElementID { get; set; }
    private static int ElementCount = 0;

    /// <summary>
    /// The image of the Element
    /// </summary>
    public Image[] Img { get; set; }

    /// <summary>
    /// X coordinate of an Element
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// Y coordinate of an Element
    /// </summary>
    public int Y { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Element()
    {
        this.X = 0;
        this.Y = 0;

        this.ElementID = ElementCount;
        ElementCount++;
    }

    public abstract void Draw(Graphics gr);

    public abstract void DrawConnections(Graphics gr);

    /// <summary>
    /// Checks if this Element was clicked
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public bool AreYouClicked(int x, int y)
    {
        bool condition = (x <= (this.X + (this.Img[0].Width )) && 
                          x >= (this.X - (this.Img[0].Width )) && 
                          y >= (this.Y - (this.Img[0].Height )) && 
                          y <= (this.Y + (this.Img[0].Height )));

        if (condition) return true;
        else return false;
    }
}

