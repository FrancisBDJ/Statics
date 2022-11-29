using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]


public class Item 
{   
    [SerializeField]
    protected string itemName;
    [SerializeField]
    protected int id;
    [SerializeField]
    protected string description;

    public static int numberCreated;
    
    

    public Item(string itemName, string description)
    {
        this.itemName = itemName;
        this.id = Item.numberCreated;
        Item.numberCreated++;
        this.description = description;
    }
    
    public Item()
    {
        this.id = Item.numberCreated;
        Item.numberCreated++;
    }
    
    public override string ToString()
    {
        return ("itemName: " + this.itemName + "id: " + this.id + "description: " + this.description);
    }
}