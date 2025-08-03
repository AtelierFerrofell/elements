using Godot;
using System;

[GlobalClass]
public partial class BasicElementInformation : NamedElementInformation
{
    [Export]
    public Godot.Color Color { get; set; }
}
