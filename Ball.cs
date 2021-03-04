using Godot;
using System;

public class Ball : Sprite {
	
	// Direction variable.
	private int direction = 1;
	// Speed constant.
	private float SPEED = 3;
	// Speed vector.
	private Vector2 speedVector;
	// Screen size.
	private Vector2 screenSize;

	// Class methods:

	public override void _Ready() {
		// Set initial position.
		this.Position = new Vector2(320, 188);
		// Set speed vector.
		this.speedVector = new Vector2(SPEED, 0);
		// Set screen size.
		this.screenSize = this.GetViewport().Size;
	}

	public override void _Process(float delta) {
	
		this.Position += speedVector * direction;

		// Left colission.
		if (this.Position.x <= 0 || this.Position.x >= screenSize.x) {
			this.direction = this.direction * -1;
		}
	}
}
