﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Element
{
	public virtual int ElementID
	{
		get;
		set;
	}

	public virtual int X
	{
		get;
		set;
	}

	public virtual int Y
	{
		get;
		set;
	}

	public virtual void Draw()
	{
		throw new System.NotImplementedException();
	}

	public virtual void DrawConnections()
	{
		throw new System.NotImplementedException();
	}

	public virtual bool AreYouClicked()
	{
		throw new System.NotImplementedException();
	}

}

