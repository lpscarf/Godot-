using Godot;
using System;
using System.Reflection.Metadata.Ecma335;

public partial class Vector2Learn : Node2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Vector2 pos = new Vector2(100,100); //坐标，表示向量
		Vector2 dir = new Vector2(1,0);   

		// Vector2.Up;
		// Vector2.Down;
		// Vector2.Left;
		// Vector2.Right;
		// Vector2.Zero;0.0
		// Vector2.One;1.1

		Vector2 a = new Vector2(3,4);
		Vector2 b = new Vector2(1,2);

		// Vector2 c = a+b;//4,6
		// Vector2 d = a-b;
		// Vector2 e = a*2;

		a.Length();//5
		a.LengthSquared();//25

		Vector2 res = a.Normalized(); // a/s = new vector2(3/5,4/5)
		

	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
