using Godot;
using System;

[Tool]
[GlobalClass]
public partial class BasicElementInfo : ElementInfo
{
	[Export]
	public string Name { get; set; }

	[Export]
	public Godot.Color Color { get; set; }
}
