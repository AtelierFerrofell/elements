using Godot;
using System;

[Tool]
[GlobalClass]
public partial class BasicElementInteraction : ElementInteraction
{
	[Export]
	public string Name { get; set; }
}
