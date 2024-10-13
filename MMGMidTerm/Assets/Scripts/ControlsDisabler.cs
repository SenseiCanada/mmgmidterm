using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsDisabler : MonoBehaviour
{
    private Rigidbody playerRB;
    
    // Start is called before the first frame update
    void Start()
    {
        DialogueManager.OnPlayerSpeaking += DisableInputs;
        DialogueManager.OnDialogueEnd += EnableInputs;
        AnvilImprovement.OnImproveStart += DisableInputs;
        AnvilImprovement.OnImproveEnd += EnableInputs;

        playerRB = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisableInputs()
    {
        gameObject.GetComponent<StarterAssetsInputs>().cursorInputForLook = false;
        playerRB.constraints = RigidbodyConstraints.FreezeAll;
        Cursor.lockState = CursorLockMode.None;
    }

    public void EnableInputs()
    {
        gameObject.GetComponent<StarterAssetsInputs>().cursorInputForLook = true;
        playerRB.constraints = RigidbodyConstraints.None;
        playerRB.constraints = RigidbodyConstraints.FreezeRotation;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        DialogueManager.OnPlayerSpeaking -= DisableInputs;
        DialogueManager.OnDialogueEnd -= EnableInputs;
        AnvilImprovement.OnImproveStart -= DisableInputs;
        AnvilImprovement.OnImproveEnd -= EnableInputs;
    }
}
