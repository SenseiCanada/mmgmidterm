using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Mmgmidterm;
using Articy.Mmgmidterm.GlobalVariables;

public class AnvilSpawner : MonoBehaviour
{
    private bool AnvilActive;
    public GameObject anvilObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        AnvilActive = ArticyGlobalVariables.Default.GargoyleDialogue.AnvilActive;
        if (!anvilObj.activeInHierarchy && AnvilActive)
        {
            anvilObj.SetActive(true);
        }

    }
}
