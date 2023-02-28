using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction
{
    Left,
    Right,
    Up,
    Down
}

public class PathManager : MonoBehaviour
{
    private Vector2 velocity;
    private Vector2[] directionVelocities;

    // Lets says we have to create a decision maker that can give us direction to walk in

    private void Start()
    {
        // Initialize the predifined values that could be given
        directionVelocities = new Vector2[]
        {
            new Vector2(-1, 0),
            new Vector2(1, 0),
            new Vector2(0, 1),
            new Vector2(0, -1),
        };
    }

    void Update()
    {
        switch (UnityEngine.Random.Range(0, directionVelocities.Length))
        {
            case (int)Direction.Left:
                velocity = directionVelocities[(int)Direction.Left];
                break;
            case (int)Direction.Right:
                velocity = directionVelocities[(int)Direction.Right];
                break;
            case (int)Direction.Up:
                velocity = directionVelocities[(int)Direction.Up];
                break;
            case (int)Direction.Down:
                velocity = directionVelocities[(int)Direction.Down];
                break;
        }    
    }
}
