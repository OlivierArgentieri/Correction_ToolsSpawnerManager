﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

[Serializable]
public class ST_CircleMode
{
    #region f/p
    public int Radius = 5;
    public int AgentNumber = 10;
    public Vector3 Position = Vector3.zero;
    #endregion


    
    
    #region custom methods
    public Vector3 GetRadiusPosition(int _pos, int _maxPos, int _radius, Vector3 _center)
    {
        float _angle = (float)_pos / _maxPos * Mathf.PI * 2;

        float _x = _center.x + Mathf.Cos(_angle) * _radius;
        float _y = _center.y;
        float _z = _center.z + Mathf.Sin(_angle) * _radius;
        
        return new Vector3(_x, _y, _z);
    }
    #endregion

    #if UNITY_EDITOR

    public void DrawSettings()
    {
        Radius = EditorGUILayout.IntSlider("Radius", Radius, 1, 100);
        AgentNumber = EditorGUILayout.IntSlider("Agent number", AgentNumber, 1, 50);
    }
    public void DrawLinkTosSpawner(Vector3 _position) => Handles.DrawDottedLine(Position, _position, 0.5f);
    
    public void DrawSceneMode()
    {
        Position = Handles.PositionHandle(Position, Quaternion.identity);
        Handles.DrawWireDisc(Position, Vector3.up, Radius);
        for (int i = 0; i < AgentNumber; i++)
        {
            Handles.CubeHandleCap(i, GetRadiusPosition(i, AgentNumber, Radius, Position), Quaternion.identity, .1f, EventType.Repaint);
        }
    }
    #endif
}