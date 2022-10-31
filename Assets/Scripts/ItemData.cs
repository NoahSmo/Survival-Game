using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Items/New item")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite visual;
    public GameObject prefab;
}
