using System;
using System.Collections.Generic;
using UnityEngine;

public class ST_SpawnerTools : MonoBehaviour
{
    #region f/p
    public List<ST_SpawnPoint> SpawnPoints = new List<ST_SpawnPoint>();
    public ST_SpawnTrigger TriggerZonePrefabs = null;
    
    #endregion

    #region unity methods

    private void Start()
    {
        SpawnAll();
    }

    #endregion


    #region custom methods

    void SpawnAll()
    {
        if (!TriggerZonePrefabs) return;
        
        for (int i = 0; i < SpawnPoints.Count; i++)
        {
            ST_SpawnTrigger _trigger = Instantiate(TriggerZonePrefabs);
            if(_trigger) _trigger.SetData(SpawnPoints[i]);
           
        }
    }
    public void AddPoint() => SpawnPoints.Add(new ST_SpawnPoint());
    public void Remove(int _index) => SpawnPoints.RemoveAt(_index);
    public void Clear() => SpawnPoints.Clear();
    

    #endregion
}