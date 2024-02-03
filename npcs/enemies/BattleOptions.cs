using Godot;
using System;

public partial class BattleOptions : VBoxContainer {
    private TextureButton fight;
	public override void _Ready() {
        fight = GetNode<TextureButton>("Fight");

        fight.GrabFocus();
	}

    private void _on_fight_pressed() {
        GD.Print("hi");
        Visible = false;
    }
}
