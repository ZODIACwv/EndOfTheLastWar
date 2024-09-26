class_name GameMenu
extends MarginContainer



@export var bg_texture: Texture


func _ready() -> void:
	set_anchors_preset(Control.PRESET_FULL_RECT)
	set("theme_override_constants/margin_left", 24)
	set("theme_override_constants/margin_top", 24)
	set("theme_override_constants/margin_right", 24)
	set("theme_override_constants/margin_bottom", 24)
