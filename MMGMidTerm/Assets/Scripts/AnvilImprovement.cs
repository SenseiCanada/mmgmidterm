using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnvilImprovement : MonoBehaviour
{
    public RectTransform improvePanel;
    public static event Action OnImproveStart;
    public static event Action OnImproveEnd;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            improvePanel.gameObject.SetActive(true);
            OnImproveStart();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        improvePanel.gameObject.SetActive(false);
        OnImproveEnd();
    }
}
