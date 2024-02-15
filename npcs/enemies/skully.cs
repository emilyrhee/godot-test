using Godot;
using System;

public partial class skully : CharacterBody2D {
    private int health = 20;
    private void _on_area_2d_body_entered(Node2D body) {
        if (body.Name == "Player") {
            GetTree().ChangeSceneToFile("res://battle_stuff/battle.tscn");
        }
    }
}



