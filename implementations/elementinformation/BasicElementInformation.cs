using Godot;
using System;

[GlobalClass]
public partial class BasicElementInformation : ElementInformation
{
    [Export]
    public string Name { get; set; }

    [Export]
    public Godot.Color Color { get; set; }
}
