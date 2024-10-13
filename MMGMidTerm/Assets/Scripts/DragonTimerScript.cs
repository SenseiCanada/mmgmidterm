using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class DragonTimerScript : MonoBehaviour
{
    public TMP_Text dragonTimerText;
    private float timer;
    public InventoryItem sword;
    //public ScriptableObject inventorySO;
    public float swordPower;

    // Start is called before the first frame update
    void Start()
    {
        swordPower = sword.powerLevel;


        timer = 10 - (((10*swordPower)) / (swordPower+10));

        string timerText = timer.ToString();
        dragonTimerText.text = timerText + " minutes";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
