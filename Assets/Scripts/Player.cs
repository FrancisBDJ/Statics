using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
           
            ColorHelper.ChangeColor(this.gameObject,Color.red);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ColorHelper.ChangeColor(this.gameObject);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ColorHelper.SetDefaultColor(this.gameObject);
        }
    }
}
