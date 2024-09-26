extends CanvasLayer


@export var new_game_menu: PackedScene


func _on_continue_pressed() -> void:
	pass


func _on_new_game_pressed() -> void:
	get_tree().change_scene_to_packed(new_game_menu)


func _on_help_pressed() -> void:
	pass


func _on_mods_pressed() -> void:
	pass


func _on_exit_pressed() -> void:
	get_tree().quit()
