using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI activeEnemiesText;
    

    public void UpdateEnemyCount()
    {
        activeEnemiesText.text = "Enemies: " + SpawnManager.enemyCount;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
