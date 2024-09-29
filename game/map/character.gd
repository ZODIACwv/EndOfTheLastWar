class_name GameCharacter
extends CharacterBody2D


@onready var controller_component := Controller.new(self)



class Controller:
	var target := Vector2()
	
	func _init(char: GameCharacter) -> void:
		pass
	
	func move_char():
		pass
