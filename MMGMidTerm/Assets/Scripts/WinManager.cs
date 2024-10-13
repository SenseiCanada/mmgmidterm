using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WinManager : MonoBehaviour
{
    public TMP_Text movingOn;
    public TMP_Text maxImprove;

    public InventorySaveState invSave;
    // Start is called before the first frame update
    void Start()
    {
        if (invSave.SwordState == null)
        {
            movingOn.gameObject.SetActive(true);
        }

        if (invSave.SwordState != null && invSave.SwordState.powerLevel == invSave.maxPwr)
        {
            maxImprove.gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
