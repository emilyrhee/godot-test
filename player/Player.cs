using Godot;
using System;

public partial class Player : CharacterBody2D {
	private int speed = 100;
    private int health = 30;
	private AnimationPlayer animation;

	public override void _Ready() {
		animation = GetNode<AnimationPlayer>("AnimationPlayer");
	}

	private void UpdateAnimation() {		
		if (Velocity.Length() == 0) {
			animation.Stop();
		} else {
			string direction = "down";

		if (Velocity.X != 0) {
			if (Velocity.X < 0) {
				direction = "left";
			} else {
				direction = "right";
			}
		} else {
			if (Velocity.Y < 0) {
				direction = "up";
			} else {
				direction = "down";
			}
		}

			animation.Play("walk_" + direction);
		}
	}

    private void Move() {
		Vector2 inputVector = new Vector2(
			Input.GetActionStrength("d") - Input.GetActionStrength("a"),
			Input.GetActionStrength("s") - Input.GetActionStrength("w")
		).Normalized();

		Velocity = inputVector * speed;
		MoveAndSlide();
    }

	public override void _Process(double delta) {
        Move();
		UpdateAnimation();
	}
}