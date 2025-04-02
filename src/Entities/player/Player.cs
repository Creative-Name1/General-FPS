/*
 * March 27, 2025
 * Ivan Popov
 * Purpose: to deal with player movement (keys, mouse movement)
 */
using Godot;
using System;

public partial class Player : CharacterBody3D
{
    [Export] public float maxGroundedSpeed = 12.5f; // an [Export] variable can be accessed and changed in Godot (note: fastest man on earth managed to run around 12 m/s, so this is the temporary max grounded speed)
    [Export] public float mouseSensitivity = 3.0f; // I set this to 3.0 for no other reason than this is TF2's default mouse sensitivity (will likely import this value from elsewhere once I add GUI)

    private Vector3 _rotation = Vector3.Zero; // Vector3 = vector containing 3 values, for x, y, and z
    private Camera3D _camera;

    public override void _Ready()
    {
        _camera = GetNode<Camera3D>("Camera3D"); // GetNode<type>("Name") fetches reference to our "camera" object and assigns it to our Camera3D object (in the script)

        Input.MouseMode = Input.MouseModeEnum.Captured;
    }

    public override void _Input(InputEvent @event) // Godot sends input data when this function is called as an InputEvent object
    {
        if (@event is InputEventMouseMotion mouseEvent)
        {

        }
    }

    public override void _PhysicsProcess(double delta)
    {

    }
}

// Github test