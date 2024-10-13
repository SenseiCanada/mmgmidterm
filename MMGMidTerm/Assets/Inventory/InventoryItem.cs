using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Items")]
public class InventoryItem : ScriptableObject
{
    public string id;
    public Sprite icon;
    public int UISlot;
    public float powerLevel;
    public bool collected;
    public string benefit;
    public string tragedy;
    public GameObject model;
    public GameObject modelParent;

}
