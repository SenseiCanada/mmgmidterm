using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    RectTransform interactHint;

    // Start is called before the first frame update
    void Start()
    {
        ItemCollectorScript.OnNearInteractable += ShowInteractHint;
        ItemCollectorScript.OnExitInteractable += HideInteractHint;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowInteractHint()
    {
        interactHint.gameObject.SetActive(true);
    }
    void HideInteractHint()
    {
        interactHint.gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        ItemCollectorScript.OnNearInteractable -= ShowInteractHint;
        ItemCollectorScript.OnExitInteractable -= HideInteractHint;
    }
}
