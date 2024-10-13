using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectorScript : MonoBehaviour
{
    public static event Action<InventoryItem> OnItemAdded;
    private float timer;
    private bool canCollect;

    public static event Action OnNearInteractable;
    public static event Action OnExitInteractable;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0.5f;
        canCollect = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!canCollect)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                canCollect = true;
                timer = 0.5f;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<CollectablesClass>() != null || other.GetComponent<EnterDoor>() || other.GetComponent<AnvilImprovement>())
        {
            OnNearInteractable();
        }

        if (Input.GetKeyDown(KeyCode.E) && other.GetComponent<CollectablesClass>() != null && canCollect)
        {
            canCollect = false;
            //string itemID = other.GetComponent<CollectablesClass>().item.id;
            InventoryItem item = other.GetComponent<CollectablesClass>().item;
            OnItemAdded(item);
            other.gameObject.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CollectablesClass>() != null || other.GetComponent<EnterDoor>() || other.GetComponent<AnvilImprovement>())
        {
            OnExitInteractable();
        }
    }
}
