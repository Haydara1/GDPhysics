using Godot;
using System;

public class SpringPendulum : Node2D
{
	public double spring_constant;
	public double ball_mass;

	public override void _Ready()
	{
		
	}
	
	public override void _Draw()
	{
		var center = new Vector2(200, 200);
		float radius = 80;
		var color = new Color(1, 0, 0);
		DrawCircle(center, radius, color);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//	  Update()
//  }
}
