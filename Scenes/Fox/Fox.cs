using Godot;

public partial class Fox : Area2D
{
	[Export] public Sprite2D FoxSprite;
	private const float SPEED = 3f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

    // public override void _Input(InputEvent @event)
    // {
	// 	// Right arrow key pressed
    //     if (@event.IsActionPressed("ui_right"))
	// 	{
	// 		Position += new Vector2(SPEED, 0);
	// 	}
	// 	// Left arrow key pressed
	// 	if (@event.IsActionPressed("ui_left"))
	// 	{
	// 		Position -= new Vector2(SPEED, 0);
	// 	}
    // }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if(Input.IsActionPressed("ui_right"))
		{
			FoxSprite.FlipH = true;
			Position += new Vector2(SPEED, 0);
		}
		else if(Input.IsActionPressed("ui_left"))
		{
			FoxSprite.FlipH = false;
			Position -= new Vector2(SPEED, 0);
		}
	}
}
