using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Mmgmidterm;
using Articy.Mmgmidterm.GlobalVariables;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;

public class EnterDoor : MonoBehaviour
{
    private bool doorUnlocked;
    private bool aDoor;
    public string recapSceneName = "RecapScene";
    public Button exitDialogueBtn;
    private bool isNearDoor;
    public InventorySaveState invSave;
    //private bool canExit;
    // Start is called before the first frame update
    void Start()
    {
        ArticyGlobalVariables.Default.GargoyleDialogue.EnterDoor = false;
    }

    // Update is called once per frame
    void Update()
    {
        doorUnlocked = ArticyGlobalVariables.Default.GargoyleDialogue.EnterDoor;
        if (doorUnlocked && isNearDoor == true)
        {
            EnterPortal();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<ArticyPlayerController>() != null)
        {
            isNearDoor = true;
        }
        else isNearDoor = false;
    }

    public void EnterPortal()
    {
        invSave.attempts++;
        if (invSave.MundaneItem != null)
        {
            invSave.attemptsWithMundane++;
        }
        
        if (invSave.SwordState != null)
        {
            SceneManager.LoadScene("RecapScene");
        }
        
        if (invSave.SwordState == null) //invSave.SwordState.powerLevel == invSave.maxPwr ||
        {
            SceneManager.LoadScene("EndGame");
        }
    }

    //private void ExitClicked()
    //{
    //    canExit = true;
    //}
}
