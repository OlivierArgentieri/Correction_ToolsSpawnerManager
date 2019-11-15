using System;
using System.Collections.Generic;
using UnityEngine;

public class ST_SpawnerTools : MonoBehaviour
{
    #region f/p
    public List<ST_SpawnPoint> SpawnPoints = new List<ST_SpawnPoint>();
    #endregion

    #region unity methods
    
    #endregion


    #region custom methods
    public void AddPoint() => SpawnPoints.Add(new ST_SpawnPoint());
    public void Remove(int _index) => SpawnPoints.RemoveAt(_index);
    public void Clear() => SpawnPoints.Clear();
    

    #endregion
}