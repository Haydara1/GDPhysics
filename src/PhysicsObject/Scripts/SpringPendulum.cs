using Godot;
using System;

public class SpringPendulum : Node2D
{
	
	// Physics variables
	[Export] public double spring_constant;
	[Export] public double ball_mass;
	
	// Graphics variables
	[Export] public float radius = 80;
	[Export] public Vector2 center = new Vector2(200, 200);
	[Export] public Color color = new Color(1, 0, 0);

	public override void _Ready()
	{
		
	}
	
	public override void _Draw()
	{
		DrawCircle(this.center, this.radius, this.color);
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//	  Update()
//  }
}
