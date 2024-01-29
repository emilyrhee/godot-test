using Godot;
using System;

public partial class StartMenu : Node2D {
    private Button startMenuButtons;
    public override void _Ready() {
        startMenuButtons = GetNode<Button>("StartMenuButtons/Play");

        startMenuButtons.GrabFocus();
    }

    private void _on_play_pressed() {
        GetTree().ChangeSceneToFile("res://world.tscn");
    }

    private void _on_quit_pressed() {
        GetTree().Quit();
    }
}
