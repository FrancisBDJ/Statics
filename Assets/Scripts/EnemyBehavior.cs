using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private UiManager _uiManager;
    

    public void OnEnable()
    {
        SpawnManager.enemyCount++;
        _uiManager = GameObject.Find("UiManager").GetComponent<UiManager>();
        _uiManager.UpdateEnemyCount();
        Destroy(this, 10);
    }

    public void OnDisable()
    {
        SpawnManager.enemyCount--;
    }
}
