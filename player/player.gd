extends CharacterBody2D

var speed = 200

func _process(delta):
	velocity = Input.get_vector("a", "d", "w", "s") * speed
	move_and_slide()
