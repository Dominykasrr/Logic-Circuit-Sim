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

    public void Draw()
    {
        throw new System.NotImplementedException();
    }

    public void DrawConnections()
    {
        throw new System.NotImplementedException();
    }

    /// <summary>
    /// Checks if this Element was clicked
    /// </summary>
    /// <returns>Returns a boolean</returns>
    public bool AreYouClicked(int x, int y)
    {
        bool condition = (x <= (this.X + (this.Img[0].Width / 2)) && 
                          x >= (this.X - (this.Img[0].Width / 2)) && 
                          y <= (this.Y - (this.Img[0].Height / 2)) && 
                          y >= (this.Y + (this.Img[0].Height / 2)));

        if (condition) return true;
        else return false;
    }

}

