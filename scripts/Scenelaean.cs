using Godot;
using System;

public partial class Scenelaean : Node2D
{
	[Export]
	public PackedScene otherScene;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (Input.IsActionJustPressed("jump"))
		{
			SceneTree st = this.GetTree();
			// st.ChangeSceneToFile("res://Scence/Scene03.tscn");
			// st.ChangeSceneToPacked(otherScene);

			Node node = otherScene.Instantiate();
			st.CurrentScene.AddChild(node);
		}
	}
}
