using Godot;
using System;

[GlobalClass]
public partial class NamedElementInteraction : ElementInteraction
{
    [Export]
    public string Name { get; set; }
}
