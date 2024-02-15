using Godot;
using System;

public partial class DrumHit : Node2D {
    private Boolean isInArea = false;
    [Export]
    private string action;
    private void _on_area_entered(Area2D area) {
        isInArea = true;
    }

    private void _on_area_exited() {
        isInArea = false;
    }
	public override void _Process(double delta) {
        if (isInArea && Input.IsActionPressed(action)) {
            QueueFree();
        }

        MoveLocalX(-5);
	}
}
