using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{   
    [SerializeField]
    public static int enemyCount = 0;
    
    [SerializeField] private  GameObject enemy;
    
    private int z;
    

    public void enemyBehavior()
    {
        
        enemy = new GameObject();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           z += 1; 
           Instantiate(enemy, new Vector3(0, 0, z), Quaternion.identity);
           
           
        }
    }
}
