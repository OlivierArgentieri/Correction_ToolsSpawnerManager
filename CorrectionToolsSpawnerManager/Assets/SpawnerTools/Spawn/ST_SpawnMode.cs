using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST_SpawnMode
{
    public ST_SpawnType Type = ST_SpawnType.Circle;
    public ST_CircleMode circleMode = new ST_CircleMode();
}

public enum ST_SpawnType
{
    Circle,
    Lie,
    Point
}