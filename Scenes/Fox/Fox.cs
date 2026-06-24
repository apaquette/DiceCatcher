using System;
using Godot;

public partial class Fox : Area2D
{
	[Export] public Sprite2D FoxSprite;
	private const float SPEED = 200f;
	private float move = 0f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		move = Input.GetAxis("ui_left", "ui_right");
		if(!Mathf.IsZeroApprox(move))
			FoxSprite.FlipH = move > 0;
	}
	public override void _PhysicsProcess(double delta)
	{
		Position += new Vector2(move * SPEED * (float)delta, 0);
	}
}
