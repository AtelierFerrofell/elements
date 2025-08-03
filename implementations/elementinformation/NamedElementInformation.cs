using Godot;
using System;

[GlobalClass]
public partial class NamedElementInformation : ElementInformation
{
    [Export]
    public string Name { get; set; }
}
