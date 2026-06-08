using Godot;
using System;
using System.Threading.Tasks;

public partial class Frog : CharacterBody2D
{
	public const float Speed = 200.0f;

	private bool IsChasing = false;
	private bool IsDie = false;
	private Player player;
	private AnimatedSprite2D animSprite;
    public override void _Ready()
    {
        animSprite = GetNode<AnimatedSprite2D>("AnimatedSprite2D");
    }


	public override void _PhysicsProcess(double delta)
	{
		if(IsDie)return;
		Vector2 velocity = Velocity;

		// Add the gravity.
		if (!IsOnFloor())
		{
			velocity += GetGravity() * (float)delta;
		}

		if (IsChasing)
		{
			Vector2 positiononOffset = player.GlobalPosition - this.GlobalPosition;
			if (positiononOffset.X > 0)
			{
				animSprite.FlipH = true;
				velocity.X = Speed;
	
			}else if(positiononOffset.X<0)
			{
				animSprite.FlipH = false;
				velocity.X = -Speed;
			}
			animSprite.Play("Jump");
		}
		else
		{
			velocity.X = 0;
			animSprite.Play("Idle");
		}
		
		
		Velocity = velocity;
		MoveAndSlide();
	}

	public void OnplayBodyEnter(Node2D body)
	{
		if(body.Name == "Player")
		{
			player = body as Player;
			IsChasing = true;
		}
	}

	public void OnplayBodyExit(Node2D body)
	{
		if(body.Name == "Player")
		{
			IsChasing = false;
		}
	}

	public async void OnDeathEnter(Node2D body)
	{
		if (body.Name == "Player")
		{
			Velocity = Vector2.Zero;
			IsDie = true;
			animSprite.Play("Death");

			await ToSignal(animSprite,AnimatedSprite2D.SignalName.AnimationFinished);

			this.QueueFree();
		}
	}
}
