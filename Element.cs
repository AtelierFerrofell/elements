using Godot;
using System;

[GlobalClass]
public partial class Element : Resource
{
	[Export]
	public ElementInformation Information { get; set; }
	
	[Export]
	public Godot.Collections.Dictionary<Element, ElementInteraction> Interactions { get; set; }
}
