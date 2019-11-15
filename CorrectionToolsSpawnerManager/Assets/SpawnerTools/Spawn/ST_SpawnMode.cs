using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ST_SpawnMode
{
    public ST_SpawnType Type = ST_SpawnType.Circle;
    
    
    public ST_CircleMode CircleMode = new ST_CircleMode();
    public  ST_LineMode LineMode= new ST_LineMode();
    public ST_PointMode PointMode = new ST_PointMode();

    public ST_Mode Mode
    {
        get
        {
            switch (Type)
            {
                case ST_SpawnType.Circle:
                    return CircleMode;

                case ST_SpawnType.Line:
                    return LineMode;
                
                case ST_SpawnType.Point:
                    return PointMode;

            }

            return null;
        }
        private set{}
    }
    
}


public enum ST_SpawnType
{
    Circle,
    Line,
    Point
}