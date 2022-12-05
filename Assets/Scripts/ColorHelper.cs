using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorHelper 
{
    public static Color cDefault;
    
    
    

    static ColorHelper()
    {
        cDefault = Color.blue;
    }
    
    public static void ChangeColor(GameObject myObject, Color color)
    {
        myObject.GetComponent<Renderer>().material.color = color;
    }


    public static void ChangeColor(GameObject myObject)
    {
        myObject.GetComponent<Renderer>().material.color = new Color(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
    }

    public static void SetDefaultColor(GameObject myObject)
    {
        ChangeColor(myObject,cDefault);
    }
    
    static 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
}
