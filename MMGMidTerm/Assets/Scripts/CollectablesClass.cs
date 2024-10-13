using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesClass : MonoBehaviour
{
    public InventoryItem item;

    private void Start()
    {
        if (item != null && item.collected)
        {
            gameObject.SetActive(false);
        }
    }
}
