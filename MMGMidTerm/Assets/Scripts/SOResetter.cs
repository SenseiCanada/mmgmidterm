using Articy.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOResetter : MonoBehaviour
{
    public InventorySaveState invSave;
    public InventoryItem swordItem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetSO()
    {
        invSave.MundaneItem = null;
        invSave.SwordState = null;
        invSave.attempts = 0;
        invSave.attemptsWithMundane = 0;
        swordItem.collected = false;
        swordItem.powerLevel = 0;
        ArticyDatabase.DefaultGlobalVariables.ResetVariables();
    }
}
