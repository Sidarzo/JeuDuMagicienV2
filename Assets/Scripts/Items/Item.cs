using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public string description;
    public Sprite sprite;
    public GameObject prefab;
 
}
