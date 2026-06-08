using Godot;
using System;

public partial class Myscript : TextureRect
{
	public override void _EnterTree()
	{
		GD.Print("EnterTree");
	}


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Ready");

		// this.QueueFree();	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		// GD.Print("Ready");
	}

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);
	}

	public override void _ExitTree()
	{
		GD.Print("ExitTree");
	}


}
