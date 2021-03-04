using Godot;
using System;

public class Left : Sprite {
	// Movement constant.
	private int MOVEMENT_SIZE = 5;
	//Initial position constant.
	private Vector2 INITIAL_POSITION = new Vector2(67, 183);
	// Screen size.
	private Vector2 screenSize;
	// Texture size.
	private float textureHeight;

	// Class methods:

	public override void _Ready() {
		// Set initial position.
		this.Position = INITIAL_POSITION;
		// Set screen size. (This could be a variable of higher hierarchy)
		screenSize = this.GetViewport().Size;
		// Set texture size.
		textureHeight = this.Texture.GetSize().y;
	}



	public override void _Process(float delta) {
		// Move up.
		if (Input.IsKeyPressed((int)KeyList.W) && this.Position.y - textureHeight / 2 > 0) {
			this.Position += new Vector2(0, -MOVEMENT_SIZE);
		}
		// Move down.
		if (Input.IsKeyPressed((int)KeyList.S) && this.Position.y + textureHeight / 2 < screenSize.y) {
			this.Position += new Vector2(0, MOVEMENT_SIZE);

		}
	}
}
