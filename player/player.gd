extends CharacterBody2D

var speed: int = 200
@onready var animation = $AnimationPlayer
	
func updateAnimation():
	if velocity.length() == 0:
		animation.stop()
	else:
		var direction = "down"
		
		if velocity.x < 0:
			direction = "left"
		elif velocity.x > 0:
			direction = "right"
		elif velocity.y < 0:
			direction = "up"
			
		animation.play("walk_" + direction)
	
func _process(delta):
	velocity = Input.get_vector("a", "d", "w", "s") * speed
	move_and_slide()
	updateAnimation()
