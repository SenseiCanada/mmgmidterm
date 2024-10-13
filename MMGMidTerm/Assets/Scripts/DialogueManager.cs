using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.Unity.Interfaces;
using System;
using Articy.Mmgmidterm;
using TMPro;
using Articy.Mmgmidterm.GlobalVariables;

public class DialogueManager : MonoBehaviour, IArticyFlowPlayerCallbacks
{
    [Header("UI")]
    // Reference to Dialog UI
    [SerializeField]
    GameObject dialogueWidget;
    // Reference to dialogue text
    [SerializeField]
    TMP_Text dialogueText;
    // Reference to speaker
    [SerializeField]
    TMP_Text dialogueSpeaker;
    [SerializeField]
    RectTransform branchLayoutPanel;
    [SerializeField]
    GameObject branchPrefab;
    [SerializeField]
    GameObject closePrefab;

    public static event Action OnPlayerSpeaking;
    public static event Action OnDialogueEnd;

    //adding button functionality


    // To check if we are currently showing the dialog ui interface
    public bool DialogueActive { get; set; }

    //add reference to flow player, which is a component on Dialogue Manager object
    private ArticyFlowPlayer flowPlayer;

    void Start()
    {
        //initialize (reference to) flow player
        flowPlayer = GetComponent<ArticyFlowPlayer>();
    }

    private void ContinueDialogue()
    {
        flowPlayer.Play();
    }

    public void StartDialogue(IArticyObject aObject)
    {
        DialogueActive = true;
        dialogueWidget.SetActive(DialogueActive);
        flowPlayer.StartOn = aObject;
        OnPlayerSpeaking();
    }

    public void CloseDialogueBox()
    {
        DialogueActive = false;
        dialogueWidget.SetActive(DialogueActive);
        flowPlayer.FinishCurrentPausedObject();
        OnDialogueEnd();
    }



    public void OnFlowPlayerPaused(IFlowObject aObject)
    {
        //clears text from last speaker
        dialogueText.text = string.Empty;
        dialogueSpeaker.text = string.Empty;

        //youtube comment said to change from IObjectWithText
        //apparently Dialogue Fragment doesn't implement IObjectWithText
        var objectWithText = aObject as IObjectWithLocalizableText; 
        if (objectWithText != null)
        {
            dialogueText.text = objectWithText.Text;
        }

        var objectWithSpeaker = aObject as IObjectWithSpeaker;
        if (objectWithSpeaker != null)
        {
            var speakerEntity = objectWithSpeaker.Speaker as Entity;
            if (speakerEntity != null)
            {
                dialogueSpeaker.text = speakerEntity.DisplayName;
            }
        }
    }

    public void OnBranchesUpdated(IList<Branch> aBranches)
    //has access to a list of all branches in a dialogue
    {
        //Clear all (previous) branches
        CLearAllBranches();
        
        
        //will check all of them with for loop if finished
        bool dialgueIsFinished = true;

        foreach (var branch in aBranches)
        {
            //check is the next thing after current branch is also a fragment
            if (branch.Target is IDialogueFragment)
            {
                dialgueIsFinished = false;  
            }
        }

        if (!dialgueIsFinished)
        {
            OnPlayerSpeaking();//add an event to listeners
            foreach (var branch in aBranches)
            {
                GameObject button = Instantiate(branchPrefab, branchLayoutPanel);//instantiate prefab as child of argument 2
                button.GetComponent<BranchChoice>().AssignBranch(flowPlayer, branch);//get script off button prefab
            }
        }
        else //when it is finished
        {
            GameObject button = Instantiate(closePrefab, branchLayoutPanel);
            var btnComp = button.GetComponent<Button>();
            btnComp.onClick.AddListener(CloseDialogueBox);
        }

        void CLearAllBranches()
        {
            foreach (Transform child in branchLayoutPanel)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
