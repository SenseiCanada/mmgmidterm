using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New InvSave")]
public class InventorySaveState : ScriptableObject
{
    public InventoryItem SwordState;
    public InventoryItem MundaneItem;
    public int attempts;
    public int attemptsWithMundane;
    public int maxPwr = 1000000;

}
