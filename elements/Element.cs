using Godot;
using System;

[GlobalClass]
public partial class Element : Resource
{
	[Export]
	public string Name { get; set; }
}
