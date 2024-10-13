using Articy.Mmgmidterm.GlobalVariables;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AchivementManager : MonoBehaviour
{
    public TMP_Text achievTitle;
    public TMP_Text achievDescription;

    public InventorySaveState invSave;

    private int randomInt;
    private bool firstTime;

    public int aNoMundaneAttempts;
    public int aAttempts;
    public int noMundaneAttemptsInv;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;

        randomInt = Random.Range(0, 2);
        if (invSave.attemptsWithMundane > 1)
        {
            firstTime = false;
        } else firstTime = true;

        if (invSave.attemptsWithMundane == 0)
        {
            noMundaneAttemptsInv = invSave.attempts;
        }

        ArticyGlobalVariables.Default.GargoyleDialogue.AttemptsWOMundane = noMundaneAttemptsInv;
        ArticyGlobalVariables.Default.GargoyleDialogue.Attempts = invSave.attempts;
    }

    // Update is called once per frame
    void Update()
    {
        if (invSave.MundaneItem != null && !firstTime)
        {
            achievTitle.gameObject.SetActive(true);
            achievDescription.gameObject.SetActive(true);
            DisplayRandomOutcome();
        }
        if (invSave.MundaneItem != null && firstTime)
        {
            achievTitle.gameObject.SetActive(true);
            achievDescription.gameObject.SetActive(true);
            achievDescription.text = invSave.MundaneItem.benefit;
        }
    }

    void DisplayRandomOutcome()
    {
        if (randomInt == 0)
        {
            achievDescription.text = invSave.MundaneItem.benefit;
        }
        else achievDescription.text = invSave.MundaneItem.tragedy;

    }
}
