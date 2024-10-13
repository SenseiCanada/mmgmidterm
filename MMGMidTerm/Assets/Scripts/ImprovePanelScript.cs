using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;
using Unity.VisualScripting;
using Articy.Mmgmidterm;
using UnityEngine.SocialPlatforms.Impl;

public class ImprovePanelScript : MonoBehaviour
{
    public float powerLvl;
    public TMP_Text powerText;

    public InventoryManager inventory;
    public InventoryItem sword;

    //public static event Action OnSwordImproved;

    // Start is called before the first frame update
    void Start()
    {

        if (sword.collected)
        {
            powerLvl = sword.powerLevel; 
            powerText.text = powerLvl.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (sword != null)
        {
            sword.powerLevel = powerLvl;
            powerText.text = sword.powerLevel.ToString();
        }
    }

    public void IncreasePower()
    {
        powerLvl++;
    }

    //public void SwordAdded(InventoryItem item)
    //{
    //    if (item.id == "DragonSlayer")
    //    {
    //        inventoryItem = item;
    //    }
    //}
}
