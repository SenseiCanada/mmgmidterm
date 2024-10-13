using UnityEngine;
using UnityEngine.SceneManagement;
using Articy.Unity;
using Articy.Unity.Interfaces;
using Articy.Mmgmidterm.GlobalVariables;
//namespace if you want to edit Articy variables

public class ArticyPlayerController : MonoBehaviour
{
    private float speed = 15f;

    private Rigidbody playerRB;
    private DialogueManager dialogueManager;

    //get reference to articy Object which will set to Articy Reference component from NPC player interacts with
    public ArticyObject availableDialogue;
 
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody>();
        dialogueManager = FindObjectOfType<DialogueManager>();
    }

    void Update()
    {
        PlayerInteraction();
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    // Simple player movement
    void PlayerMovement()
    {
        // Remove movement control while in dialogue
        if (dialogueManager.DialogueActive)
            return;

        playerRB.velocity = new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
    }

    // All interactions and key inputs player can use
    void PlayerInteraction()
    {
        // Key option to start dialogue when near NPC
        if (Input.GetKeyDown(KeyCode.E) && availableDialogue) //same as if (articyReferenceComp != null)
        {
            dialogueManager.StartDialogue(availableDialogue);
        }

        // Key option to abort dialogue
        if (dialogueManager.DialogueActive && Input.GetKeyDown(KeyCode.Escape))
        {
            //dialogueManager.CloseDialogueBox();
        }

    }


    // Trigger Enter/Exit used to determine if interaction with NPC is possible
    void OnTriggerEnter(Collider aOther)
    {
        var articyReferenceComp = aOther.GetComponent<ArticyReference>();
        if (articyReferenceComp) //same as if (articyReferenceComp != null)
        {
            availableDialogue = articyReferenceComp.reference.GetObject();
        }
    }

    void OnTriggerExit(Collider aOther) //need to clear the Articy reference after speaker leaves NPC's trigger zone
    {
        if (aOther.GetComponent<ArticyReference>() != null)
        {
            availableDialogue = null;
        }
    }
}
