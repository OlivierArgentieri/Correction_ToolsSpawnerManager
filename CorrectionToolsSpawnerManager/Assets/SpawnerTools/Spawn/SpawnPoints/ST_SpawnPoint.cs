using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ST_SpawnPoint
{
    #region f/p

    public bool IsVisible = true;
    public List<ST_SpawnMode> SpawnModes = new List<ST_SpawnMode>();
    public Vector3 Position = Vector3.zero;
    public Vector3 Size = Vector3.one;
    #endregion

    #region custom methods

    public void AddMode() => SpawnModes.Add(new ST_SpawnMode());
    public void RemoveMode(int _index) => SpawnModes.RemoveAt(_index);
    public void ClearAll() => SpawnModes.Clear();

    #endregion
}
