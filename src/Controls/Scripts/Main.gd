extends Node2D

var configuration_window = preload("res://Controls/Scenes/ProjectConfig.tscn").instance()

func _on_NewButton_pressed() -> void:
	add_child(configuration_window)

func _on_ExitButton_pressed() -> void:
	get_tree().quit()
