using Godot;
using System;

[GlobalClass]
public partial class Element : Resource
{
	[Export]
	public string Name { get; set; }
	
	[Export]
	public Godot.Collections.Dictionary<Element, int> Interactions { get; set; }
}
