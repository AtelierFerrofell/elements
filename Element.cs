using Godot;
using System;

[Tool]
[GlobalClass]
public partial class Element : Resource
{
	[Export]
	public ElementInfo Info { get; set; }
	
	[Export]
	public Godot.Collections.Dictionary<Element, ElementInteraction> Interactions { get; set; }
}
