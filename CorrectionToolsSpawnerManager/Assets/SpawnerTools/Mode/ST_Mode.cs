﻿using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public abstract class ST_Mode
{ 
    public Vector3 Position = Vector3.zero; 
    
    #region custom methods

    public abstract void Spawn(GameObject _agent);
    public abstract void Spawn(List<GameObject> _agents);
#if UNITY_EDITOR
    public abstract void DrawSceneMode();
    public abstract void DrawSettings();
    public abstract void DrawLinkTosSpawner(Vector3 Position);
#endif

    #endregion
}