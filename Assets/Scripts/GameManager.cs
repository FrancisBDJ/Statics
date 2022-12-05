using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
   
    void Start()
    {
       itemList.Add(new Item("ITEMnom1","soc un item"));
       itemList.Add(new Item("ITEMnom2", "son un altre item"));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            itemList.Add(new Item());
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            itemList.RemoveAt (0);
        }
        
        if (Input.GetKeyDown(KeyCode.N))
        {
            Debug.Log(Item.numberCreated);
        }
    }
}
