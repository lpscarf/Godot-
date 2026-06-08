using Godot;
using System;

public partial class InputLearn : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    	public override void _Process(double delta)
    	{
		// if(Input.IsKeyLabelPressed(Key.Space))
		// {
		// 	GD.Print("Space");
		// }

		//jump scape
		// if (Input.IsActionJustPressed("jump"))
		// {
		// 	GD.Print("jump 按下");
		// }else if (Input.IsActionPressed("jump"))
		// {
		// 	GD.Print("jump 按种");
		// }else if (Input.IsActionJustReleased("jump"))
		// {
		// 	GD.Print("jump 抬起");
		// }

		// float jump = Input.GetActionStrength("jump");
		// GD.Print(jump);

		// float h=Input.GetAxis("left","right");
		// GD.Print(h);

		Vector2 dir = Input.GetVector("left","right","up","down");
		GD.Print(dir);
		}
    // public override void _Input(InputEvent @event)
    // {
    //     if( @event is InputEventKey)
	// 	{
	// 		var key = @event as InputEventKey;
	// 		if(key.Keycode == Key.Space)
	// 		{
	// 			// if(key.IsReleased())
	// 			// {
	// 			// 	GD.Print("space realeased");
	// 			// }else if (key.IsEcho())
	// 			// {
	// 			// 	GD.Print("Space 持续");
	// 			// }else if (key.IsPressed())
	// 			// {
	// 			// 	GD.Print("spcae pressed");
	// 			// }
	// 			if (key.IsPressed() && !key.IsEcho())
	// 			{
	// 				GD.Print("space 按下");
	// 			}
	// 		}

	// 	}
		
	// 	if(@event is InputEventMouse)
	// 		{
	// 			var key = @event as InputEventMouse;
	// 		if (key.IsPressed())
	// 		{
	// 			GD.Print(key.Position);
	// 			GD.Print(key.ButtonMask);
	// 			GD.Print("鼠标按下");
	// 		}
	// 		}
    // } 

}

