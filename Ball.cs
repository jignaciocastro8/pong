using Godot;
using System;
public class Ball : Sprite {
	
	// Magnitud of movement.
	private int speedMagnitud;
	// Speed constant.
	private Vector2 directionVector;
	// Screen size.
	private Vector2 screenSize;
	// Left normal.
	private Vector2 leftNormal; 
	// Right normal.
	private Vector2 rightNormal;
	// Upper normal.
	private Vector2 upNormal;
	// Down normal.
	private Vector2 downNormal;


	public override void _Ready() {
		// Set initial position.
		this.Position = new Vector2(320, 188);
		// Set direction vector.
		this.directionVector = new Vector2(1, -1);
		// Set speed magnitud.
		this.speedMagnitud = 3;
		// Set screen size.
		this.screenSize = this.GetViewport().Size;
		// Set normal vectors.
		this.leftNormal = new Vector2(1, 0);
		this.rightNormal = new Vector2(-1, 0);
		this.upNormal = new Vector2(0, 1);
		this.downNormal = new Vector2(0, -1);


	}

	public override void _Process(float delta) {

	
		this.Position += this.directionVector * speedMagnitud;
		//left colission.
		if (this.Position.x <= 0) {
			float phi = this.directionVector.AngleTo(downNormal);
			this.directionVector = this.directionVector.Rotated(2 * phi);
		}
		// Right colission
		if (this.Position.x >= screenSize.x) {
			float phi = this.directionVector.AngleTo(upNormal);
			this.directionVector = this.directionVector.Rotated(2 * phi);
		}
		// Up colission
		if (this.Position.y <= 0) {
			float phi = this.directionVector.AngleTo(leftNormal);
			this.directionVector = this.directionVector.Rotated(2 * phi);
		}
		// Down colission.
		if (this.Position.y >= screenSize.y) {
			float phi = this.directionVector.AngleTo(rightNormal);
			this.directionVector = this.directionVector.Rotated(2 * phi);
		}
	}
}
