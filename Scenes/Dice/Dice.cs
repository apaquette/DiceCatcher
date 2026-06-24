using Godot;

public partial class Dice : Area2D
{
	[Export] public Sprite2D DiceSprite;
	private const float SPEED = 100f;
	private const float ROTATIONSPEED = 4f;
	private int RotationDirection = GD.Randi() % 2 == 0 ? 1 : -1;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

    public override void _PhysicsProcess(double delta)
    {
        Position += new Vector2(0, 1) * (float)delta * SPEED;
		DiceSprite.GlobalRotation += ROTATIONSPEED * (float)delta * RotationDirection;
		CheckGameOver();
    }

	private void CheckGameOver()
	{
		Rect2 vpr = GetViewportRect();
		if(Position.Y > vpr.Size.Y)
		{
			SetPhysicsProcess(false);
			QueueFree();
		}
	}
}
