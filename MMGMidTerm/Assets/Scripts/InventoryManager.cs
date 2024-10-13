using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using Articy.Mmgmidterm.GlobalVariables;
using UnityEditor;

public class InventoryManager : MonoBehaviour
{
    public Image Slot1;
    public Image Slot2;
    public Image clearSlot;
    public TMP_Text invPwrTxt;
    public float swordPwr;

    public InventoryItem sword;
    public GameObject swordParent;

    public InventorySaveState invSave;

    // Start is called before the first frame update
    void Start()
    {
        ItemCollectorScript.OnItemAdded += AddItem;

        if (sword.collected)
        {
            invSave.SwordState = sword;
            swordPwr = sword.powerLevel;
            invPwrTxt.text = swordPwr.ToString();
            Slot1.sprite = sword.icon;
        }
    }

   
    // Update is called once per frame
    void Update()
    {
        if (sword.collected)
        {
            invPwrTxt.text = sword.powerLevel.ToString();
        }
        else
        {
            invPwrTxt.text = null;
            Slot1.sprite = null;
        }

        if (invSave.MundaneItem != null)
        {
            invSave.MundaneItem = null;
        }
    }

    private void AddItem(InventoryItem item)
    {

        if (item.UISlot == 1)
        {
            if (Slot1 != null)
            {
                Slot1.sprite = item.icon;
            }
            invSave.SwordState = item;
            item.collected = true;
            ArticyGlobalVariables.Default.GargoyleDialogue.HasSword = true;
        }

        if (item.UISlot == 2)
        {
            if (invSave.MundaneItem != null)
            {
                invSave.MundaneItem = null;
            }
            if (Slot2 != null)
            {
                Slot2.sprite = item.icon;
            }
            invSave.MundaneItem = item;
            item.collected = true;
        }

    }

    public void DropItem1()
    {
        //Debug.Log("Dropping sword attempted");
        if (sword.collected)
        {
            sword.collected = false;
            Slot1.sprite = null;
            invPwrTxt.text = null; //->connect the right prefab
            Instantiate(swordParent, swordParent.transform.position, Quaternion.Euler(0,0,90));
            invSave.SwordState = null;
        }
    }
    
}
