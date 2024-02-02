using Godot;
using System;

public partial class StartMenu : Node2D {
    private Button play;
    public override void _Ready() {
        play = GetNode<Button>("StartMenuButtons/Play");

        play.GrabFocus();
    }

    private void _on_play_pressed() {
        GetTree().ChangeSceneToFile("res://world.tscn");
    }

    private void _on_quit_pressed() {
        GetTree().Quit();
    }
}
