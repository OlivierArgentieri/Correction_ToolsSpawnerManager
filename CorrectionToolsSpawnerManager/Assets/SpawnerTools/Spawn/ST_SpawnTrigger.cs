using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

[Serializable]
public class ST_SpawnTrigger : MonoBehaviour
{
    #region f/p

    [SerializeField] private BoxCollider triggerZone = null;
    [SerializeField] private ST_SpawnPoint data = null;
    
    public bool Triggered { get; set; } = false;
    #endregion


    #region unity methods

    private void OnTriggerEnter()
    {
        if (!Triggered)
        {
            TriggerSpawn();
        }
        
        
    }

    #endregion



    #region custom methods

    void TriggerSpawn()
    {
        if (data == null) return;
        
        for (int i = 0; i < data.SpawnModes.Count; i++)
        {
            ST_SpawnMode _mode = data.SpawnModes[i];

            
            switch (_mode.Type)
            {
                case ST_SpawnType.Circle:            
                    _mode.circleMode.Spawn();
                    
                    break;
                case ST_SpawnType.Lie:
                    break;
                case ST_SpawnType.Point:
                    break;
            }
        }

        Triggered = true;
    }

    public void SetData(ST_SpawnPoint _data)
    {
        data = _data;
        transform.position = _data.Position;
        if (triggerZone) triggerZone.size = data.Size;
    }

    #endregion
    
#if UNITY_EDITOR
    #region debug

    private void OnDrawGizmos()
    {
        Handles.color = Color.green;
        Handles.DrawWireCube(transform.position, transform.localScale);
        Handles.color = Color.white;
    }

    #endregion
#endif
}
