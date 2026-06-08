using Godot;
using System;
using System.Security.Cryptography.X509Certificates;

public partial class NodElearn : Node2D
{
	[Export]

	public Node inputNode;

	[Export]

	public Node newParent;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{

		//GetNode
		//绝对路径or相对路径
		// Node node = GetNode("/root/Scene02/TextureRect2");
		// node.QueueFree();

		// TextureRect node = GetNode<TextureRect>("/root/Scene02/TextureRect2");
		// node.FlipV=true;

		// TextureRect node = GetNode<TextureRect>("../../TextureRect2/Node");

		// Node node = GetParent();
		// GD.Print(node.Name);
		// GetParent<Node2D>();

		// TextureRect node = GetNode("%TextureRect4") as TextureRect;
		// GD.Print(node.Name);

		// 添加
		
	    // Node2D node = new Node2D();
		// node.Name = "newNode";
		// this.AddChild(node);

		//转移


        // GetParent().RemoveChild(this);
		// newParent.AddChild(this);

		// GetParent().CallDeferred("remove_child",this);
		// newParent.CallDeferred("add_child",this);

		// this.CallDeferred(Node.MethodName.Reparent,newParent);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
