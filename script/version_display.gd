extends CanvasLayer

var label := Label.new()


func _init() -> void:
	self.layer = 100
	add_child(label)
	
	label.set("theme_override_constants/outline_size", 4)
	label.set("theme_override_colors/font_outline_color", Color("2c1700c8"))
	label.set("theme_override_colors/font_color", Color("e88d00"))
	label.set("theme_override_font_sizes/font_size", 16)


func _ready() -> void:
	var version_text: String = "v%d.%d.%d %s" %\
		[
			ProjectSettings.get_setting("Game/dev/version/major", 0),
			ProjectSettings.get_setting("Game/dev/version/minor", 0),
			ProjectSettings.get_setting("Game/dev/version/patch", 0),
			ProjectSettings.get_setting("Game/dev/version/suffix", ""),
		]
	
	label.text = version_text
	get_tree().root.get_viewport().size_changed.connect(update_version_text_position)
	update_version_text_position()


func update_version_text_position():
	var size := get_tree().root.size
	label.position.y = size.y - label.size.y
	label.position.x = size.x / 2 - label.size.x
