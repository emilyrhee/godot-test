using Godot;
using System;

public partial class Ka : Sprite2D {
    private Boolean isInArea = false;
    private void _on_area_entered(Area2D area) {
        isInArea = true;
    }

    private void _on_area_exited() {
        isInArea = false;
    }
	public override void _Process(double delta) {
        if (isInArea && Input.IsActionPressed("ka")) {
            GD.Print("hi");
            QueueFree();
        }

        MoveLocalX(-5);
	}
}