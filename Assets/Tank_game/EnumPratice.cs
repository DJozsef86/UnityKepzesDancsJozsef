using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum DayOfAWeek
{
    Monday,
    Tuesday,
    Wednasday,
    Friday,
}
enum Direction
{
    North,
    South,
    West,
    East,
}

public class EnumPratice : MonoBehaviour
{
   [SerializeField] DayOfAWeek day;
   [SerializeField] Direction direction;

   [SerializeField] Vector2 diretionVec;

    void OnValidate()
    {
        diretionVec = DiretionToVector(direction);

    }

    Vector2 DiretionToVector(Direction direction)
    {
        if (direction == Direction.East)
            return new Vector2(1, 0);

        if (direction == Direction.West)
            return new Vector2(-1, 0);

        if (direction == Direction.North)
            return new Vector2(0, 1);

        if (direction == Direction.South)
            return new Vector2(0, 1);

        return Vector2.zero;

    }
}
